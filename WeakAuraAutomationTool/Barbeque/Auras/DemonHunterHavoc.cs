using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class DemonHunterHavoc
    {
        public static void Generate(WeakAura wa)
        {
            var havoc = new Havoc();

            var builder = new SpecBuilder(ClassSpec.Havoc);

            // todo: souls tracker (to the resource HUD?)
            builder.AddOverflow(
                havoc.Imprison.DeBuff(),
                havoc.SpectralSight.Buff(),
                // todo: not_on_CD --> back to combat buffs?
                havoc.ThrowGlaive
            // havoc.Torment,
            ).AddRightBar(
                // Cooldowns
                havoc.ChaosNova.DeBuff(),
                havoc.Darkness.Buff(),
                havoc.Blur.Buff(),
                havoc.SigilOfMisery
            ).AddCoreRotation(
                havoc.ImmolationAura.Buff(),
                // todo: glow when castable
                havoc.EyeBeam.Buff().AssociateAura(havoc.FuriousGaze),
                havoc.BladeDance,
                havoc.GlaiveTempest
            ).AddCoreCooldowns(
                havoc.Metamorphosis.Buff(),
                havoc.EssenceBreak.DeBuff(),
                havoc.FelEruption.DeBuff(),
                havoc.FelBarrage.Buff()
            ).AddBottomBar(
                havoc.FelRush,
                havoc.VengefulRetreat,
                havoc.Felblade,
                havoc.Netherwalk,
                havoc.Disrupt,
                // todo: check target for magic
                havoc.ConsumeMagic
            ).AddTopBar(
                havoc.SoulFragments.Passive().Buff()
            // vengeance.ChaosBrand.Passive().B
            ).AddAlerts(
                havoc.Glide.Passive().Buff()
            ).Build(wa);
        }
    }
}