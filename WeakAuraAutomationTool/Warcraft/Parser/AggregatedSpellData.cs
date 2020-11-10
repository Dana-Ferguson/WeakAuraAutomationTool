using System.Collections.Generic;

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    /// <summary>
    /// Spell Data for several Spell Ids'
    /// </summary>
    internal class AggregatedSpellData
    {
        public ClassType ClassType;
        public ClassSpec ClassSpec;
        public string SpellName;

        public List<int> SpellIds;
        public List<int> Levels;
        public int Talent;
        public int Icon;

        public List<double> Cooldowns = new List<double>();
        public List<double> Durations = new List<double>();

        public bool IsPvp;
        public double Range;

        public HashSet<string> Categories = new HashSet<string>();
        public List<SpellEffectData> Effects = new List<SpellEffectData>();
    }
}