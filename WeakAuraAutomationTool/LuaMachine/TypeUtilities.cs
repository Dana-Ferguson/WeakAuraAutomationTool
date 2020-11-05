using System;
using System.Collections.Generic;
using System.Linq;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal static class TypeUtilities
    {
        public static bool IsNullable(this Type type, out Type underlyingType)
        {
            underlyingType = null;
            if (!type.IsValueType) return false;

            underlyingType = Nullable.GetUnderlyingType(type);
            return underlyingType != null;
        }

        public static bool IsList(this Type fieldType, out Type type)
        {
            if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
            {
                type = fieldType.GetGenericArguments().First();
                return true;
            }

            type = null;
            return false;
        }

        public static bool IsDictionary(this Type fieldType, out Type keyType, out Type valueType)
        {
            if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            {
                var genericArguments = fieldType.GetGenericArguments();
                keyType = genericArguments[0];
                valueType = genericArguments[1];
                return true;
            }

            keyType = null;
            valueType = null;
            return false;
        }

        public static bool IsLuaValueType(this Type type)
            => type == typeof(string)
               || type == typeof(bool)
               || type == typeof(double)
               || type == typeof(long);
    }
}