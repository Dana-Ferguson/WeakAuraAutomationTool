using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Barbeque.Auras;
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
            // todo: Second pass on all specs
            DeathKnightBlood.Generate(bbq);
            DeathKnightFrost.Generate(bbq);
            DeathKnightUnholy.Generate(bbq);

            DemonHunterHavoc.Generate(bbq);
            DemonHunterVengeance.Generate(bbq);

            DruidBalance.Generate(bbq);
            DruidFeral.Generate(bbq);
            DruidGuardian.Generate(bbq);
            DruidRestoration.Generate(bbq);

            PriestDiscipline.Generate(bbq);
            PriestHoly.Generate(bbq);
            PriestShadow.Generate(bbq);
        }
    }
}