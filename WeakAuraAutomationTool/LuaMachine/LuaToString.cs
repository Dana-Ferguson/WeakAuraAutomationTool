using System;
using System.Text;
using NLua;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal static class LuaToString
    {
        public static string SerializeToString(this LuaTable table) => Table(table);

        private static string Table(LuaTable table)
        {
            var sb = new StringBuilder();

            sb.AppendLine("{");
            Table(table, sb, 1);
            sb.AppendLine().AppendLine("}");

            return sb.ToString();
        }

        private static void Table(LuaTable table, StringBuilder sb, int level)
        {
            var dict = table.GetTableDict();
            foreach (var (key, value) in dict)
            {
                sb.Append(new string(' ', level * 3));
                sb.Append('"').Append(key).Append("\": ");

                SerializeValue(sb, level, value);

                sb.Append(",").AppendLine();
            }

            sb.Length -= 3;
        }

        private static void SerializeValue(StringBuilder sb, int level, object value)
        {
            if (value is LuaTable subTable)
            {
                if (subTable.Keys.Count == 0)
                {
                    // We really don't know if array or table is intended here
                    sb.Append("[]");
                }
                else if (IsArray(subTable))
                {
                    sb.AppendLine("[");
                    SerializeArray(subTable, sb, level + 1);
                    sb.AppendLine().Append(new string(' ', level * 3)).Append("]");
                }
                else
                {
                    sb.AppendLine("{");
                    Table(subTable, sb, level + 1);
                    sb.AppendLine().Append(new string(' ', level * 3)).Append("}");
                }
            }
            else if (value is string text)
            {
                sb.Append('"').Append(text).Append('"');
            }
            else if (value is bool boolean)
            {
                sb.Append(boolean.ToString().ToLowerInvariant());
            }
            else if (value is double number)
            {
                sb.Append(number);
            }
            else if (value is long integer)
            {
                sb.Append(integer);
            }
            else
            {
                throw new Exception($"Unknown value type {value.GetType().Name} :: {value}");
            }
        }

        public static void SerializeArray(LuaTable table, StringBuilder sb, int level)
        {
            var dict = table.GetTableDict();
            foreach (var (key, value) in dict)
            {
                sb.Append(new string(' ', level * 3));
                SerializeValue(sb, level, value);

                sb.Append(",").AppendLine();
            }

            sb.Length -= 3;
        }

        public static bool IsArray(LuaTable table)
        {
            var i = 0;
            foreach (var tableKey in table.Keys)
            {
                if (tableKey is long j)
                {
                    if (j != ++i) return false;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}