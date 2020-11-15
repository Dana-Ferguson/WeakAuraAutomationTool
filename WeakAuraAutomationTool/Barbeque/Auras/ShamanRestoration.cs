using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class ShamanRestoration
    {
        public static void Generate(WeakAura wa)
        {
            var restoration = new RestorationShaman();

            var builder = new SpecBuilder(ClassSpec.RestorationShaman);

            builder.AddOverflow(
                restoration.EarthElemental.Buff(),
                restoration.AstralShift.Buff(),
                restoration.Heroism.Buff(),
                restoration.Hex.DeBuff(),
                restoration.LavaBurst,
                restoration.EarthgrabTotem
            ).AddRightBar(
                restoration.HealingTideTotem.Buff(),
                restoration.ManaTideTotem.Buff(),
                restoration.SpiritLinkTotem.Buff(),
                restoration.Ascendance.Buff(), // T7
                restoration.WindRushTotem.Buff(), // T6
                restoration.SpiritwalkersGrace.Buff()
            ).AddCoreRotation(
                // todo: track charges!
                restoration.EarthShield.Buff(),
                restoration.HealingRain.Buff(),
                restoration.Riptide.Buff(),
                restoration.UnleashLife.Buff(), // T1
                restoration.SurgeOfEarth,
                restoration.Downpour, // T6
                restoration.Wellspring
            // restoration.CloudburstTotem, // T6 (replaces Healing Stream totem)
            ).AddCoreCooldowns(
                restoration.EarthenWallTotem.Buff(), // T4
                restoration.AncestralProtectionTotem.Buff() // T4
            ).AddBottomBar(
                restoration.EarthbindTotem.Buff(),
                restoration.CapacitorTotem.Buff(),
                restoration.HealingStreamTotem.Buff(),
                restoration.TremorTotem.Buff(),
                restoration.WindShear,
                restoration.Purge,
                restoration.PurifySpirit
            ).AddTopBar(
                restoration.FrostShock.Passive().Buff(),
                // todo: will this only show up when it's been used? (also enhancement)
                restoration.NaturesGuardian.Passive().Buff(),
                restoration.HighTide.Passive().Buff()
            ).AddAlerts(
                restoration.WaterWalking.Passive().Buff(),
                restoration.WaterShield.Passive().MissingBuff()
            ).Build(wa);
        }
    }
}