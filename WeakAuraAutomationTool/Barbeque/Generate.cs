using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Barbeque.Classes;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque
{
    public static class Generate
    {
        public static WeakAura Go()
        {
            // Barbeque is better than Barbecue because BBQ
            var bbq = new WeakAura("BarbequeAuras");

            Build(bbq);

            return bbq;
        }

        private static void Build(WeakAura bbq)
        {
            // todo:
            // druid has spells currently suppressed
            // resto-druid: too many core CD's, too much on mobility bar
            BalanceAuras.Generate(bbq);
            FeralAuras.Generate(bbq);
            GuardianAuras.Generate(bbq);
            RestorationDruidAuras.Generate(bbq);
        }
    }
}