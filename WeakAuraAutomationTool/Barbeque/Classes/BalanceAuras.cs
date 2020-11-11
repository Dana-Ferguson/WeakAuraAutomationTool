using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Classes
{
    internal static class BalanceAuras
    {
        public static void Generate(WeakAura wa)
        {
            var balance = new Balance();
            var feral = new Feral();
            var guardian = new Guardian();
            var resto = new RestorationDruid();

            balance.MoonkinForm.Invert = true;
            feral.Maim.Talent = 7;
            guardian.IncapacitatingRoar.Talent = 8;
            resto.UrsolsVortex.Talent = 9;

            // Stellar Flare is right ~ pretty sure the Druid\Balance() split ruins this
            balance.Sunfire.Durations.Add(18);
            balance.Moonfire.Durations.Add(22);
            balance.StellarDrift.Passive();

            var spec = ClassSpec.Balance;
            var builder = new SpecBuilder(spec);

            // todo: should this be a standard?
            wa.AddSpell(balance.StellarFlare, spec, -25, 300);

            builder.AddUtility(
                balance.Barkskin.Buff(),
                balance.Renewal,
                balance.Innervate,
                balance.Typhoon,
                balance.Rebirth,
                balance.SolarBeam.DeBuff(),
                balance.MightyBash.DeBuff(),
                balance.MassEntanglement.DeBuff(),
                guardian.IncapacitatingRoar.DeBuff(),
                resto.UrsolsVortex.DeBuff(),
                feral.Maim.DeBuff(),
                balance.Cyclone.DeBuff(),
                // druid.EntanglingRoots1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
                balance.HeartOfTheWild.Buff()
            ).AddCoreRotation(
                balance.Sunfire.DoT().Passive(),
                balance.Moonfire.DoT().Passive(),
                balance.Wrath.AssociateAura(balance.SolarEclipse).BigStacks(),
                balance.Starfire.AssociateAura(balance.LunarEclipse).BigStacks()
            ).AddCoreCooldowns(
                balance.CelestialAlignment.Buff(),
                // druid.IncarnationChosenOfElune,
                balance.WarriorOfElune.DeBuff(),
                // Spell: 248280 triggers for each treant summoned -- start a 10 second timer?
                balance.ForceOfNature,
                balance.FuryOfElune.Buff(),
                balance.NewMoon
            ).AddMobility(
                balance.Dash.Buff(),
                // druid.TigerDash,
                balance.WildCharge,
                balance.StampedingRoar.Buff()
            ).AddCombatBuffs(
                balance.Starlord.Buff().Passive(),
                balance.Starfall.Buff().Passive(),
                balance.Starsurge.Buff().Passive(),
                // druid.SoulOfTheForest,
                balance.Solstice.Buff().Passive()
            ).AddAlerts(
                balance.MoonkinForm.Buff().Passive(),
                balance.CatForm.Buff().Passive(),
                balance.BearForm.Buff().Passive()
            ).Build(wa);
        }
    }
}