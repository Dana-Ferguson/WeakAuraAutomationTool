using System.Collections.Generic;

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    /// <summary>
    /// Data for a specific SpellID
    /// </summary>
    internal class SpellData
    {
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
    }
}