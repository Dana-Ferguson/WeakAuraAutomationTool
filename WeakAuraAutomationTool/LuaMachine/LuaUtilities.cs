using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NLua;
using static WeakAuraAutomationTool.LuaMachine.LuaState;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal static class LuaUtilities
    {
        // todo: this make sense to house this here?
        public static T Identity<T>(T value) => value;

        public static string GetLuaName(this FieldInfo f)
            => f?.GetCustomAttribute<LuaFieldAttribute>()?.Name
               ?? throw new Exception($"Expected to find LuaFieldAttribute for {f?.FieldType.Name} {f?.Name ?? "NULL"}.");

        public static bool IsLuaArray(this FieldInfo f)
            => f?.GetCustomAttribute<LuaArrayAttribute>() != null;

        public static bool IsLuaField(this FieldInfo f)
            => f?.GetCustomAttribute<LuaFieldAttribute>() != null;

        public static List<FieldInfo> GetLuaFields(this Type type) => type.GetFields().Where(IsLuaField).ToList();

        // todo: performance could be improved
        public static bool HasLuaToClr(this FieldInfo f, out Func<object, object> converter)
        {
            if (f is null)
            {
                converter = null;
                return false;
            }

            var methodName = f.Name + "ToClr";
            var methodInfo = f.ReflectedType.GetMethod(methodName);
            if (methodInfo == null)
            {
                converter = null;
                return false;
            }

            converter = luaValue => methodInfo.Invoke(null, new[] { lua, luaValue });
            return true;
        }

        // todo: different name?
        public static Dictionary<object, object> GetTableDict(this LuaTable table) => lua.GetTableDict(table);

        public static Dictionary<string, object> ToDictionary(this LuaTable table)
            => lua
                .GetTableDict(table)
                .ToDictionary(
                    kvp => kvp.Key.ToString(),
                    kvp => kvp.Value);

        public static List<object> ToList(this LuaTable table)
            => lua
                .GetTableDict(table)
                .Values
                .ToList();

        public enum LuaTableType
        {
            Array,
            Class,
            Hybrid
        }

        public static bool IsArray(this LuaTable table)
        {
            var i = 0;
            foreach (var tableKey in table.Keys)
            {
                if (tableKey is long j)
                {
                    // if (j != ++i) return false;
                    if (j != ++i)
                    {
                        var keys = table.Keys.Cast<object>().Select(k => $"({k.GetType().GetFriendlyName()}){k}");
                        throw new Exception($"Possible a none one-based array? keys: {string.Join(", ", keys)}");
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsArray(this LuaTable table, out LuaTableType tableType)
        {
            var i = 0;
            foreach (var tableKey in table.Keys)
            {
                if (tableKey is long j)
                {
                    if (j != ++i)
                    {
                        var keys = table.Keys.Cast<object>().Select(k => $"({k.GetType().GetFriendlyName()}){k}");
                        throw new Exception($"Possible a none one-based array? keys: {string.Join(", ", keys)}");
                        // return false;
                    }
                }
                else
                {
                    if (i != 0)
                    {
                        // var keys = table.Keys.Cast<object>().Select(k => k.ToString());
                        // Console.WriteLine($"Hybrid Lua Array Table Found! count: {i}; keys: {string.Join(", ", keys)}");
                        tableType = LuaTableType.Hybrid;
                    }
                    else
                    {
                        tableType = LuaTableType.Class;
                    }

                    return false;
                }
            }

            tableType = LuaTableType.Array;
            return true;
        }

        /// <summary>
        /// Attempts to determine the best type for a List produced via a LuaTable
        /// </summary>
        public static bool HasDefinedType(this List<object> list, out Type type)
        {
            // types are: string, bool, double, long, LuaTable ~ maybe LuaTableArray (a List<List<?>>) ???, consider this a corner case?
            var types = list.Select(i => i.GetType()).ToList();

            if (types.All<string>(out type)) return true;
            if (types.All<bool>(out type)) return true;
            if (types.All<long>(out type)) return true;
            if (types.Either<long, double>())
            {
                type = typeof(double);
                return true;
            }

            if (types.All<LuaTable>(out type)) return true;

            type = typeof(object);
            return false;
        }

        private static bool All<T>(this List<Type> types, out Type type)
        {
            var checkType = typeof(T);
            if (types.All(t => t == checkType))
            {
                type = checkType;
                return true;
            }

            type = null;
            return false;
        }

        private static bool Either<T1, T2>(this List<Type> types)
            => types.All(t
                => t == typeof(T1)
                || t == typeof(T2));

        public static LuaTable CreateTable() => (LuaTable)lua.DoString("return {}")[0];

        public static bool IsLuaDefault(this object value)
        {
            // There is some sort of rule where we need to trim\not-trim things, I don't know it?
            if (value == null) return true;
            return false;

            if (value is double d) return d == 0.0;
            if (value is long l) return l == 0;
            if (value is bool b) return !b;
            if (value is string s) return string.IsNullOrEmpty(s);
            if (value is LuaTable t) return t.Keys.Count == 0;
            if (value.GetType().IsList(out _)) return ((IList)value).Count == 0;
            if (value.GetType().IsDictionary(out _, out _)) return ((IDictionary)value).Count == 0;

            throw new Exception($"Not a Lua Value: {value.GetType().GetFriendlyName()}::{value}");
        }
    }
}