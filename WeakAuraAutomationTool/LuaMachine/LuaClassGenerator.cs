using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLua;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal class LuaClass
    {
        // public readonly LuaTable Table;
        public readonly string Name;

        public readonly Dictionary<string, object> FieldDictionary;

        public LuaClass(LuaTable table, string name)
        {
            FieldDictionary = table.ToDictionary();
            // Table = table;
            Name = name;
        }

        public LuaClass(Dictionary<string, object> fieldDictionary, string name)
        {
            FieldDictionary = fieldDictionary;
            Name = name;
        }

        public override string ToString() => $"LuaClass:{Name}[{FieldDictionary.Count}]";
    }

    internal class LuaClassGroup
    {
        public readonly string Name;

        public readonly Dictionary<string, object> FieldDictionary;

        public LuaClassGroup(LuaClass luaClass)
        {
            FieldDictionary = new Dictionary<string, object>(luaClass.FieldDictionary);
            Name = luaClass.Name;
        }

        public bool Updated = true;

        public void Add(LuaClass luaClass)
        {
            if (luaClass.Name != Name) throw new Exception($"Name mismatch {luaClass.Name} != {Name}");
            foreach (var (k, v) in luaClass.FieldDictionary)
            {
                if (!FieldDictionary.ContainsKey(k))
                {
                    Updated = true;
                    FieldDictionary[k] = v;
                }
            }
        }
    }

    internal class LuaClassDict
    {
        public readonly Dictionary<string, LuaClassGroup> LuaClassGroups = new Dictionary<string, LuaClassGroup>();

        public IEnumerable<string> Names => LuaClassGroups.Keys;

        public void Add(LuaClass luaClass)
        {
            if (LuaClassGroups.TryGetValue(luaClass.Name, out var group))
            {
                group.Add(luaClass);
            }
            else
            {
                LuaClassGroups[luaClass.Name] = new LuaClassGroup(luaClass);
            }
        }

        public bool IsUpdated(string name) => LuaClassGroups[name].Updated;

        /// <summary>
        /// Gets the field dictionary and resets the Updated flag.
        /// </summary>
        public Dictionary<string, object> GetFieldDictionary(string name)
        {
            LuaClassGroups[name].Updated = false;
            return LuaClassGroups[name].FieldDictionary;
        }
    }

    /// <remarks>
    /// Many things in the LuaTable are 'doubles' when they should probably be 'long';
    /// Since these tables are just the compressed Lua (from the WoW engine), it might be the case that these
    /// values are also 'doubles' there too.
    /// </remarks>
    internal static class LuaClassGenerator
    {
        public static string Generate(LuaTable table, string name = "table")
        {
            var sb = new StringBuilder();
            // GenerateFromTable(sb, lua, table, name);
            var classes = BuildClasses(table, name);
            GenerateClasses(sb, classes);
            return sb.ToString();
        }

        private static void GenerateClasses(StringBuilder sb, LuaClassDict luaClasses)
        {
            // .IsUpdated(name)
            foreach (var name in luaClasses.Names)
            {
                GenerateClassFromDictionary(sb, name, luaClasses.GetFieldDictionary(name));
            }
        }

        private static LuaClassDict BuildClasses(LuaTable table, string name)
        {
            var luaClasses = new LuaClassDict();

            luaClasses.Add(new LuaClass(table, name));
            BuildClasses(luaClasses, table);

            return luaClasses;
        }

        private static void BuildClasses(LuaClassDict luaClasses, LuaTable luaTable)
        {
            BuildClasses(luaClasses, luaTable.ToDictionary());
        }

        private static void BuildClasses(LuaClassDict luaClasses, Dictionary<string, object> luaFields)
        {
            foreach (var (name, value) in luaFields)
            {
                if (value is LuaTable table)
                {
                    if (table.IsArray())
                    {
                        var list = table.ToList();
                        if (list.Count != 0 && list.HasDefinedType(out var listType) && listType == typeof(LuaTable))
                        {
                            // We will make the big-brain assumption that all the tables here belong to the same class
                            var allFieldsInListClass = new Dictionary<string, object>();
                            list
                                .Cast<LuaTable>()
                                .SelectMany(t => t.ToDictionary())
                                .ToList()
                                .ForEach(kvp => allFieldsInListClass[kvp.Key] = kvp.Value);

                            luaClasses.Add(new LuaClass(allFieldsInListClass, name.ToCSharpName()));
                            BuildClasses(luaClasses, allFieldsInListClass);

                            foreach (var luaTable in list.Cast<LuaTable>().ToList())
                            {
                                BuildClasses(luaClasses, luaTable);
                            }
                        }
                    }
                    else
                    {
                        luaClasses.Add(new LuaClass(table, name.ToCSharpName()));
                        BuildClasses(luaClasses, table);
                    }
                }
            }
        }

        private static void GenerateClassFromDictionary(StringBuilder sb, string className, Dictionary<string, object> fieldDictionary)
        {
            sb.AppendLine($"public class {className}");
            sb.AppendLine("{");

            GenerateFieldsFromDictionary(sb, className, fieldDictionary);

            sb.AppendLine("}");
            sb.AppendLine();
        }

        private static void GenerateFieldsFromDictionary(StringBuilder sb, string className, Dictionary<string, object> fieldDictionary)
        {
            foreach (var (luaName, value) in fieldDictionary.OrderBy(kvp => kvp.Key))
            {
                var fieldName = luaName.ToCSharpName();

                if (value is LuaTable tableValue)
                {
                    if (tableValue.IsArray())
                    {
                        var listValue = tableValue.ToList();
                        if (listValue.Count == 0)
                        {
                            Console.WriteLine($"{className}.{fieldName} does not have any elements so a type could not be determined.");
                            sb.AppendLine($"    [LuaField(\"{luaName}\")] public List<object> {fieldName};");
                        }
                        else if (listValue.HasDefinedType(out var listType))
                        {
                            // Should break off into recursion here -- I am not planning to handle this scenario at this time
                            // e.g. the inner body of this foreach loop could be recursively called ot construct a complex ListType
                            if (listType == typeof(LuaTable))
                            {
                                // We will make the big-brain assumption that all the tables here belong to the same class
                                // todo: what is happening here?
                                var fields = new Dictionary<string, object>();
                                listValue
                                    .Cast<LuaTable>()
                                    .SelectMany(t => t.ToDictionary())
                                    .ToList()
                                    .ForEach(kvp => fields[kvp.Key] = kvp.Value);
                                sb.AppendLine($"    [LuaField(\"{luaName}\")] public List<{fieldName}> {fieldName};");
                            }
                            else
                            {
                                var typeName = listType.GetTypeName();
                                sb.AppendLine($"    [LuaField(\"{luaName}\")] public List<{typeName}> {fieldName};");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{className}.{fieldName} does not have a defined list type!");
                            sb.AppendLine($"    [LuaField(\"{luaName}\")] public List<object> {fieldName};");
                        }
                    }
                    else
                    {
                        sb.AppendLine($"    [LuaField(\"{luaName}\")] public {fieldName} {fieldName};");
                    }
                }
                else
                {
                    var typeName = value.GetTypeName();
                    sb.AppendLine($"    [LuaField(\"{luaName}\")] public {typeName} {fieldName};");
                }
            }
        }

        private static string GetTypeName(this object value)
        {
            if (value is Type type)
            {
                if (type == typeof(string)) return "string";
                if (type == typeof(bool)) return "bool";
                if (type == typeof(long)) return "long";
                if (type == typeof(double)) return "double";

                throw new Exception($"Unknown type! {type.Name}");
            }

            if (value is string) return "string";
            if (value is bool) return "bool";
            if (value is long) return "long";
            if (value is double) return "double";

            throw new Exception($"Unknown type! {value.GetType().Name}:{value}");
        }

        /*
        [LuaField("text_color")] public List<int> TextColor;
        [LuaField("text_automaticWidth")] public string TextAutomaticWidth;
        */

        private static string ToCSharpName(this string luaName)
        {
            var sb = new StringBuilder();

            var capitalize = true;
            foreach (var letter in luaName)
            {
                if (capitalize)
                {
                    sb.Append(char.ToUpperInvariant(letter));
                    capitalize = false;
                    continue;
                }

                if (letter == '_')
                {
                    capitalize = true;
                    continue;
                }

                sb.Append(letter);
            }

            return sb.ToString();
        }
    }
}