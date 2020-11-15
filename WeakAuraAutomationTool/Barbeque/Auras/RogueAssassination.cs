using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class RogueAssassination
    {
        public static void Generate(WeakAura wa)
        {
            // todo: add a check for missing poisons
            var assassination = new Assassination();

            var builder = new SpecBuilder(ClassSpec.Assassination);

            builder.AddOverflow(
                assassination.Blind.DeBuff(),
                assassination.CheapShot.RequiresStealth(),
                assassination.Feint.Buff(),
                assassination.Distract.DeBuff(),
                assassination.Evasion.Buff(),
                assassination.ShroudOfConcealment.Buff().RequiresStealth(),
                // look for buff on friendly target?
                assassination.TricksOfTheTrade.Buff()
            ).AddRightBar(
                assassination.Vendetta.Buff(),
                assassination.MarkedForDeath.DeBuff(), // T3
                assassination.Exsanguinate, // T6
                assassination.HiddenBlades.Passive().BigStacks() // T7
            ).AddCoreRotation(
                assassination.Shiv,
                assassination.SliceAndDice.Buff(),
                assassination.Envenom.DeBuff(),
                assassination.Garrote.DeBuff(),
                assassination.Rupture.DeBuff(),
                assassination.CrimsonTempest.DeBuff() // T7
            ).AddCoreCooldowns(
            ).AddBottomBar(
                assassination.Shadowstep.Buff(),
                assassination.Sprint.Buff(),
                assassination.CloakOfShadows.Buff(),
                assassination.Kick.DeBuff(),
                assassination.CrimsonVial.Buff(),
                assassination.Vanish.Buff()
            ).AddTopBar(
                assassination.ElaboratePlanning.Passive().Buff(), // T1
                assassination.Blindside.Passive().Buff(), // T1
                assassination.InternalBleeding.Passive().DeBuff(), // T5
                assassination.IronWire.Passive().DeBuff(), // T5
                assassination.PreyOnTheWeak.Passive().DeBuff(), // T5
                assassination.Alacrity.Passive().Buff() // T6
            ).AddAlerts(
                assassination.Stealth.Passive().Buff(),
                assassination.Subterfuge.Buff(), // T2
                assassination.ShroudOfConcealment.Passive().Buff()
            ).Build(wa);
        }
    }
}