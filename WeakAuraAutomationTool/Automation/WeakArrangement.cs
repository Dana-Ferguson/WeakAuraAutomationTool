using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WeakAuraAutomationTool.Automation.Positioning;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Automation
{
    public static class WeakArrangement
    {
        // todo: name?
        public static void ArrangeSpells(this WeakAura weak, AuraGrid grid, ClassSpec spec, IEnumerable<Spell> spells)
        {
            var talents = new List<int>();
            var position = 0;

            grid = grid.Clone();
            grid.Reset();

            foreach (var spell in spells)
            {
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
    }
}