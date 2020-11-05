using System.Collections.Generic;
using System.Linq;
using WeakAuraAutomationTool.Automation.Positioning;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    public static class VisibilityToggle
    {
        private static string ToggleVisibilityLua { get; } = System.IO.File.ReadAllText("Lua/ToggleVisibility.lua");

        public static void AddVisibilityToggle(this Aura aura)
        {
            aura.Conditions.Add(new Condition
            {
                Check = new Check
                {
                    Trigger = -1,
                    Variable = "customcheck",
                    Op = "CVAR_UPDATE",
                    Value = ToggleVisibilityLua
                },
                Changes = new List<Change>
                {
                    new Change
                    {
                        Property = "alpha",
                        Value = 0.0
                    }
                }
            });
        }
    }
}