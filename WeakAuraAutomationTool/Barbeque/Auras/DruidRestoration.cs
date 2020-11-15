using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class DruidRestoration
    {
        public static void Generate(WeakAura wa)
        {
            var resto = new RestorationDruid();
            var feral = new Feral();
            var guardian = new Guardian();

            // typhoon, maim, incap
            feral.Maim.Talent = 7;
            guardian.IncapacitatingRoar.Talent = 8;
            resto.UrsolsVortex.Talent = 9;

            var spec = ClassSpec.RestorationDruid;
            var builder = new SpecBuilder(spec);

            builder.AddRightBar(
                resto.Barkskin.Buff(),
                resto.Renewal,
                resto.Innervate,
                resto.Typhoon,
                resto.Rebirth,
                resto.SolarBeam.DeBuff(),
                resto.MightyBash.DeBuff(),
                resto.MassEntanglement.DeBuff(),
                guardian.IncapacitatingRoar.DeBuff(),
                resto.UrsolsVortex.DeBuff(),
                feral.Maim.DeBuff(),
                resto.Cyclone.DeBuff(),
                // druid.EntanglingRoots1,
                // druid.Hibernate,
                // Glow if target Enraged?
                // druid.Soothe,
                // Glow if target -or- Player is Corrupted?
                // druid.RemoveCorruption,
                resto.HeartOfTheWild.Buff()
            ).AddCoreRotation(
                resto.Swiftmend,
                resto.Efflorescence,
                resto.WildGrowth,
                resto.Lifebloom
            ).AddCoreCooldowns(
                resto.Tranquility.Buff(),
                resto.IncarnationTreeOfLife.Buff(),
                resto.CenarionWard,
                resto.Flourish,
                resto.Overgrowth
            ).AddBottomBar(
                resto.Dash.Buff(),
                resto.WildCharge,
                resto.StampedingRoar.Buff(),
                resto.NaturesSwiftness,
                resto.Ironbark,
                resto.NaturesCure
            ).AddTopBar(
                resto.OmenOfClarity.Buff().Passive().BigStacks(),
                resto.Abundance.Buff().Passive().BigStacks(),
                resto.SoulOfTheForest.Buff().Passive()
            ).AddAlerts(
                resto.Innervate.Buff().Passive(),
                resto.Tranquility.Buff().Passive(),
                resto.SoulOfTheForest.Buff().Passive(),
                resto.MoonkinForm.Buff().Passive(),
                resto.CatForm.Buff().Passive(),
                resto.BearForm.Buff().Passive()
            ).Build(wa);
        }
    }
}