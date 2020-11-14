using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Automation;
using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque
{
    public class SpecBuilder
    {
        public readonly ClassSpec Spec;

        public readonly List<Spell> CoreRotation = new List<Spell>();
        public readonly List<Spell> CoreCooldowns = new List<Spell>();

        public readonly List<Spell> Alerts = new List<Spell>();
        public readonly List<Spell> CombatBuffs = new List<Spell>();

        public readonly List<Spell> Mobility = new List<Spell>();
        public readonly List<Spell> Utility = new List<Spell>();

        // this ia a band-aid
        public readonly List<Spell> Overflow = new List<Spell>();

        public SpecBuilder(ClassSpec spec)
        {
            Spec = spec;
        }

        public SpecBuilder AddCoreRotation(params Spell[] spells)
        {
            CoreRotation.AddRange(spells);
            return this;
        }

        public SpecBuilder AddCoreCooldowns(params Spell[] spells)
        {
            CoreCooldowns.AddRange(spells);
            return this;
        }

        public SpecBuilder AddAlerts(params Spell[] spells)
        {
            Alerts.AddRange(spells);
            return this;
        }

        public SpecBuilder AddCombatBuffs(params Spell[] spells)
        {
            CombatBuffs.AddRange(spells);
            return this;
        }

        public SpecBuilder AddMobility(params Spell[] spells)
        {
            Mobility.AddRange(spells);
            return this;
        }

        public SpecBuilder AddUtility(params Spell[] spells)
        {
            Utility.AddRange(spells);
            return this;
        }

        public SpecBuilder AddOverflow(params Spell[] spells)
        {
            Overflow.AddRange(spells);
            return this;
        }

        public void Build(WeakAura wa)
        {
            wa.ArrangeSpells2(Groups.CoreRotation, Spec, CoreRotation);
            wa.ArrangeSpells2(Groups.CoreCooldowns, Spec, CoreCooldowns);
            wa.ArrangeSpells2(Groups.CombatBuffs, Spec, CombatBuffs);
            wa.ArrangeSpells2(Groups.Mobility, Spec, Mobility);
            wa.ArrangeSpells2(Groups.Utility, Spec, Utility);

            foreach (var alert in Alerts)
            {
                // -125, 225 -- 80, 80
                wa.AddSpell(alert, Spec, -25, 325)
                  .SetSize(64, 64)
                  .LoadInCombat();
            }

            wa.ArrangeSpells2(Groups.Overflow, Spec, Overflow);
        }
    }
}