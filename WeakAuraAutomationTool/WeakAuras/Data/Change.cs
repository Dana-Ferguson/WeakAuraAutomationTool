using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using NLua;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Change
    {
        [LuaField("property")] public string Property;
        // maybe be bool -or- double[4] (Color)
        [LuaField("value")] public object Value;

        public static object ValueToLua(NLua.Lua lua, object value)
        {
            if (value is bool) return value;
            if (value is Color c)
            {
                // var table = lua.NewTable();

                var r = c.R;
                var g = c.G;
                var b = c.B;
                var a = c.A;

                // todo: I don't really know the best way to do this
                return lua.DoString($"return [{r}, {g}, {b}, {a}]")[0];
            }

            throw new Exception(nameof(Value));
        }

        public static object ValueToClr(NLua.Lua lua, object value)
        {
            if (value is bool) return value;
            if (value is LuaTable table && table.IsArray())
            {
                var list = table.ToList();
                if (list.HasDefinedType(out var type))
                {
                    if (type == typeof(long) || type == typeof(double))
                    {
                        return new Color(list.Cast<double>());
                    }
                }
            }

            if (value is int) return value;
            if (value is long) return value;
            if (value is double) return value;
            if (value is string) return value;

            throw new Exception($"{nameof(Value)} is {value.GetType()}");
        }
    }
}