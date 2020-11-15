using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class DruidFeral
    {
        public static void Generate(WeakAura wa)
        {
            var feral = new Feral();
            var guardian = new Guardian();
            var resto = new RestorationDruid();

            feral.Typhoon.Talent = 7;
            guardian.IncapacitatingRoar.Talent = 8;
            resto.UrsolsVortex.Talent = 9;

            // todo: Lunar Inspiration
            var builder = new SpecBuilder(ClassSpec.Feral);

            builder.AddRightBar(
                feral.Barkskin.Buff(),
                feral.Renewal,
                feral.Typhoon,
                guardian.IncapacitatingRoar.DeBuff(),
                resto.UrsolsVortex.DeBuff(),
                feral.Rebirth,
                feral.Maim.DeBuff(),
                feral.MightyBash.DeBuff(),
                feral.MassEntanglement.DeBuff(),
                feral.Cyclone.DeBuff(),
                // druid.EntanglingRoot1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
                feral.HeartOfTheWild.Buff()
            ).AddCoreRotation(
                feral.Thrash.DoT().Passive(),
                feral.Rip.DoT().Passive(),
                feral.TigersFury.Buff(),
                feral.Rake.DoT().Passive()
            ).AddCoreCooldowns(
                feral.Berserk.Buff(),
                feral.BrutalSlash.BigStacks(),
                feral.FeralFrenzy.DeBuff()
            // Incarnation,
            ).AddBottomBar(
                feral.Dash.Buff(),
                // boomkin.TigerDash,
                feral.WildCharge,
                feral.StampedingRoar.Buff(),
                guardian.SkullBash
            ).AddTopBar(
                feral.PredatorySwiftness.Passive(),
                feral.OmenOfClarity.Passive().BigStacks().Buff(),
                feral.Bloodtalons.Passive().Buff(),
                feral.SavageRoar.Buff().Passive(),
                feral.ScentOfBlood.Buff().BigStacks(),
                feral.InfectedWounds.DeBuff().Passive()
            ).AddAlerts(
                feral.CatForm.MissingBuff().Passive(),
                feral.MoonkinForm.Buff().Passive(),
                feral.BearForm.Buff().Passive()
            ).Build(wa);
        }
    }
}