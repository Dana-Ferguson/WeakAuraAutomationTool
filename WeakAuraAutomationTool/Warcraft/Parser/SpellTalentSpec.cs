using System;

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    internal class SpellTalentSpec
    {
        public readonly int Talent;
        public readonly ClassSpec Spec;

        public SpellTalentSpec(int talent)
        {
            Talent = talent;
        }

        public SpellTalentSpec(Talent talent)
        {
            Talent = talent.TalentPosition();
            Spec = (ClassSpec)talent.SpecId;
        }

        public override int GetHashCode() => HashCode.Combine(Talent, Spec);

        public override bool Equals(object? obj) => obj is SpellTalentSpec data && data.Talent == Talent && data.Spec == Spec;

        public override string ToString() => $"{Spec}:{Talent}";
    }
}