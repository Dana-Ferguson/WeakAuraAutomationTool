using System.Collections.Generic;
using System.Linq;
using WeakAuraAutomationTool.Warcraft.Parser;

namespace WeakAuraAutomationTool.Warcraft
{
    // Basically SpellData from the Parser

    public class Spell
    {
        public readonly string Name;
        public int SpellId;

        public ClassType ClassType;
        public ClassSpec ClassSpec;
        public string SpellName;

        public int Level;
        public int Talent;
        public int Icon;

        public List<double> Cooldowns = new List<double>();
        public List<double> Durations = new List<double>();

        public bool IsPvp;
        public double Range;

        public HashSet<string> Categories = new HashSet<string>();
        public List<SpellEffectData> Effects = new List<SpellEffectData>();

        // OLD STUFF
        public readonly int Id;
        public readonly SpellSchool School;
        public readonly string Rank;
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

        public Spell(string name, ClassType type, ClassSpec spec,
            int[] spellIds, int[] levels, int talent, int icon,
            double[] cooldowns, double[] durations, bool isPvp, double range,
            string[] categories, SpellEffectData[] data)
        {
        }
    }
}