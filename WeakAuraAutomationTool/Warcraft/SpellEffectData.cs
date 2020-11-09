using System;
using WeakAuraAutomationTool.Warcraft.Parser.Enumerations;

namespace WeakAuraAutomationTool.Warcraft
{
    public class SpellEffectData
    {
        public readonly SpellEffectName Name;
        public readonly EffectAuraType AuraType;

        public SpellEffectData(SpellEffectName name, EffectAuraType auraType)
        {
            Name = name;
            AuraType = auraType;
        }

        public override int GetHashCode() => HashCode.Combine(Name, AuraType);

        public override bool Equals(object? obj) => obj is SpellEffectData data && data.Name == Name && data.AuraType == AuraType;

        public override string ToString() => $"{Name}:{AuraType}";
    }
}