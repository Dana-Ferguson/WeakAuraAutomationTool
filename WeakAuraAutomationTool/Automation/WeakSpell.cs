using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    public static class WeakSpell
    {
        public static void Add<T>(this List<T> list, params T[] items)
        {
            list.AddRange(items);
        }

        public static List<Aura> AddSpell(this WeakAura weak, Spell spell, ClassSpec classSpec, int x, int y)
        {
            var addedAuras = new List<Aura>();
            var auraId = GenerateAuraId(classSpec, spell);

            if (spell.Type.HasFlag(SpellType.Cooldown))
            {
                var aura = AuraIcon.Generate(auraId);
                aura.WatchAbilityCooldown(spell.Name, spell.Id);
                addedAuras.Add(aura);
            }

            if (spell.Type.HasFlag(SpellType.DoT))
            {
                var onTarget = AuraIcon.Generate($"{auraId}_is_on_target");
                onTarget.WatchForDebuffOnTarget(spell.Name);

                var notOnTarget = AuraIcon.Generate($"{auraId}_not_on_target");
                notOnTarget.WatchForDebuffNotOnTarget(spell.Name, spell.Id);
                notOnTarget.AddGlow(new Color(1, 0.04, 0.3));

                var refreshable = (int)Math.Floor(spell.Duration * 0.3);
                if (refreshable < 1)
                {
                    Console.WriteLine($"WARN: {spell} refreshable very low: {refreshable};");
                }

                var canRefresh = AuraIcon.Generate($"{auraId}_refreshable");
                canRefresh.AddGlow();
                canRefresh.WatchForDebuffOnTargetLow(spell.Name, refreshable);

                addedAuras.Add(onTarget, notOnTarget, canRefresh);
            }
            // DoT types already include a debuff on target tracker
            else if (spell.Type.HasFlag(SpellType.DebuffOnTarget))
            {
                var onTarget = AuraIcon.Generate($"{auraId}_is_on_target");
                onTarget.AddGlow();

                if (spell.AssociatedAuras.Count != 0)
                {
                    spell.AssociatedAuras.ForEach(s => onTarget.WatchForDebuffOnTarget(s.Name));
                }
                else
                {
                    onTarget.WatchForDebuffOnTarget(spell.Name);
                }

                addedAuras.Add(onTarget);
            }

            if (spell.Type.HasFlag(SpellType.BuffOnPlayer))
            {
                var onPlayer = AuraIcon.Generate($"{auraId}_buff_on_me");
                onPlayer.AddGlow();

                if (spell.AssociatedAuras.Count != 0)
                {
                    spell.AssociatedAuras.ForEach(s =>
                    {
                        if (s.Invert) onPlayer.WatchForBuffNotOnPlayer(s.Name);
                        else onPlayer.WatchForBuffOnPlayer(s.Name);
                    });
                }
                else
                {
                    if (spell.Invert) onPlayer.WatchForBuffNotOnPlayer(spell.Name);
                    else onPlayer.WatchForBuffOnPlayer(spell.Name);
                }

                addedAuras.Add(onPlayer);
            }

            foreach (var aura in addedAuras)
            {
                weak.Table.Children.Add(aura);

                aura.LoadIf(classSpec);
                aura.LoadIfTalent(spell.Talent);
                aura.AddVisibilityToggle();
                aura.XOffset = x;
                aura.YOffset = y;

                if (spell.BigStacks)
                {
                    // First SubRegion is always a TextRegion
                    aura.SubRegions.First().TextFontSize = 30;
                }
            }

            return addedAuras;
        }

        private static string GenerateAuraId(ClassSpec classSpec, Spell spell)
        {
            var sb = new StringBuilder();

            sb.Append(classSpec.ToString());
            sb.Append('_');
            sb.Append(spell.Name);
            sb.Append('_');
            sb.Append(spell.Id);

            //if (spell.Type.HasFlag(SpellType.Cooldown)) sb.Append("_cd");
            //if (spell.Type.HasFlag(SpellType.DebuffOnTarget)) sb.Append("_debuff");
            //if (spell.Type.HasFlag(SpellType.BuffOnPlayer)) sb.Append("_buff");
            //if (spell.Type.HasFlag(SpellType.BuffOnTarget)) sb.Append("_tar");
            if (spell.Type.HasFlag(SpellType.DoT)) sb.Append("_dot");
            if (spell.Talent != 0) sb.Append("_t").Append(spell.Talent);

            return sb.ToString().ToLowerInvariant();
        }
    }
}