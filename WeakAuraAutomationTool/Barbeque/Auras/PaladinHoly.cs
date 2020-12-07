using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class PaladinHoly
    {
        public static void Generate(WeakAura wa)
        {
            // todo: Beacon of Light missing Alert
            var holy = new HolyPaladin();

            var builder = new SpecBuilder(ClassSpec.Affliction);

            builder.AddOverflow(
            ).AddRightBar(
                holy.AvengingWrath.Buff(),
                holy.LayOnHands,
                holy.BlessingOfSacrifice.Buff(),
                holy.DivineProtection.Buff(),
                holy.AuraMastery.Buff(),
                holy.BlessingOfProtection,
                holy.BlessingOfFreedom
            ).AddCoreRotation(
                holy.HolyShock,
                // with Judgment of Light
                holy.Judgment.DeBuff(),
                holy.BestowFaith, // T
                holy.HolyPrism // T
            ).AddCoreCooldowns(
            ).AddBottomBar(
            ).AddTopBar(
            ).AddAlerts(
            ).Build(wa);
        }
    }
}