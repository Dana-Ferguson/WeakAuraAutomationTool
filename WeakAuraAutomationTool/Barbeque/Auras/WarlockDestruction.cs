using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class WarlockDestruction
    {
        public static void Generate(WeakAura wa)
        {
            var destruction = new Destruction();

            var builder = new SpecBuilder(ClassSpec.Destruction);

            builder.AddOverflow(
                destruction.GrimoireSacrifice.Buff(), // T6
                destruction.FelDomination.Buff(),
                destruction.CreateSoulwell,
                destruction.Soulstone,
                destruction.RitualOfDoom
            ).AddRightBar(
                // destruction.Deathbolt,
                destruction.DarkPact.Buff(), // T3
                destruction.MortalCoil.DeBuff(), // T5
                destruction.HowlOfTerror.DeBuff(), // T5
                destruction.Shadowfury.DeBuff()
            ).AddCoreRotation(
                destruction.Immolate.DoT(),
                destruction.Conflagrate.Buff(),
                destruction.Shadowburn.Buff()
                // destruction.Corruption.DoT(),
            ).AddCoreCooldowns(
                destruction.SummonInfernal.Buff(),
                destruction.Havoc.Buff(),
                destruction.Cataclysm.Buff(), // T4
                destruction.ChannelDemonfire, // T7
                destruction.DarkSoulInstability, // T7
                destruction.SoulFire // T1
            ).AddBottomBar(
                destruction.BurningRush.Buff(), // T3
                destruction.DemonicCircleTeleport,
                destruction.CommandDemon
            ).AddTopBar(
                destruction.Eradication.Passive().Buff(), // T1
                destruction.Backdraft.Passive().Buff(),
                destruction.ReverseEntropy.Passive().Buff(), // T2
                destruction.RainOfFire.Passive().DeBuff(),
                destruction.UnendingBreath.Passive().Buff()
            ).AddAlerts(
                destruction.EyeOfKilrogg.Passive().Buff()
            ).Build(wa);
        }
    }
}