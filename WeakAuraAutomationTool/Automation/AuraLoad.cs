using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    public static class AuraLoad
    {
        public static void LoadIfTalent(this Aura aura, int talent)
        {
            if (talent == 0) return;

            aura.Load.Talent = new Talent
            {
                Single = talent
            };
        }

        // note: Use booleans are ignored and it just checks to see if the object exists or not
        public static void LoadIf(this Aura aura, ClassSpec classSpec)
        {
            aura.Load.ClassAndSpec = new ClassAndSpec { Single = (int)classSpec };
            aura.Load.UseClassAndSpec = true;
        }

        public static void LoadInCombat(this Aura aura)
        {
            aura.Load.UseCombat = true;
        }

        public static List<Aura> LoadInCombat(this List<Aura> auras)
        {
            auras.ForEach(LoadInCombat);
            return auras;
        }
    }
}