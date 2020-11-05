using System.Collections.Generic;
using System.Linq;

namespace WeakAuraAutomationTool.Warcraft
{
    public class Spell
    {
        public readonly string Name;
        public readonly int Id;
        public int Talent;

        public readonly SpellSchool School;
        public readonly string Rank;
        public readonly int Level;
        public readonly ClassSpec[] ClassSpecs;

        // Sort of building a style sheet type API ~ need to come back later for a second pass
        public SpellType Type = SpellType.Cooldown;
        public double Duration = 0;
        // Contextual ~ clean these up? --- have a reset() mechanic? --- the classes aren't static?? Prob's fine!
        public bool Invert = false;
        public bool BigStacks = false;

        /// <summary>if SpellType is Buff*, this can override the default (which would be to look for itself) </summary>
        public readonly List<Spell> AssociatedAuras = new List<Spell>();

        public Spell(string name, int id, int school, string rank, int level, int[] classSpec, int talent = 0)
        {
            Name = name;
            Id = id;
            Talent = talent;

            School = (SpellSchool)school;
            Rank = rank;
            Level = level;
            ClassSpecs = classSpec.Select(cs => (ClassSpec)cs).ToArray();
        }
    }
}