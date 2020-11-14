using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class ShamanElemental
    {
        public static void Generate(WeakAura wa)
        {
            var elemental = new Elemental();

            var builder = new SpecBuilder(ClassSpec.Elemental);

            // Lightning Shield, Flametongue Weapon?
            builder.AddOverflow(
                elemental.EarthElemental.Buff(),
                elemental.AstralShift.Buff(),
                elemental.Heroism.Buff(),
                elemental.Hex.DeBuff(),
                elemental.CleanseSpirit,
                // or debuff?
                elemental.NaturesGuardian.Buff() // T5
            ).AddUtility(
                elemental.Thunderstorm.DeBuff(),
                elemental.SpiritwalkersGrace.Buff(),
                elemental.WindRushTotem.Buff(), // T5
                elemental.AncestralGuidance.Buff() // T5
            ).AddCoreRotation(
                elemental.FlameShock.DeBuff(),
                elemental.LavaBurst,
                elemental.EchoingShock.Buff(), // T3
                elemental.ElementalBlast.Buff(), // T3
                elemental.Icefury.Buff() // T6 (IceFury Overload might be the buff)
            ).AddCoreCooldowns(
                // todo: pet -or- totem tracking?
                elemental.FireElemental.Buff(),
                elemental.StaticDischarge.Buff(), // T2
                elemental.LiquidMagmaTotem.Buff(), // T4
                elemental.Stormkeeper.Buff(), // T7
                elemental.Ascendance.Buff() // T7
            ).AddMobility(
                elemental.EarthbindTotem.Buff(),
                elemental.CapacitorTotem.Buff(),
                elemental.HealingStreamTotem.Buff(),
                elemental.TremorTotem.Buff(),
                elemental.WindShear,
                elemental.Purge
            ).AddCombatBuffs(
                elemental.FrostShock.Passive().Buff(),
                elemental.SurgeOfPower.Passive().Buff(), // T6
                elemental.UnlimitedPower.Passive().Buff()
            // vengeance.ChaosBrand.Passive().B
            ).AddAlerts(
                elemental.WaterWalking.Passive().Buff(),
                // todo: any reason not to have Lightning Shield!?
                elemental.LightningShield.Passive().MissingBuff()
            ).Build(wa);
        }
    }

    internal class ShamanRestoration
    {
        public static void Generate(WeakAura wa)
        {
            var elemental = new Elemental();

            var builder = new SpecBuilder(ClassSpec.RestorationShaman);

            builder.AddOverflow(
                elemental.EarthElemental.Buff(),
                elemental.AstralShift.Buff(),
                elemental.Heroism.Buff(),
                elemental.Hex.DeBuff()
            ).AddUtility(
            ).AddCoreRotation(
            ).AddCoreCooldowns(
            ).AddMobility(
                elemental.EarthbindTotem.Buff(),
                elemental.CapacitorTotem.Buff(),
                elemental.HealingStreamTotem.Buff(),
                elemental.TremorTotem.Buff(),
                elemental.WindShear,
                elemental.Purge
            ).AddCombatBuffs(
                elemental.FrostShock.Passive().Buff()
            // vengeance.ChaosBrand.Passive().B
            ).AddAlerts(
                elemental.WaterWalking.Passive().Buff()
            ).Build(wa);
        }
    }

    internal class ShamanEnhancement
    {
        public static void Generate(WeakAura wa)
        {
            var elemental = new Elemental();

            var builder = new SpecBuilder(ClassSpec.Enhancement);

            builder.AddOverflow(
                elemental.EarthElemental.Buff(),
                elemental.AstralShift.Buff(),
                elemental.Heroism.Buff(),
                elemental.Hex.DeBuff()
            ).AddUtility(
            ).AddCoreRotation(
            ).AddCoreCooldowns(
            ).AddMobility(
                elemental.EarthbindTotem.Buff(),
                elemental.CapacitorTotem.Buff(),
                elemental.HealingStreamTotem.Buff(),
                elemental.TremorTotem.Buff(),
                elemental.WindShear,
                elemental.Purge
            ).AddCombatBuffs(
                elemental.FrostShock.Passive().Buff()
            // vengeance.ChaosBrand.Passive().B
            ).AddAlerts(
                elemental.WaterWalking.Passive().Buff()
            ).Build(wa);
        }
    }
}