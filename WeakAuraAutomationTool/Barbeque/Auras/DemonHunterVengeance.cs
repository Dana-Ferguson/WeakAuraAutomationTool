using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class DemonHunterVengeance
    {
        public static void Generate(WeakAura wa)
        {
            var vengeance = new Vengeance();

            var builder = new SpecBuilder(ClassSpec.Vengeance);

            // todo: souls tracker (to the resource HUD?)
            builder.AddOverflow(
                vengeance.Imprison.DeBuff(),
                vengeance.SpectralSight.Buff(),
                // todo: not_on_CD --> back to combat buffs?
                vengeance.ThrowGlaive,
                vengeance.Torment,
                vengeance.LastResort.Passive().Buff()
            ).AddUtility(
                // Cooldowns
                vengeance.SigilOfFlame,
                vengeance.SigilOfChains,
                vengeance.SigilOfSilence,
                vengeance.SigilOfMisery
            ).AddCoreRotation(
                vengeance.ImmolationAura.Buff(),
                vengeance.FelDevastation.Buff(),
                vengeance.Fracture,
                vengeance.DemonSpikes.Buff()
            ).AddCoreCooldowns(
                vengeance.Metamorphosis.Buff(),
                vengeance.FieryBrand.DeBuff().AssociateAura(vengeance.RevelInPain),
                vengeance.BulkExtraction,
                vengeance.SoulBarrier.Buff()
            ).AddMobility(
                vengeance.InfernalStrike,
                vengeance.Felblade,
                vengeance.Disrupt,
                // todo: check target for magic
                vengeance.ConsumeMagic
            ).AddCombatBuffs(
                vengeance.SoulFragments.Passive().Buff()
            // vengeance.ChaosBrand.Passive().B
            ).AddAlerts(
                vengeance.Glide.Passive().Buff(),
                // todo: Only When Missing
                vengeance.Frailty.Passive().DeBuff()
            ).Build(wa);
        }
    }
}