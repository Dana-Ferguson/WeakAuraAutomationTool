using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using WeakAuraAutomationTool.Warcraft.Parser;

namespace WeakAuraAutomationTool.Warcraft
{
    // Basically SpellData from the Parser

    public class Spell
    {
        public readonly string Name;

        public List<int> SpellIds = new List<int>();
        public List<int> Levels = new List<int>();

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
        [Obsolete] public readonly int Id;
        [Obsolete] public readonly SpellSchool School;
        [Obsolete] public readonly string Rank;
        [Obsolete] public readonly ClassSpec[] ClassSpecs;

        [Obsolete] public double Duration = 0;

        // Sort of building a style sheet type API ~ need to come back later for a second pass
        public SpellType Type = SpellType.Cooldown;
        // Contextual ~ clean these up? --- have a reset() mechanic? --- the classes aren't static?? Prob's fine!
        public bool Invert = false;
        public bool BigStacks = false;
        public bool UseIcon = false;

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

        public Spell(string name, ClassType classType, ClassSpec classSpec,
            int[] spellIds, int[] levels, int talent, int icon,
            double[] cooldowns, double[] durations, bool isPvp, double range,
            string[] categories, SpellEffectData[] data)
        {
            Name = name;
            ClassType = classType;
            ClassSpec = classSpec;
            SpellIds.AddRange(spellIds);
            Levels.AddRange(levels);
            Talent = talent;
            Icon = icon;

            Cooldowns.AddRange(cooldowns);
            Durations.AddRange(durations);

            IsPvp = isPvp;
            Range = range;

            Categories = categories.ToHashSet();
            Effects = data.ToList();

            if (Effects.Any(e => e.AuraType == EffectAuraType.PeriodicDamage))
            {
                Type |= SpellType.DoT;
            }
        }

        // Minimal Variant
        public Spell(string name, ClassType classType, ClassSpec classSpec,
            int spellId, int talent, SpellType spellType = SpellType.Cooldown)
        {
            Name = name;
            ClassType = classType;
            ClassSpec = classSpec;
            SpellIds.Add(spellId);
            Talent = talent;
            Type = spellType;
        }
    }

    public static class SpellExtensions
    {
        public static Spell DoT(this Spell spell)
        {
            spell.Type |= SpellType.DoT;
            return spell;
        }

        public static Spell Buff(this Spell spell)
        {
            spell.Type |= SpellType.BuffOnPlayer;
            return spell;
        }

        public static Spell DeBuff(this Spell spell)
        {
            spell.Type |= SpellType.DebuffOnTarget;
            return spell;
        }

        public static Spell Passive(this Spell spell)
        {
            if (spell.Type.HasFlag(SpellType.Cooldown))
            {
                spell.Type &= ~SpellType.Cooldown;
            }

            return spell;
        }

        public static Spell BigStacks(this Spell spell)
        {
            spell.BigStacks = true;
            return spell;
        }

        public static Spell UseIcon(this Spell spell, Spell icon)
        {
            spell.Icon = icon.Icon;
            spell.UseIcon = true;
            return spell;
        }

        public static Spell AssociateAura(this Spell spell, Spell aura)
        {
            spell.AssociatedAuras.Add(aura);
            return spell;
        }
    }
}