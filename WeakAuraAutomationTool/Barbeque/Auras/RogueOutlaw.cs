using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class RogueOutlaw
    {
        public static void Generate(WeakAura wa)
        {
            // todo: add a check for missing poisons
            var outlaw = new Outlaw();

            var builder = new SpecBuilder(ClassSpec.Outlaw);

            builder.AddOverflow(
                outlaw.Gouge.DeBuff(),
                outlaw.Blind.DeBuff(),
                outlaw.CheapShot.RequiresStealth(),
                outlaw.Feint.Buff(),
                outlaw.Distract.DeBuff(),
                outlaw.Evasion.Buff(),
                outlaw.ShroudOfConcealment.Buff().RequiresStealth(),
                // look for buff on friendly target?
                outlaw.TricksOfTheTrade.Buff()
            ).AddRightBar(
                outlaw.AdrenalineRush.Buff(),
                outlaw.BetweenTheEyes.DeBuff(),
                // todo: we need the Bones Buffs
                outlaw.RollTheBones.Buff(),
                outlaw.BladeFlurry.Buff()
            ).AddCoreRotation(
                outlaw.Shiv,
                outlaw.SliceAndDice.Buff(),
                outlaw.GhostlyStrike.DeBuff(), // T1
                outlaw.MarkedForDeath.DeBuff(), // T3
                outlaw.Dreadblades.Buff(), // T6
                outlaw.BladeRush, // T7
                outlaw.KillingSpree // T7
            ).AddCoreCooldowns(
            ).AddBottomBar(
                outlaw.GrapplingHook,
                outlaw.Sprint.Buff(),
                outlaw.CloakOfShadows.Buff(),
                outlaw.Kick.DeBuff(),
                outlaw.CrimsonVial.Buff(),
                outlaw.Vanish.Buff()
            ).AddTopBar(
                outlaw.PistolShot.DeBuff().Passive(),
                outlaw.PreyOnTheWeak.DeBuff().Passive(), // T5
                outlaw.LoadedDice.Buff().Passive(), // T6
                outlaw.Alacrity.Passive().Buff() // T6
            ).AddAlerts(
                outlaw.Stealth.Passive().Buff(),
                outlaw.ShroudOfConcealment.Passive().Buff()
            ).Build(wa);
        }
    }
}