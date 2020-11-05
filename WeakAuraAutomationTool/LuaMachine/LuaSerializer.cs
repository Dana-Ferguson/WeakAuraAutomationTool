using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NLua;
using static WeakAuraAutomationTool.LuaMachine.LuaUtilities;

namespace WeakAuraAutomationTool.LuaMachine
{
    // Goal: Automate the process of maintaining the C# Classes
    // todo: Suggest Class Patch
    //      * identify nullable types

    // Original Design was: LuaToString (as JSON)
    // Then I used System.Text.Json to Convert to Classes ~ this presented an insane host of problems for many reasons
    // I've decided its much easier to write some custom mapping code -- efficiency here does not matter
    internal static class LuaSerializer
    {
        public static T Deserialize<T>(LuaTable table)
        {
            var state = new State();
            state.Push(typeof(T), "root");
            return (T)DeserializeTable(state, table);
        }

        public static LuaTable Serialize<T>(T value)
        {
            return SerializeClass(value);
        }

        private static LuaTable SerializeClass(object classValue)
        {
            var table = CreateTable();
            var fields = classValue.GetType().GetFields();
            var fieldMap = fields.Where(LuaUtilities.IsLuaField).ToDictionary(LuaUtilities.GetLuaName, Identity);

            // Deals with [LuaArray] \ LuaTableType.Hybrid binding
            if (fields.Any(LuaUtilities.IsLuaArray) && (table.IsArray(out var tableType) || tableType == LuaUtilities.LuaTableType.Hybrid))
            {
                var field = fields.First(LuaUtilities.IsLuaArray);
                var value = field.GetValue(classValue);

                if (!value.IsLuaDefault())
                {
                    var itemIndex = 0;
                    foreach (var itemValue in (IList)value)
                    {
                        table[++itemIndex] = SerializeValue(itemValue);
                    }
                }
            }

            foreach (var (key, field) in fieldMap)
            {
                var value = field.GetValue(classValue);
                var luaValue = SerializeValue(value);
                if (!luaValue.IsLuaDefault())
                {
                    if (int.TryParse(key, out var index))
                    {
                        // We assume that integers will never be encoded as strings
                        // If this is wrong, we will need to expand our lua attribute system
                        // see: Color
                        table[index] = luaValue;
                    }
                    else
                    {
                        table[key] = luaValue;
                    }
                }
            }

            return table;
        }

        private static object SerializeValue(object value)
        {
            if (value == null) return null;

            var type = value.GetType();
            if (type.IsLuaValueType())
            {
                return value;
            }
            else if (type.IsList(out var itemType))
            {
                var table = CreateTable();
                var itemIndex = 0;

                foreach (var itemValue in (IList)value)
                {
                    table[++itemIndex] = SerializeValue(itemValue);
                }

                return table;
            }
            else if (type.IsDictionary(out var keyType, out var valueType))
            {
                throw new Exception("Dictionary NYI");
            }
            else
            {
                return SerializeClass(value);
            }
        }

        private class Segment
        {
            public readonly Type Type;
            public readonly FieldInfo Field;
            public readonly string LuaName;

            public Segment(FieldInfo field, string luaName)
            {
                Type = field.FieldType;
                Field = field;
                LuaName = luaName;
            }

            public Segment(Type type, string luaName)
            {
                Type = type;
                Field = null;
                LuaName = luaName;
            }

            public override string ToString()
                => Field == null
                 ? $"{Type.GetFriendlyName()}:{LuaName}"
                 : $"{Type.GetFriendlyName()}:{Field.Name}:{LuaName}";
        }

        private class State
        {
            public readonly List<Segment> Path = new List<Segment>();

            public FieldInfo Field => Path.LastOrDefault()?.Field;
            public Type Type => Path.LastOrDefault()?.Type;
            public string LuaName => Path.LastOrDefault()?.LuaName;

            public void Push(FieldInfo field, string luaName)
            {
                Path.Add(new Segment(field, luaName));
            }

            public void Push(Type type, string luaName)
            {
                Path.Add(new Segment(type, luaName));
            }

            public void Pop()
            {
                if (Path.Count > 0) Path.RemoveAt(Path.Count - 1);
            }

            public override string ToString() => string.Join(" \\ ", Path);
        }

        private static object DeserializeTable(State state, LuaTable table)
        {
            var instance = Activator.CreateInstance(state.Type);
            var fields = state.Type.GetFields();
            var fieldMap = fields.Where(LuaUtilities.IsLuaField).ToDictionary(LuaUtilities.GetLuaName, Identity);

            var luaDict = table.ToDictionary();
            var luaKeys = luaDict.Keys.ToHashSet();

            // Deals with [LuaArray] \ LuaTableType.Hybrid binding
            if (fields.Any(LuaUtilities.IsLuaArray) && (table.IsArray(out var tableType) || tableType == LuaUtilities.LuaTableType.Hybrid))
            {
                var field = fields.First(LuaUtilities.IsLuaArray);
                var luaList = luaDict
                    .Where(luaTableEntry => int.TryParse(luaTableEntry.Key, out _))
                    .Select(luaArrayItem => new KeyValuePair<int, object>(int.Parse(luaArrayItem.Key), luaArrayItem.Value))
                    .OrderBy(luaArrayItem => luaArrayItem.Key)
                    .Select(luaArrayItem => luaArrayItem.Value)
                    .ToList();

                var listType = field.FieldType;
                var list = (IList)Activator.CreateInstance(listType);
                if (list is null) throw new Exception($"{state}: Unable to instantiate");
                listType.IsList(out var valueType);

                foreach (var luaValue in luaList)
                {
                    state.Push(valueType, $"[{list.Count}]");
                    var value = GetValueFromLua(state, luaValue);
                    list.Add(value);
                    state.Pop();

                    var key = list.Count.ToString();
                    luaDict.Remove(key);
                    luaKeys.Remove(key);
                }

                field.SetValue(instance, list);
            }

            foreach (var (fieldName, luaValue) in luaDict)
            {
                luaKeys.Remove(fieldName);
                if (!fieldMap.TryGetValue(fieldName, out var field))
                {
                    // todo: add an address variable + collate warnings (all these get caught at the bottom)
                    Console.WriteLine($"WARN: {nameof(LuaSerializer)}.{nameof(DeserializeTable)}: {state} \\ {fieldName} not found!!!! Lua is {table.SerializeToString()}");
                    continue;
                }

                state.Push(field, fieldName);
                var value = GetValueFromLua(state, luaValue);
                field.SetValue(instance, value);
                state.Pop();
            }

            foreach (var luaKey in luaKeys)
            {
                Console.WriteLine($"WARN: {state} \\ {luaKey} not consumed!!!");
            }

            return instance;
        }

        private static object GetValueFromLua(State state, object luaValue)
        {
            var field = state.Type;

            if (state.Field.HasLuaToClr(out var converter))
            {
                return converter(luaValue);
            }

            if (luaValue is LuaTable luaTable)
            {
                if (field.IsLuaValueType()) throw new Exception($"{state}: Lua is table but class field is not.");
                return GetValueFromLuaTable(state, luaTable);
            }

            if (field.IsEnum && luaValue is string text)
            {
                if (Enum.TryParse(state.Type, text, true, out var enumValue)) return enumValue;
                throw new Exception($"{state}: Could not convert {text} to enum type {state.Type}");
            }

            if (field.IsNullable(out var underlyingType))
            {
                return Convert.ChangeType(luaValue, underlyingType);
            }

            // types are: string, bool, double, long
            return Convert.ChangeType(luaValue, field);
        }

        private static object GetValueFromLuaTable(State state, LuaTable luaTable)
        {
            var field = state.Type;

            if (field.IsList(out var listType))
            {
                if (!luaTable.IsArray()) throw new Exception($"{state}: Expected LuaArray! value: {luaTable.SerializeToString()}");
                var list = (IList)Activator.CreateInstance(field);
                if (list is null) throw new Exception($"{state}: Unable to instantiate");

                foreach (var luaValue in luaTable.ToList())
                {
                    state.Push(listType, $"[{list.Count}]");
                    var value = GetValueFromLua(state, luaValue);
                    list.Add(value);
                    state.Pop();
                }

                return list;
            }

            if (field.IsDictionary(out var keyType, out var valueType))
            {
                Console.WriteLine($"TODO: {state}: This is dictionary!!!");
                return null;
            }

            return DeserializeTable(state, luaTable);
        }
    }
}