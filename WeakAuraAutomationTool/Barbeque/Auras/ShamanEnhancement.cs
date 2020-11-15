using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class ShamanEnhancement
    {
        public static void Generate(WeakAura wa)
        {
            var enhancement = new Enhancement();

            var builder = new SpecBuilder(ClassSpec.Enhancement);

            builder.AddOverflow(
                enhancement.EarthElemental.Buff(),
                enhancement.AstralShift.Buff(),
                enhancement.Heroism.Buff(),
                enhancement.Hex.DeBuff(),
                enhancement.EarthShield
            ).AddRightBar(
                enhancement.Ascendance.Buff(), // T7
                enhancement.EarthenSpike.DeBuff(), // T7
                enhancement.Stormkeeper.Buff(), // T6
                enhancement.Sundering.DeBuff(), // T6
                enhancement.FeralSpirit.Buff(),
                enhancement.WindRushTotem.Buff() // T5
            ).AddCoreRotation(
                enhancement.FrostShock.DeBuff(),
                enhancement.FlameShock.DeBuff(),
                enhancement.Stormstrike,
                enhancement.LavaLash,
                enhancement.IceStrike.Buff(), // T2
                enhancement.ElementalBlast.Buff(), // T1
                enhancement.FireNova.Buff(), // T4
                enhancement.CrashLightning
            ).AddCoreCooldowns(
            ).AddBottomBar(
                enhancement.FeralLunge, // T5
                enhancement.EarthbindTotem.Buff(),
                enhancement.CapacitorTotem.Buff(),
                enhancement.HealingStreamTotem.Buff(),
                enhancement.TremorTotem.Buff(),
                enhancement.WindShear,
                enhancement.Purge,
                enhancement.CleanseSpirit
            ).AddTopBar(
                enhancement.FrostShock.Passive().Buff(),
                enhancement.MaelstromWeapon.Passive().Buff(),
                enhancement.Stormbringer.Passive().Buff(),
                enhancement.Hailstorm.Passive().Buff(), // T4
                enhancement.NaturesGuardian.Passive().Buff()

            ).AddAlerts(
                enhancement.WaterWalking.Passive().Buff(),
                enhancement.Windfury.Passive().MissingBuff()
            ).Build(wa);
        }
    }
}