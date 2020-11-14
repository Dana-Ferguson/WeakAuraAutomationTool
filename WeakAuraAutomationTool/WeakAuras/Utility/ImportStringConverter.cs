using System;
using NLua;
using static WeakAuraAutomationTool.LuaMachine.LuaState;

namespace WeakAuraAutomationTool.WeakAuras.Utility
{
    internal static class ImportStringConverter
    {
        public static LuaTable DecompressToLuaTable(this string wa)
        {
            // var lua = LuaState.Lua;
            lua["inString"] = wa;

            // https://github.com/WeakAuras/WeakAuras2/blob/master/WeakAuras/Transmission.lua#L694
            var stringToTable = System.IO.File.ReadAllText("Lua/StringToTable.lua");
            var decompressed = lua.DoString(stringToTable)[0];

            if (!(decompressed is LuaTable table))
            {
                throw new Exception($"String should inflate to LuaTable but did not.\n  Result is {decompressed.GetType()}:{decompressed}");
            }

            return table;
        }

        public static string CompressToString(this LuaTable table)
        {
            // var lua = LuaState.Lua;
            lua["inTable"] = table;

            var tableToString = System.IO.File.ReadAllText("Lua/TableToString.lua");
            var compressed = lua.DoString(tableToString)[0];

            if (!(compressed is string wa))
            {
                throw new Exception($"Should compress to string but did not.\n  Result is {compressed.GetType()}:{compressed}");
            }

            return wa;
        }
    }
}