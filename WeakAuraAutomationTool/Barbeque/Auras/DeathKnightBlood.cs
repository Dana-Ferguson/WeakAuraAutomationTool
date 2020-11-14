using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal class DeathKnightBlood
    {
        public static void Generate(WeakAura wa)
        {
            var blood = new Blood();

            var builder = new SpecBuilder(ClassSpec.Blood);

            // todo: Death Strike heal tracker?

            builder.AddOverflow(
                blood.DarkCommand,
                blood.RaiseAlly,
                blood.RaiseDead,
                blood.SacrificialPact,
                blood.Consumption,
                blood.BloodTap,
                // todo: does this change Core Rotation?
                blood.MarkOfBlood.DeBuff(),
                // todo: will this detect a debuff on player?
                blood.DeathPact.Buff()
            // havoc.Torment,
            ).AddUtility(
                // Cooldowns
                blood.Anti_MagicShell.Buff(),
                blood.Anti_MagicZone.Buff(),
                blood.IceboundFortitude.Buff(),
                blood.Lichborne
            ).AddCoreRotation(
                // todo: probably needs a _missing_ warning \ a _low_ warning
                // todo: associate with Ossuary Buff
                blood.BoneShield.Passive().Buff().BigStacks(),
                blood.RuneTap.Buff(),
                blood.DeathAndDecay.Buff().AssociateAura(blood.CrimsonScourge),
                blood.BloodBoil
            ).AddCoreCooldowns(
                blood.DancingRuneWeapon.Buff(),
                blood.VampiricBlood.Buff(),
                blood.Blooddrinker.Buff(),
                blood.Tombstone.Buff(),
                blood.Bonestorm.Buff()
            ).AddMobility(
                blood.DeathGrip,
                blood.GorefiendsGrasp,
                blood.DeathsAdvance.Buff(),
                blood.WraithWalk.Buff(),
                blood.MindFreeze.DeBuff(),
                blood.Asphyxiate.DeBuff()
            ).AddCombatBuffs(
                blood.ControlUndead.Passive().Buff(),
                blood.BloodPlague.Passive().DeBuff(),
                blood.Bloodworms.Passive().Buff().BigStacks()
            ).AddAlerts(
                blood.PathOfFrost.Passive().Buff(),
                blood.Purgatory.Passive().Buff()
            ).Build(wa);
        }
    }
}