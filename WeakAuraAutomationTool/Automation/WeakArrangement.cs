using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WeakAuraAutomationTool.Automation.Positioning;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    public static class WeakArrangement
    {
        // OLD VARIANT
        public static void ArrangeSpells(this WeakAura weak, AuraGrid grid, ClassSpec spec, IEnumerable<Spell> spells)
        {
            var talents = new List<int>();
            var position = 0;

            grid = grid.Clone();
            grid.Reset();

            foreach (var spell in spells)
            {
                weak.AddSpell(spell, spec, 0, 0);

                var o = grid.Location?.Clone();

                grid.Next();

                var x = grid.Location.X;
                var y = grid.Location.Y;

                // Console.WriteLine($"{position}:: {x}, {y} -- {spell.Name} -- {y} - {grid.Origin.Y} < -{grid.Height} * {grid.Size}");

                var spellAuras = weak.AddSpell(spell, spec, x, y);
                if (talents.Any()) spellAuras.DisplaceByTalents(grid, position, talents.ToArray());

                if (spell.Talent != 0)
                {
                    talents.Add(spell.Talent);
                    grid.Location = o;
                }
                else
                {
                    position++;
                }
            }
        }

        private static string PositionAurasLua { get; } = System.IO.File.ReadAllText("Lua/PositionAuras.lua");

        // Extract the script build? via class proxy?
        // todo: this is terrible
        private static readonly StringBuilder _sb = new StringBuilder();
        private static int _auraGrid = 0;
        private static int _auraTalent = 0;
        private static int _auraClassSpec = 0;

        // todo: this is _really_ bad logic, only works since lists don't change order
        // LUA DRIVEN VARIANT
        public static void ArrangeSpells2(this WeakAura weak, AuraGrid grid, ClassSpec spec, IEnumerable<Spell> spells)
        {
            foreach (var spell in spells)
            {
                var spellAuras = weak.AddSpell(spell, spec, 0, 0);

                for (var i = 0; i < spellAuras.Count; i++)
                {
                    var advance = i == spellAuras.Count - 1;
                    var aura = spellAuras[i];
                    var auraGrid = grid.LuaId;
                    var auraTalent = spell.Talent;
                    var auraClassSpec = (int)spec;

                    if (auraClassSpec != _auraClassSpec)
                    {
                        _sb.AddRecords(aura.Id, advance, auraGrid, auraTalent, auraClassSpec);
                    }
                    else if (auraTalent != _auraTalent)
                    {
                        _sb.AddRecords(aura.Id, advance, auraGrid, auraTalent);
                    }
                    else if (auraGrid != _auraGrid)
                    {
                        _sb.AddRecords(aura.Id, advance, auraGrid);
                    }
                    else if (advance)
                    {
                        _sb.AddRecords(aura.Id, advance);
                    }
                    else
                    {
                        _sb.AddRecords(aura.Id);
                    }

                    _auraGrid = auraGrid;
                    _auraTalent = auraTalent;
                    _auraClassSpec = auraClassSpec;
                }
            }
        }

        private static void AddRecords(this StringBuilder sb, params object[] variables)
        {
            sb.Append("    Aura:create(");

            var first = true;
            foreach (var variable in variables)
            {
                if (!first)
                {
                    sb.Append(",");
                }
                else
                {
                    first = false;
                }

                if (variable is string text)
                {
                    sb.Append($"'{text}'");
                }
                else if (variable is bool boolean)
                {
                    sb.Append($"{boolean.ToString().ToLowerInvariant()}");
                }
                else
                {
                    sb.Append($"{variable}");
                }
            }

            sb.AppendLine("),");
        }

        public static void AddPositioningScript(this WeakAura weak)
        {
            _sb.Length--;

            // icon = 629054

            // Script
            var script = PositionAurasLua;
            script = script.Replace("-- %auras%", _sb.ToString());

            var scriptAura = AuraIcon.Generate("positioning_script");
            scriptAura.Conditions.Add(new Condition
            {
                Check = new Check
                {
                    Trigger = -1,
                    Variable = "customcheck",
                    Op = "PLAYER_TALENT_UPDATE",
                    Value = script
                },
                Changes = new List<Change>()
            });

            scriptAura.DisplayIcon = 629054;
            scriptAura.IconSource = 0;

            weak.Table.Children.Add(scriptAura);
        }
    }
}