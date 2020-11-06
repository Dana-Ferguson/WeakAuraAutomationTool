using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    internal static class Parse
    {
        public static void ProduceCodeFromCsv()
        {
            var files = Directory.GetFiles("data\\");
            var data = files.Select(Csv.Load).ToArray();

            foreach (var csv in data)
            {
                Console.WriteLine($"{csv.Name} :: {string.Join(", ", csv.Headers)}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"public class WowData");
            Console.WriteLine("{");
            foreach (var csv in data)
            {
                var varName = csv.Name;
                Console.WriteLine($"    public readonly List<{csv.Name}> {csv.Name} = Csv.Load<{csv.Name}>(\"data/{csv.Name}.csv\");");
            }
            Console.WriteLine("}");

            foreach (var csv in data)
            {
                Console.WriteLine();
                Console.WriteLine();
                csv.PrintClass();
            }
        }

        /*
        public readonly SpellSchool School;
        public readonly string Rank;
        // public readonly ClassSpec[] ClassSpecs;

        // Sort of building a style sheet type API ~ need to come back later for a second pass
        public SpellType Type = SpellType.Cooldown;

        // Contextual ~ clean these up? --- have a reset() mechanic? --- the classes aren't static?? Prob's fine!
        public bool Invert = false;
        public bool BigStacks = false;

        /// <summary>if SpellType is Buff*, this can override the default (which would be to look for itself) </summary>
        public readonly List<Spell> AssociatedAuras = new List<Spell>();

        */

        // public Spell SolarEclipse = new Spell("Eclipse (Solar)", 48517, 1, "null", 15, new[] { 102 }, 0);
        /*

            todo: determine SpellType; filter out Artifact Traits?
227684 :: -1, Hot Blooded, Monk, 0, 0, 0, 0, False
227685 :: -1, Hot Blooded, Monk, 0, 0, 0, 0, False
227686 :: -1, Hot Blooded, Monk, 0, 0, 0, 0, False
227687 :: -1, Hot Blooded, Monk, 0, 0, 0, 0, False
227688 :: -1, Dark Side of the Moon, Monk, 0, 0, 0, 0, False
227689 :: -1, Dark Side of the Moon, Monk, 0, 0, 0, 0, False
227690 :: -1, Dark Side of the Moon, Monk, 0, 0, 0, 0, False
227691 :: -1, Dark Side of the Moon, Monk, 0, 0, 0, 0, False
227692 :: -1, Dark Side of the Moon, Monk, 0, 0, 0, 0, False
        */

        public static void ProduceSpellDataFromCsv()
        {
            var data = new WowData();
            Console.WriteLine(data.Spells.Count);

            // SpellCastTimes might be usable, SpellMisc.DurationIndex, CastingTimeIndex, RangeIndex
            // SpellActivationOverlay might be pretty fun to lpay with
            // Can I get the Icon Data?

            // SpellActionBarPref
            // SpellActivationOverlay, SpellAuraOptions, SpellAuraRestrictions, SpellAuraVisibility. SpellCastingRequirements
            // SpellCastTimes, SpellCategories, SpellCategory, SpellChainEffects, SpellEquippedItems, SpellLabel, SpellPower
            var spellTalents = data.Talents.ToLookup(s => s.SpellId, t => t);
            var spellNames = data.SpellNames.ToDictionary(s => s.Id, t => t.NameLang);
            var spellMisc = data.SpellMisc.ToLookup(s => s.SpellId, s => s);
            var spellLevels = data.SpellLevels.ToLookup(s => s.SpellId, s => s);
            var spellInterrupts = data.SpellInterrupts.ToLookup(s => s.SpellId, s => s);
            var spellEffects = data.SpellEffects.ToLookup(s => s.SpellId, s => s);
            var spellDurations = data.SpellDurations.ToDictionary(s => s.Id, s => s);
            var spellCooldowns = data.SpellCooldowns.ToLookup(s => s.SpellId, s => s);
            var spellClassOptions = data.SpellClassOptions.ToDictionary(s => s.SpellId, s => s);
            var spells = data.Spells.ToDictionary(s => s.Id, s => s);

            foreach (var spell in data.Spells)
            {
                var id = spell.Id;
                bool isPvP = spell.NameSubtextLang == "PvP Talent";

                var misc = spellMisc[id].FirstOrDefault();
                if (misc == null) continue;

                // https://wowdev.wiki/SpellMisc.db2/Attributes
                var isAbility = (misc.Attributes0 & 0x10) != 0;
                var isTradeSpell = (misc.Attributes0 & 0x20) != 0;
                var isPassive = (misc.Attributes0 & 0x40) != 0;
                var isHidden = (misc.Attributes0 & 0x80) != 0;
                var isHiddenFromCombatLog = (misc.Attributes0 & 0x00000100) != 0;
                var canNotBeShapeShifted = (misc.Attributes0 & 0x00010000) != 0;
                var mustBeStealthed = (misc.Attributes0 & 0x00020000) != 0;
                var impossibleDodgeParryBlock = (misc.Attributes0 & 0x00200000) != 0;
                var isNegative = (misc.Attributes0 & 0x04000000) != 0;
                var canNotCancel = (misc.Attributes0 & 0x80000000) != 0;

                var doNotDisplayInAuraBar = (misc.Attributes1 & 0x10000000) != 0;

                if (id == 227692)
                {
                    int x = 5;
                }

                // todo: EffectAura \ Effect
                var effect = spellEffects[id];

                if (isTradeSpell || isHidden || isHiddenFromCombatLog || doNotDisplayInAuraBar) continue;
                if (isPassive || canNotCancel) continue;

                var spellTalent = spellTalents[id].FirstOrDefault();
                // if (!spellTalents.Contains(id)) continue;

                var talent = spellTalent?.TalentPosition() ?? 0;

                if (!spellClassOptions.TryGetValue(id, out var classOptions)) continue;

                var classType = (ClassType)(spellTalent?.ClassId ?? -1);
                var spec = (ClassSpec)(spellTalent?.SpecId ?? classOptions?.SpellClassSet ?? 0);
                var name = spellNames[id];

                // todo: vet this (durations/time)
                var duration = spellDurations.TryGetValue(misc.DurationIndex, out var spellDuration) ? spellDuration.Duration / 1000.0 : 0.0;

                var level = spellLevels[id].FirstOrDefault()?.LearnLevel ?? 0;
                var cooldown = (spellCooldowns[id].FirstOrDefault()?.CategoryRecoveryTime ?? 0) / 1000.0;

                var sb = new StringBuilder();

                var test = classOptions?.SpellClassMask3 ?? -1;

                sb.Append($"{id} :: {spec}, {classType}, {name}, {talent}, {duration}, {level}, {cooldown}, {isPvP}, {test}");

                Console.WriteLine(sb.ToString());
            }
        }
    }

    internal static class DataExtensions
    {
        public static int TalentPosition(this Talent talent) => talent.TierId * 3 + talent.ColumnIndex;
    }
}