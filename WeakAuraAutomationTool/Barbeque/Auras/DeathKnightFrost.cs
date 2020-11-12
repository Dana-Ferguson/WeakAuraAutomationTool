using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class DeathKnightFrost
    {
        public static void Generate(WeakAura wa)
        {
            var frost = new Frost();

            var builder = new SpecBuilder(ClassSpec.Frost);

            wa.AddSpell(frost.BreathOfSindragosa, ClassSpec.Frost, -25, 300);

            builder.AddOverflow(
                // todo: move to core when replaced with Night Fae covenant?
                frost.DeathAndDecay.Buff(),
                frost.DarkCommand,
                frost.RaiseAlly,
                frost.RaiseDead,
                frost.SacrificialPact,
                frost.HornOfWinter,
                frost.BlindingSleet.DeBuff(),
                frost.DeathPact.Buff(),
                frost.Permafrost.Passive().Buff()
            // havoc.Torment,
            ).AddUtility(
                frost.Anti_MagicShell.Buff(),
                frost.Anti_MagicZone.Buff(),
                frost.IceboundFortitude.Buff(),
                frost.Lichborne
            ).AddCoreRotation(
                frost.Rime.Passive().Buff().UseIcon(frost.HowlingBlast),
                frost.KillingMachine.Passive().Buff().UseIcon(frost.Obliterate),
                frost.HypothermicPresence.Buff(),
                frost.GlacialAdvance
            // todo: frost.Frostscythe.
            ).AddCoreCooldowns(
                frost.PillarOfFrost.Buff(),
                frost.EmpowerRuneWeapon.Buff(),
                frost.FrostwyrmsFury.DeBuff(),
                frost.RemorselessWinter.Buff()
            ).AddMobility(
                frost.DeathGrip,
                frost.DeathsAdvance.Buff(),
                frost.WraithWalk.Buff(),
                frost.MindFreeze.DeBuff(),
                frost.Asphyxiate.DeBuff()
            ).AddCombatBuffs(
                // todo: add FrostFever?
                frost.ControlUndead.Passive().Buff(),
                frost.DarkSuccor.Buff().Passive().UseIcon(frost.DeathStrike),
                frost.ColdHeart.Buff().Passive().Stacks(20).UseIcon(frost.ChainsOfIce),
                frost.IcyTalons.Buff().Passive().BigStacks(),
                frost.InexorableAssault.Buff().Passive().BigStacks().UseIcon(frost.Obliterate),
                frost.FrozenPulse.Buff().Passive(),
                frost.GatheringStorm.Buff().Passive()
            ).AddAlerts(
                frost.PillarOfFrost.Passive().Buff(),
                frost.PathOfFrost.Passive().Buff()
            ).Build(wa);
        }
    }
}