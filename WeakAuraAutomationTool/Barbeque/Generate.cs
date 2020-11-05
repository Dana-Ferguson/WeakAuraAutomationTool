using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Classes;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque
{
    public static class Generate
    {
        // todo: Race abilities
        // todo: add PvP abilities
        // todo: look at leveling???

        // todo: potions, blood lust \ heroism!, other buff checks?

        // todo: add Trinkets ~ verify that the Rotation + Cooldown groups won't collide
        // todo: add Covenant Abilities (class (on CD's))
        // todo: add Covenant Abilities (signature (on mobility))

        public static WeakAura Go()
        {
            // Barbeque is better than Barbecue because BBQ
            var bbq = new WeakAura("BarbequeAuras");

            Build(bbq);

            return bbq;
        }

        private static void Build(WeakAura bbq)
        {
            Balance(bbq);
            Feral(bbq);
        }

        private static void Feral(WeakAura wa)
        {
            var druid = new Druid();

            druid.CatForm.Invert = true;

            druid.Typhoon.Talent = 7;
            druid.IncapacitatingRoar.Talent = 8;
            druid.UrsolsVortex.Talent = 9;

            // todo: Lunar Inspiration
            var feral = new SpecBuilder(ClassSpec.DruidFeral);

            feral.AddUtility(
                druid.Barkskin1,
                druid.Renewal,
                druid.Typhoon,
                druid.Rebirth1,
                druid.Maim,
                druid.MightyBash,
                druid.MassEntanglement,
                druid.IncapacitatingRoar,
                druid.UrsolsVortex,
                druid.Cyclone,
                druid.EntanglingRoots1,
                druid.Hibernate,
                // Glow if target Enraged?
                druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                druid.RemoveCorruption,
                druid.HeartOfTheWild
            ).AddCoreRotation(
                druid.Thrash2,
                druid.Rip,
                druid.TigersFury1,
                druid.Rake1
            ).AddCoreCooldowns(
                druid.Berserk2,
                druid.BrutalSlash,
                druid.FeralFrenzy
            // Incarnation,
            ).AddMobility(
                druid.Dash,
                // boomkin.TigerDash,
                druid.WildCharge,
                druid.StampedingRoar1
            ).AddCombatBuffs(
                druid.PredatorySwiftness,
                druid.OmenOfClarity,
                druid.Bloodtalons,
                druid.SavageRoar,
                druid.ScentOfBlood1,
                druid.InfectedWounds1
            ).AddAlerts(
                druid.CatForm,
                druid.MoonkinForm1,
                druid.BearForm1
            ).Build(wa);
        }

        private static void Balance(WeakAura wa)
        {
            var druid = new Druid();
            var spec = ClassSpec.DruidBalance;

            wa.AddSpell(druid.StellarFlare, spec, -25, 300);
            druid.MoonkinForm1.Invert = true;

            druid.Maim.Talent = 7;
            druid.IncapacitatingRoar.Talent = 8;
            druid.UrsolsVortex.Talent = 9;

            var balance = new SpecBuilder(ClassSpec.DruidBalance);

            balance.AddUtility(
                druid.Barkskin1,
                druid.Renewal,
                druid.Innervate1,
                druid.Typhoon,
                druid.Rebirth1,
                druid.SolarBeam,
                druid.MightyBash,
                druid.MassEntanglement,
                druid.IncapacitatingRoar,
                druid.UrsolsVortex,
                druid.Maim,
                druid.Cyclone,
                druid.EntanglingRoots1,
                druid.Hibernate,
                // Glow if target Enraged?
                druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                druid.RemoveCorruption,
                druid.HeartOfTheWild
            ).AddCoreRotation(
                druid.Sunfire2,
                druid.Moonfire2,
                druid.Wrath1,
                druid.Starfire
            ).AddCoreCooldowns(
                druid.CelestialAlignment,
                // boomkin.IncarnationChosenOfElune,
                druid.WarriorOfElune,
                // Spell: 248280 triggers for each treant summoned -- start a 10 second timer?
                druid.ForceOfNature,
                druid.FuryOfElune,
                druid.NewMoon1
            ).AddMobility(
                druid.Dash,
                // boomkin.TigerDash,
                druid.WildCharge,
                druid.StampedingRoar1
            ).AddCombatBuffs(
                druid.Starlord,
                druid.Starfall,
                druid.Starsurge,
                // druid.SoulOfTheForest,
                druid.Solstice
            ).AddAlerts(
                druid.MoonkinForm1,
                druid.CatForm,
                druid.BearForm1
            ).Build(wa);
        }
    }
}