using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Barbeque.Auras;
using WeakAuraAutomationTool.Warcraft;
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
            // todo: verify that all aura_id's are unique
            // todo: Second pass on all specs0
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

            RogueAssassination.Generate(bbq);
            RogueOutlaw.Generate(bbq);
            RogueSubtlety.Generate(bbq);

            ShamanElemental.Generate(bbq);
            ShamanEnhancement.Generate(bbq);
            ShamanRestoration.Generate(bbq);

            WarlockAffliction.Generate(bbq);
            WarlockDemonology.Generate(bbq);
            WarlockDestruction.Generate(bbq);

            bbq.AddPositioningScript();
        }
    }
}