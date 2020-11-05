using System.Collections.Generic;
using System.Linq;
using WeakAuraAutomationTool.Automation.Positioning;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    internal static class DisplaceAuraByTalents
    {
        private static string PositionByTalentsLua { get; } = System.IO.File.ReadAllText("Lua/PositionByTalents.lua");

        public static void DisplaceByTalents(this IEnumerable<Aura> auras, AuraGrid grid, int position, params int[] talents)
        {
            foreach (var aura in auras)
            {
                aura.DisplaceByTalents(grid, position, talents.ToArray());
            }
        }

        // Note: this does not seem to be the way you are supposed to use Conditions, if it works, it works
        public static void DisplaceByTalents(this Aura aura, AuraGrid grid, int position, params int[] talents)
        {
            var script = PositionByTalentsLua;

            var talentsLuaArray = $"{position}, {talents.Length}, " + string.Join(", ", talents);
            script = script.Replace("%talents%", talentsLuaArray);
            script = script.Replace("%update%", grid.GetUpdateLua());
            script = script.Replace("%check%", grid.GetBoundsCheckLua());
            script = script.Replace("%resetLine%", grid.GetResetLineLua());
            script = script.Replace("%nextLine%", grid.GetNextLineLua());
            // script = script.Replace("%name%", aura.Id.Split('_')[2]);
            script = script.Replace("%id%", aura.Id);

            aura.Conditions.Add(new Condition
            {
                Check = new Check
                {
                    Trigger = -1,
                    Variable = "customcheck",
                    Op = "PLAYER_TALENT_UPDATE",
                    Value = script
                },
                Changes = new List<Change>()
            });
        }
    }
}