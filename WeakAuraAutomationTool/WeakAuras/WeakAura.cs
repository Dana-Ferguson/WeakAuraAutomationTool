using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NLua;

using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Automation.Positioning;
using WeakAuraAutomationTool.Barbeque;
using WeakAuraAutomationTool.Classes;
using WeakAuraAutomationTool.LuaMachine;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras.Utility;

namespace WeakAuraAutomationTool.WeakAuras
{
    /// <summary>
    /// Consumes and produces WeakAura LuaTables
    /// </summary>
    public class WeakAura
    {
        public WeakAuraTable Table;

        /// <summary>
        /// Text is either import string or name of the WeakAura.
        /// </summary>
        public WeakAura(string text)
        {
            if (text.StartsWith("!"))
            {
                var table = text.DecompressToLuaTable();
                Table = LuaSerializer.Deserialize<WeakAuraTable>(table);
            }
            else
            {
                Table = WeakAuraTable.Generate(text);
            }
        }

        public WeakAura(LuaTable table)
        {
            Table = LuaSerializer.Deserialize<WeakAuraTable>(table);
        }

        public LuaTable ToLuaTable() => LuaSerializer.Serialize(Table);

        public string ToCompressedString() => ToLuaTable().CompressToString();

        public string GenerateCode() => LuaClassGenerator.Generate(ToLuaTable(), nameof(WeakAuraTable));

        public override string ToString() => ToLuaTable().SerializeToString();
    }
}