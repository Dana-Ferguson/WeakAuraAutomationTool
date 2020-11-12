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

        public static void ProduceSpellDataFromCsv()
        {
            var data = new WowData();
            Console.WriteLine(data.Spells.Count);

            // SpellCastTimes might be usable, SpellMisc.DurationIndex, CastingTimeIndex, RangeIndex
            // SpellActivationOverlay might be pretty fun to play with
            // Can I get the Icon Data?

            // SpellActionBarPref
            // SpellActivationOverlay, SpellAuraOptions, SpellAuraRestrictions, SpellAuraVisibility.
            // SpellCastTimes, SpellChainEffects, SpellEquippedItems, SpellLabel, SpellPower
            var spellTalents = data.Talents.ToLookup(s => s.SpellId, t => t);
            var spellNames = data.SpellNames.ToDictionary(s => s.Id, t => t.NameLang);
            var spellMisc = data.SpellMisc.ToLookup(s => s.SpellId, s => s);
            var spellLevels = data.SpellLevels.ToLookup(s => s.SpellId, s => s);
            // var spellInterrupts = data.SpellInterrupts.ToLookup(s => s.SpellId, s => s);
            var spellEffects = data.SpellEffects.ToLookup(s => s.SpellId, s => s);
            var spellDurations = data.SpellDurations.ToDictionary(s => s.Id, s => s);
            var spellCooldowns = data.SpellCooldowns.ToLookup(s => s.SpellId, s => s);
            var spellClassOptions = data.SpellClassOptions.ToDictionary(s => s.SpellId, s => s);
            // var spellCastingRequirements = data.SpellCastingRequirements.ToDictionary(s => s.SpellId, s => s);
            var spellSpecialization = data.SpecializationSpells.ToLookup(s => s.SpellId, s => s);
            var spellRange = data.SpellRanges.ToDictionary(s => s.Id, s => s);
            // var spells = data.Spells.ToDictionary(s => s.Id, s => s);

            var spellCategory = data.SpellCategory.ToDictionary(s => s.Id);
            var spellCategories = data.SpellCategories.ToLookup(s => s.SpellId, s => s);

            var effectTypes = new HashSet<EffectAuraType>();
            var count = 0;
            var skipped = 0;

            var output = new Dictionary<string, string>();
            var spellData = new List<SpellData>();

            Directory.CreateDirectory("output");
            const string filepath = "output/spells.txt";
            using var file = new StreamWriter(filepath);

            foreach (var spell in data.Spells)
            {
                var id = spell.Id;
                var spellName = spellNames[id];

                // todo: are we dropping valid spells?
                var isPvP = spell.NameSubtextLang == "PvP Talent";
                var isPlaceHolder = spellName.StartsWith("PH");
                var isFx = spellName.StartsWith("FX");
                var isPortal = spellName.Contains("Portal");
                var isDnd = spellName.Contains("DND");
                var isTest = spellName.ToLowerInvariant().Contains("test");
                var isNyi = spellName.ToLowerInvariant().Contains("nyi");
                var isTbd = spellName.ToLowerInvariant().Contains("tbd");
                if (isPlaceHolder || isTest || isPortal || isFx || isTbd || isNyi || isDnd)
                {
                    skipped++;
                    continue;
                }

                if (!spellMisc[id].Any()) continue;

                // todo: remove when done with testing
                if (id == 202345)
                {
                    int x = 5;
                }

                if (spellName == "Paralysis")
                {
                    int x = 6;
                }

                var effects = spellEffects[id]
                    .Select(e => new SpellEffectData((SpellEffectName)e.Effect, (EffectAuraType)e.EffectAura))
                    .ToList();

                // if (isTradeSpell || isHidden || isHiddenFromCombatLog) continue; // || doNotDisplayInAuraBar) continue;
                // if (isPassive || canNotCancel) continue;

                if (!spellClassOptions.TryGetValue(id, out var classOptions))
                {
                    skipped++;
                    continue;
                }

                // var spellTalent = spellTalents[id].ToList();
                var classSpecs = new List<ClassSpec>();
                var talents = new List<SpellTalentSpec>();
                var classTypes = new HashSet<string>();
                // var talent = spellTalent?.TalentPosition() ?? 0;

                foreach (var spellTalent in spellTalents[id])
                {
                    talents.Add(new SpellTalentSpec(spellTalent));
                    classSpecs.Add((ClassSpec)spellTalent.SpecId);
                    classTypes.Add(((ClassType)spellTalent.ClassId).ToString());
                }

                classTypes.Add(((ClassSpec)classOptions.SpellClassSet).ToString());

                foreach (var specialization in spellSpecialization[id])
                {
                    classSpecs.Add((ClassSpec)specialization.SpecId);
                }

                var categories = new List<string>();
                foreach (var categoryInfo in spellCategories[id])
                {
                    if (categoryInfo.Category == 0)
                    {
                        categories.Add("uncategorized");
                    }
                    else
                    {
                        var category = spellCategory[categoryInfo.Category];
                        categories.Add(category.NameLang);
                    }
                }

                // It seems the level learned can be in either of the two fields, so we need to look at both -- Field_9_0_1_33978_004 ?? the new squished levels?
                var levelLearned = spellLevels[id].Select(s => Math.Max(s.LearnLevel, s.Field_9_0_1_33978_004)).ToHashSet().OrderBy(i => i).ToList();

                var durations = spellMisc[id]
                    .Where(misc => spellDurations.ContainsKey(misc.DurationIndex))
                    .Select(misc => spellDurations[misc.DurationIndex].Duration / 1000.0)
                    .ToHashSet().OrderBy(i => i).ToList();

                var icons = spellMisc[id]
                    .Select(misc => misc.SpellIconFileDataId)
                    .ToHashSet().OrderBy(i => i).ToList();

                // var cooldown = (spellCooldowns[id].FirstOrDefault()?.CategoryRecoveryTime ?? 0) / 1000.0;
                var cooldown = spellCooldowns[id].Select(s => s.CategoryRecoveryTime / 1000.0).ToHashSet().OrderBy(i => i).ToList();

                var attributes = spellMisc[id].GetAttributes().ToHashSet();
                // var icon = icon

                // var test = classOptions?.SpellClassMask3 ?? -1;
                var test = talents.Count != 0 && talents.All(t => t.Talent != 0)
                           || levelLearned.Count != 0 && levelLearned.All(l => l != 0);
                if (!test)
                {
                    skipped++;
                    continue;
                }

                if (classSpecs.Count == 0)
                {
                    // Console.WriteLine($"{id}:{spellName}: No spec info");
                }

                if (spellMisc[id].Count() > 1)
                {
                    Console.WriteLine($"{id}:{spellName}: SpellMisc.Count = {spellMisc[id].Count()}");
                }

                // NPC\MOB abilities tend to be much longer than player ranges
                var range = spellRange.TryGetValue(spellMisc[id].First().RangeIndex, out var _range) ? _range.RangeMax0 : 0;
                if (range > 60) continue;

                if (classSpecs.Contains(ClassSpec.WarlockDemon)) continue;
                if (effects.Any(e => e.Name == SpellEffectName.QuestComplete)) continue;

                if (/*attributes.Contains("HiddenClientSide") ||*/ attributes.Contains("IsGarrisonBuff"))
                {
                    Console.WriteLine($"SKIPPED:::::: {id}:{spellName}: SpellMisc.Count = {spellMisc[id].Count()}: {attributes.Stringify()}");
                    skipped++;
                    continue;
                }

                var sb = new StringBuilder();

                count++;
                sb.Append($"{id} :: {classTypes.Stringify()}, {classSpecs.Stringify()}, {spellName}, levels:{levelLearned.Stringify()}, talents:{talents.Stringify()}");
                sb.Append($", cooldowns:{cooldown.Stringify()}, duration:{durations.Stringify()}, pvp:{isPvP}, icons:{icons.Stringify()}, {test}, " +
                          $"{range}, {categories.Stringify()}");

                sb.Append($", {effects.Stringify()}");
                sb.Append($", {attributes.Stringify()}");
                output[$"{classTypes.FirstOrDefault()}, {classSpecs.FirstOrDefault()}, {spellName}, {test}, {id}"] = sb.ToString();

                // Console.WriteLine(sb.ToString());
                // file.WriteLine(sb.ToString());

                if (classTypes.Count > 1 /*|| classSpecs.Count > 1*/ || levelLearned.Count > 1 || talents.Count > 1 || icons.Count > 1)
                {
                    if (talents.Count(t => t.Talent != 0) == 1)
                    {
                        talents.RemoveAll(t => t.Talent == 0);
                    }
                    else if (talents.Select(t => t.Spec).ToHashSet().Count == talents.Count)
                    {
                        // we're fine, all talent positions are for different specs
                    }
                    else
                    {
                        Console.WriteLine($"WARN: too much info, {id}, {spellName}, classes:{classTypes.Stringify()}, specs:{classSpecs.Stringify()}, levels:{levelLearned.Stringify()}, talents:{talents.Stringify()}, icons:{icons.Stringify()}");
                    }
                }

                // We're using ClassSpec.Spell to count as the base class
                if (classSpecs.Count == 0) classSpecs.Add(ClassSpec.Base);
                foreach (var classSpec in classSpecs)
                {
                    if (!Enum.IsDefined(typeof(ClassSpec), classSpec)) continue;
                    if (Enum.TryParse<ClassType>(classTypes.First(), out var classType))
                    {
                        // We want a copy for each spec to fit our wow class as poco class structure
                        spellData.Add(new SpellData
                        {
                            SpellId = id,
                            SpellName = spellName,
                            ClassType = classType,
                            ClassSpec = classSpec, // classSpecs.FirstOrDefault(),
                            Level = levelLearned.FirstOrDefault(),
                            Talent = talents.FirstOrDefault(t => t.Spec == classSpec)?.Talent ?? 0,
                            Icon = icons.First(),
                            Cooldowns = cooldown,
                            Durations = durations,
                            IsPvp = isPvP,
                            Range = range,
                            Categories = categories.ToHashSet(),
                            Effects = effects
                        });
                    }
                }
            }

            foreach (var line in output.OrderBy(kvp => kvp.Key).Select(kvp => kvp.Value))
            {
                file.WriteLine(line);
            }

            Console.WriteLine($"Total effect types: {effectTypes.Stringify()}");
            Console.WriteLine($"Total spells:  {count}");
            Console.WriteLine($"Total skipped: {skipped}");

            var aggregatedSpellData = new List<AggregatedSpellData>();

            // Parse spellData
            // Merge all SpellData by Name\Class
            var spellLookup = spellData.ToLookup(s => $"{s.SpellName} {s.ClassType} {s.ClassSpec}", s => s);
            foreach (var spellDataGroup in spellLookup.OrderBy(s => s.Key))
            {
                var name = spellDataGroup.First().SpellName;
                var classType = spellDataGroup.First().ClassType;
                var classSpec = spellDataGroup.First().ClassSpec;

                var talents = spellDataGroup.Select(s => s.Talent).ToHashSet().ToList();
                var icons = spellDataGroup.Select(s => s.Icon).ToHashSet().ToList();
                if (icons.Count != 1) Console.WriteLine($"Warning: Too many icons: {spellDataGroup.Key} >> {icons.Stringify()}");
                if (talents.Count != 1 && talents.Count(t => t != 0) != 1)
                {
                    Console.WriteLine($"Warning: Too many talents: {spellDataGroup.Key} >> {talents.Stringify()}");
                }

                var agd = new AggregatedSpellData
                {
                    SpellName = name,
                    ClassType = classType,
                    ClassSpec = classSpec,
                    SpellIds = spellDataGroup.Select(s => s.SpellId).ToList(),
                    Levels = spellDataGroup.Select(s => s.Level).ToList(),
                    Talent = talents.Max(),
                    Icon = icons.First(),
                    Cooldowns = spellDataGroup.SelectMany(s => s.Cooldowns).ToHashSet().ToList(),
                    Durations = spellDataGroup.SelectMany(s => s.Durations).ToHashSet().ToList(),
                    IsPvp = spellDataGroup.Any(s => s.IsPvp),
                    Range = spellDataGroup.Max(s => s.Range),
                    Categories = spellDataGroup.SelectMany(s => s.Categories).ToHashSet(),
                    Effects = spellDataGroup.SelectMany(s => s.Effects).ToHashSet().ToList(),
                };

                aggregatedSpellData.Add(agd);
            }

            var moreOutput = new Dictionary<string, string>();
            var finalCode = new StringBuilder();

            // I'm sorry -- this code is terrible -- I need to redo all of this stuff here --
            var _classType = ClassType.Pet;
            var _classSpec = ClassSpec.WarlockDemon;

            var asCount = 0;
            foreach (var s in aggregatedSpellData
                .OrderBy(a => a.ClassType)
                .ThenBy(a => a.ClassSpec)
                .ThenBy(a => a.SpellName))
            {
                var sb = new StringBuilder();

                sb.Append($"        public Spell {VariableName(s.SpellName)} ");
                sb.Append($"= new Spell(\"{s.SpellName}\", ");
                sb.Append($"ClassType.{s.ClassType}, ");
                sb.Append($"ClassSpec.{s.ClassSpec}, ");
                sb.Append($"new[] {{ {s.SpellIds.ToHashSet().OrderBy(i => i).Stringify()} }}, ");
                sb.Append($"new[] {{ {s.Levels.ToHashSet().OrderBy(i => i).Stringify()} }}, ");
                sb.Append($"{s.Talent}, ");
                sb.Append($"{s.Icon}, ");
                sb.Append($"new double[] {{ {s.Cooldowns.ToHashSet().OrderBy(i => i).Stringify()} }}, ");
                sb.Append($"new double[] {{ {s.Durations.ToHashSet().OrderBy(i => i).Stringify()} }}, ");
                sb.Append($"{s.IsPvp.ToString().ToLowerInvariant()}, ");
                sb.Append($"{s.Range}, ");
                if (s.Categories.Any())
                {
                    sb.Append($"new[] {{ {s.Categories.ToHashSet().OrderBy(i => i).Select(i => $"\"{i}\"").Stringify()} }}, ");
                }
                else
                {
                    sb.Append("new string[] { }, ");
                }
                sb.Append($"new[] {{ {s.Effects.Select(SpellEffectConstructor).ToHashSet().OrderBy(i => i).Stringify()} }}");
                sb.Append($");");

                moreOutput[$"{s.SpellName} {s.ClassType} {s.ClassSpec}"] = sb.ToString();

                if (s.ClassType != _classType || s.ClassSpec != _classSpec)
                {
                    _classType = s.ClassType;
                    _classSpec = s.ClassSpec;

                    if (finalCode.Length != 0) finalCode.AppendLine($"    }}\n");

                    finalCode.AppendLine(_classSpec == ClassSpec.Base
                        ? $"    public class {_classType}"
                        : $"    public class {_classSpec} : {_classType}");
                    finalCode.AppendLine($"    {{");

                    finalCode.AppendLine(sb.ToString());
                }
                else
                {
                    finalCode.AppendLine(sb.ToString());
                }

                asCount++;
            }

            finalCode.AppendLine($"    }}\n");

            File.WriteAllLines("output/spells2.txt", moreOutput.OrderBy(l => l.Key).Select(l => l.Value));
            Console.WriteLine($"As Count = {asCount};");

            File.WriteAllText("output/spells3.txt", finalCode.ToString());
        }

        public static string SpellEffectConstructor(SpellEffectData data)
        {
            // $"new SpellEffectData(SpellEffectName.{e.Name}, EffectAuraType.{e.AuraType})"
            var sb = new StringBuilder();
            sb.Append("new SpellEffectData(");

            if (Enum.IsDefined(typeof(SpellEffectName), data.Name))
            {
                sb.Append($"SpellEffectName.{data.Name}, ");
            }
            else
            {
                sb.Append($"(SpellEffectName){data.Name}, ");
            }

            if (Enum.IsDefined(typeof(EffectAuraType), data.AuraType))
            {
                sb.Append($"EffectAuraType.{data.AuraType}");
            }
            else
            {
                sb.Append($"(EffectAuraType){data.AuraType}");
            }

            sb.Append(")");

            return sb.ToString();
        }

        public static string VariableName(string name)
        {
            name = name
                .Replace("-", "_")
                .Replace("\'", "")
                .Replace(":", "")
                .Replace("!", "_")
                .Replace(",", "")
                .Replace(")", "")
                .Replace("(", "");

            var tokens = name.Split(" ");
            if (tokens.Length <= 1) return name;

            var varName = "";
            foreach (var token in tokens)
            {
                varName += token.Substring(0, 1).ToUpperInvariant() + token.Substring(1);
            }

            return varName;
        }
    }
}