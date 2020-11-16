using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class WarlockAffliction
    {
        public static void Generate(WeakAura wa)
        {
            // todo: Soul shard Tracker (on Resource Hud)
            // todo: Seed of Corruption Tracker?
            // todo: Curse Tracker
            // todo: Fear Tracker
            // todo: Casting Ritual of Doom Alert
            var affliction = new Affliction();

            var builder = new SpecBuilder(ClassSpec.Affliction);

            builder.AddOverflow(
                affliction.GrimoireSacrifice.Buff(), // T6
                affliction.FelDomination.Buff(),
                affliction.CreateSoulwell,
                affliction.Soulstone,
                affliction.RitualOfDoom
            ).AddRightBar(
                affliction.Deathbolt,
                affliction.DarkPact.Buff(), // T3
                affliction.MortalCoil.DeBuff(), // T5
                affliction.HowlOfTerror.DeBuff(), // T5
                affliction.Shadowfury.DeBuff()
            ).AddCoreRotation(
                affliction.Agony.DoT(),
                affliction.UnstableAffliction.DoT(),
                affliction.Corruption.DoT(),
                affliction.SiphonLife.DoT(), // T2
                affliction.Haunt.DoT() //T6
            ).AddCoreCooldowns(
                affliction.SummonDarkglare.Buff(),
                affliction.DarkSoulMisery.Buff(), // T7
                affliction.PhantomSingularity.Buff(), // T4
                affliction.VileTaint.DeBuff() // T4
            ).AddBottomBar(
                affliction.BurningRush.Buff(), // T3
                affliction.DemonicCircleTeleport,
                affliction.CommandDemon
            ).AddTopBar(
                affliction.SeedOfCorruption.Passive().DeBuff(),
                affliction.Nightfall.Passive().Buff(), // T1
                affliction.UnendingBreath.Passive().Buff()
            ).AddAlerts(
                affliction.EyeOfKilrogg.Passive().Buff()
            ).Build(wa);
        }
    }
}