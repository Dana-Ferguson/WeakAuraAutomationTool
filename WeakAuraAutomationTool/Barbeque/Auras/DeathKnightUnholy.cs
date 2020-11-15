using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class DeathKnightUnholy
    {
        public static void Generate(WeakAura wa)
        {
            var unholy = new Unholy();

            var builder = new SpecBuilder(ClassSpec.Unholy);

            // todo: Army of the Dead tracker?

            builder.AddOverflow(
                unholy.DarkCommand,
                unholy.RaiseAlly,
                unholy.RaiseDead,
                unholy.SacrificialPact,
                unholy.UnholyBlight.Buff(),
                unholy.DeathPact.Buff()
            // havoc.Torment,
            ).AddRightBar(
                // Cooldowns
                unholy.Anti_MagicShell.Buff(),
                unholy.Anti_MagicZone.Buff(),
                unholy.IceboundFortitude.Buff(),
                unholy.Lichborne
            ).AddCoreRotation(
                unholy.Epidemic,
                // note: ScourgeStrike could be replaced with ClawingShadows
                unholy.FesteringWound.Passive().DeBuff().UseIcon(unholy.ScourgeStrike),
                unholy.VirulentPlague.Passive().DeBuff().UseIcon(unholy.Outbreak),
                unholy.DeathAndDecay.Buff()
            ).AddCoreCooldowns(
                unholy.Apocalypse,
                unholy.ArmyOfTheDead,
                // todo: track buff on pet
                unholy.DarkTransformation,
                // todo: It says, 'Unholy Frenzy'? is this a separate buff?
                unholy.UnholyAssault.Buff(),
                // todo: likely not a buff, but we should be able to track this pet
                unholy.SummonGargoyle.Buff()
            ).AddBottomBar(
                unholy.DeathGrip,
                unholy.DeathsAdvance.Buff(),
                unholy.WraithWalk.Buff(),
                unholy.MindFreeze.DeBuff(),
                unholy.Asphyxiate.DeBuff()
            ).AddTopBar(
                unholy.ControlUndead.Passive().Buff(),
                unholy.DarkSuccor.Buff().Passive().UseIcon(unholy.DeathStrike),
                unholy.RunicCorruption.Buff().Passive(),
                unholy.UnholyPact.Buff().Passive()
            ).AddAlerts(
                // todo: missing Ghoul pet
                unholy.SuddenDoom.Passive().Buff(),
                unholy.PathOfFrost.Passive().Buff()
            ).Build(wa);
        }
    }
}