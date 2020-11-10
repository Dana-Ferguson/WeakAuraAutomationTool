using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Classes;
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

            // Build(bbq);
            Build2(bbq);

            return bbq;
        }

        private static void Build(WeakAura bbq)
        {
            // todo: druid has spells currently suppressed
            Balance(bbq);
            Feral(bbq);
        }

        private static void Build2(WeakAura bbq)
        {
            // todo: druid has spells currently suppressed
            Balance2(bbq);
            // Feral(bbq);
        }

        private static void Balance2(WeakAura wa)
        {
            var druid = new Balance();
            var spec = ClassSpec.Balance;

            druid.MoonkinForm.Invert = true;

            // Spells attached to affinities;
            var feral = new Feral();
            var maim = feral.Maim;
            maim.Talent = 7;

            var guardian = new Guardian();
            var incapacitatingRoar = guardian.IncapacitatingRoar;
            incapacitatingRoar.Talent = 8;

            var resto = new RestorationDruid();
            var ursolsVortex = resto.UrsolsVortex;
            ursolsVortex.Talent = 9;

            druid.Wrath.BigStacks = true;
            druid.Starfire.BigStacks = true;

            // druid.StellarFlare.Type = SpellType.DoT;
            // druid.Sunfire.Type = SpellType.DoT;
            // druid.Moonfire.Type = SpellType.DoT;

            // todo: these don't work
            druid.StellarFlare.Durations.Add(24);
            druid.Sunfire.Durations.Add(18);
            druid.Moonfire.Durations.Add(22);

            var balance = new SpecBuilder(ClassSpec.Balance);

            wa.AddSpell(druid.StellarFlare, spec, -25, 300);

            balance.AddUtility(
                druid.Barkskin.Buff(),
                druid.Renewal,
                druid.Innervate,
                druid.Typhoon,
                druid.Rebirth,
                druid.SolarBeam.DeBuff(),
                druid.MightyBash.DeBuff(),
                druid.MassEntanglement.DeBuff(),
                incapacitatingRoar.DeBuff(),
                ursolsVortex.DeBuff(),
                maim.DeBuff(),
                druid.Cyclone.DeBuff(),
                // druid.EntanglingRoots1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
                druid.HeartOfTheWild
            ).AddCoreRotation(
                druid.Sunfire.DoT().NoCd(),
                druid.Moonfire.DoT().NoCd(),
                druid.Wrath,
                druid.Starfire
            ).AddCoreCooldowns(
                druid.CelestialAlignment.Buff(),
                // druid.IncarnationChosenOfElune,
                druid.WarriorOfElune.DeBuff(),
                // Spell: 248280 triggers for each treant summoned -- start a 10 second timer?
                druid.ForceOfNature,
                druid.FuryOfElune.Buff(),
                druid.NewMoon
            ).AddMobility(
                druid.Dash,
                // druid.TigerDash,
                druid.WildCharge,
                druid.StampedingRoar.Buff()
            ).AddCombatBuffs(
                druid.Starlord.Buff().NoCd(),
                druid.Starfall.Buff().NoCd(),
                druid.Starsurge.Buff().NoCd(),
                // druid.SoulOfTheForest,
                druid.Solstice.Buff().NoCd()
            ).AddAlerts(
                druid.MoonkinForm.Buff().NoCd(),
                druid.CatForm.Buff().NoCd(),
                druid.BearForm.Buff().NoCd()
            ).Build(wa);
        }

        private static void Feral(WeakAura wa)
        {
            var druid = new DruidOld();

            druid.CatForm.Invert = true;

            druid.Typhoon.Talent = 7;
            druid.IncapacitatingRoar.Talent = 8;
            druid.UrsolsVortex.Talent = 9;

            // todo: Lunar Inspiration
            var feral = new SpecBuilder(ClassSpec.Feral);

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
                // druid.EntanglingRoots1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
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
            var druid = new DruidOld();
            var spec = ClassSpec.Balance;

            wa.AddSpell(druid.StellarFlare, spec, -25, 300);
            druid.MoonkinForm1.Invert = true;

            druid.Maim.Talent = 7;
            druid.IncapacitatingRoar.Talent = 8;
            druid.UrsolsVortex.Talent = 9;

            var balance = new SpecBuilder(ClassSpec.Balance);

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
                // druid.EntanglingRoots1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
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