using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class DruidGuardian
    {
        public static void Generate(WeakAura wa)
        {
            var guardian = new Guardian();
            var resto = new RestorationDruid();

            guardian.Typhoon.Talent = 7;
            guardian.Maim.Talent = 8;
            resto.UrsolsVortex.Talent = 9;

            var builder = new SpecBuilder(ClassSpec.Guardian);

            builder.AddRightBar(
                guardian.SurvivalInstincts.Buff().BigStacks(),
                guardian.Barkskin.Buff(),
                guardian.IncapacitatingRoar.DeBuff(),
                guardian.MightyBash.DeBuff(),
                guardian.MassEntanglement,
                guardian.Renewal,
                guardian.Typhoon,
                guardian.Rebirth,
                guardian.Maim.DeBuff(),
                guardian.Typhoon.DeBuff(),
                resto.UrsolsVortex.DeBuff(),
                guardian.Cyclone.DeBuff(),
                // druid.EntanglingRoot1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
                guardian.HeartOfTheWild.Buff()
            ).AddCoreRotation(
                guardian.Moonfire.DoT().Passive().AssociateAura(guardian.GalacticGuardian),
                guardian.Thrash.DeBuff(),
                guardian.Mangle.Buff().AssociateAura(guardian.Gore),
                guardian.Maul
            ).AddCoreCooldowns(
                guardian.Berserk.Buff(),
                guardian.FrenziedRegeneration.BigStacks().Buff(),
                guardian.Ironfur.BigStacks().Buff(),
                guardian.Pulverize.DeBuff(),
                guardian.BristlingFur.Buff()
            // Incarnation,
            ).AddBottomBar(
                guardian.Dash.Buff(),
                guardian.WildCharge,
                guardian.StampedingRoar.Buff(),
                guardian.SkullBash
            ).AddTopBar(
                guardian.Ironfur.Buff().Passive(),
                guardian.InfectedWounds.DeBuff().Passive(),
                guardian.ToothAndClaw.Passive().DeBuff().BigStacks(),
                guardian.GalacticGuardian.Passive().DeBuff()
            ).AddAlerts(
                guardian.Barkskin.Buff().Passive(),
                guardian.FrenziedRegeneration.Buff().Passive(),
                guardian.SurvivalInstincts.Buff().Passive(),
                guardian.CatForm.Buff().Passive(),
                guardian.MoonkinForm.Buff().Passive(),
                guardian.BearForm.MissingBuff().Passive()
            ).Build(wa);
        }
    }
}