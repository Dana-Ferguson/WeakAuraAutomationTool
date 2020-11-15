using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class RogueSubtlety
    {
        public static void Generate(WeakAura wa)
        {
            // todo: add a check for missing poisons (lethal + non-lethal)
            // todo: add alert for Cheat Death (only while you're taking the reduced damage)
            // todo: some of these poisons on the enemies should pro'lly be DoT's, not just DeBuff's
            var subtlety = new Subtlety();

            var builder = new SpecBuilder(ClassSpec.Subtlety);

            builder.AddOverflow(
                subtlety.Blind.DeBuff(),
                subtlety.CheapShot.RequiresStealth(),
                subtlety.Feint.Buff(),
                subtlety.Distract.DeBuff(),
                subtlety.Evasion.Buff(),
                subtlety.ShroudOfConcealment.Buff().RequiresStealth(),
                // look for buff on friendly target?
                subtlety.TricksOfTheTrade.Buff()
            ).AddRightBar(
                subtlety.MarkedForDeath.DeBuff(), // T3
                subtlety.SecretTechnique.Buff(), // T7
                subtlety.ShurikenTornado.Buff() // T7
            ).AddCoreRotation(
                subtlety.Shiv,
                subtlety.SliceAndDice.Buff(),
                subtlety.Rupture.DeBuff()
            ).AddCoreCooldowns(
                subtlety.ShadowBlades.Buff(),
                subtlety.SymbolsOfDeath.Buff(),
                subtlety.ShadowDance.Buff()
            ).AddBottomBar(
                subtlety.Shadowstep.Buff(),
                subtlety.Sprint.Buff(),
                subtlety.CloakOfShadows.Buff(),
                subtlety.Kick.DeBuff(),
                subtlety.CrimsonVial.Buff(),
                subtlety.Vanish.Buff()
            ).AddTopBar(
                subtlety.FindWeakness.Passive().DeBuff(),
                subtlety.ShotInTheDark.Passive().Buff(), // T5
                subtlety.NightTerrors.Passive().DeBuff(), // T5
                subtlety.PreyOnTheWeak.Passive().DeBuff(), // T5
                subtlety.Alacrity.Passive().Buff(), // T6
                subtlety.MasterOfShadows.Passive().Buff() // T7
            ).AddAlerts(
                subtlety.Stealth.Passive().Buff(),
                subtlety.Subterfuge.Buff(), // T2
                subtlety.ShroudOfConcealment.Passive().Buff()
            ).Build(wa);
        }
    }
}