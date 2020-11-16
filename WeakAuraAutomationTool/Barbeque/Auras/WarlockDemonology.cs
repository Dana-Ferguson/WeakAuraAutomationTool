using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class WarlockDemonology
    {
        public static void Generate(WeakAura wa)
        {
            // todo: Doom Tracker ?? Associated Buff?
            var demonology = new Demonology();

            var builder = new SpecBuilder(ClassSpec.Demonology);

            builder.AddOverflow(
                demonology.FelDomination.Buff(),
                demonology.CreateSoulwell,
                demonology.Soulstone,
                demonology.RitualOfDoom
            ).AddRightBar(
                // demonology.Deathbolt,
                demonology.NetherPortal.Buff(), // T7
                demonology.DarkPact.Buff(), // T3
                demonology.MortalCoil.DeBuff(), // T5
                demonology.HowlOfTerror.DeBuff(), // T5
                demonology.Shadowfury.DeBuff()
            ).AddCoreRotation(
                demonology.CallDreadstalkers.Buff(),
                demonology.UnstableAffliction.DoT(),
                // demonology.Corruption.DoT(),
                demonology.DemonicCore.Passive().Buff().BigStacks(),
                demonology.SoulStrike // T4
            ).AddCoreCooldowns(
                demonology.SummonDemonicTyrant.Buff(),
                demonology.GrimoireFelguard.Buff(), // T
                demonology.SummonVilefiend.Buff(), // T4
                demonology.DemonicStrength.Buff(), // T1
                demonology.BilescourgeBombers.Buff(), // T1
                demonology.PowerSiphon.DeBuff() // T2
            ).AddBottomBar(
                demonology.BurningRush.Buff(), // T3
                demonology.DarkPact.Buff(), // T3
                demonology.DemonicCircleTeleport,
                demonology.CommandDemon
            ).AddTopBar(
                demonology.DemonicCalling.Passive().Buff().UseIcon(demonology.CallDreadstalkers), // T2
                demonology.UnendingBreath.Passive().Buff()
            ).AddAlerts(
                demonology.EyeOfKilrogg.Passive().Buff()
            ).Build(wa);
        }
    }
}