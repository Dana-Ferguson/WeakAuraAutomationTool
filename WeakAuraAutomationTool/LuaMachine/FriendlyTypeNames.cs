using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal static class FriendlyTypeNames
    {
        private static readonly Dictionary<Type, string> DotnetAliases = new Dictionary<Type, string>
        {
            {typeof(string), "string"},
            {typeof(object), "object"},
            {typeof(bool), "bool"},
            {typeof(byte), "byte"},
            {typeof(char), "char"},
            {typeof(decimal), "decimal"},
            {typeof(double), "double"},
            {typeof(short), "short"},
            {typeof(int), "int"},
            {typeof(long), "long"},
            {typeof(sbyte), "sbyte"},
            {typeof(float), "float"},
            {typeof(ushort), "ushort"},
            {typeof(uint), "uint"},
            {typeof(ulong), "ulong"},
            {typeof(void), "void"}
        };

        public static string GetFriendlyName(this Type type)
        {
            var sb = new StringBuilder();
            type.GetFriendlyName(sb);
            return sb.ToString();
        }

        private static void GetFriendlyName(this Type type, StringBuilder friendlyName)
        {
            if (type is null)
            {
                friendlyName.Append("null");
            }
            else if (DotnetAliases.TryGetValue(type, out var dotnetAlias))
            {
                friendlyName.Append(dotnetAlias);
            }
            else if (type.IsGenericType)
            {
                if (type.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    type.GetGenericArguments().First().GetFriendlyName(friendlyName);
                    friendlyName.Append('?');
                }
                else
                {
                    var name = type.Name;
                    var iBacktick = name.IndexOf('`');
                    if (iBacktick > 0) name = name.Remove(iBacktick);
                    friendlyName.Append(name);

                    friendlyName.Append('<');

                    var typeParameters = type.GetGenericArguments();
                    for (var i = 0; i < typeParameters.Length; ++i)
                    {
                        if (i != 0) friendlyName.Append(',');
                        typeParameters[i].GetFriendlyName(friendlyName);
                    }

                    friendlyName.Append('>');
                }
            }
            else if (type.IsArray)
            {
                type.GetElementType().GetFriendlyName(friendlyName);
                friendlyName.Append("[]");
            }
            else
            {
                friendlyName.Append(type.Name);
            }
        }
    }
}