using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    // todo: could use clean-up; we need to do some research -- can we trim down the variables that make it in here?
    internal static class AuraTriggers
    {
        public static void WatchForDebuffOnTarget(this Aura aura, string debuff)
        {
            aura.Triggers.Group.Add(DebuffOnTargetTrigger(debuff));
        }

        public static void WatchForBuffOnTarget(this Aura aura, string buff)
        {
            aura.Triggers.Group.Add(BuffOnTargetTrigger(buff));
        }

        public static void WatchForBuffOnPlayer(this Aura aura, string buff)
        {
            aura.Triggers.Group.Add(BuffOnPlayerTrigger(buff));
        }

        public static void WatchForBuffNotOnPlayer(this Aura aura, string buff)
        {
            aura.Triggers.Group.Add(BuffNotOnPlayerTrigger(buff));
        }

        public static void WatchForDebuffOnTargetLow(this Aura aura, string debuff, int secondsLeft)
        {
            var trigger = DebuffOnTargetTrigger(debuff);
            trigger.Trigger.UseRem = true;
            trigger.Trigger.RemOperator = "<=";
            trigger.Trigger.Rem = secondsLeft.ToString();

            aura.Triggers.Group.Add(trigger);
        }

        // Trigger.SpellName if want to use the ID instead of spell name
        // 93402
        public static void WatchForDebuffNotOnTarget(this Aura aura, string debuff, IEnumerable<int> spells)
        {
            var notOnTarget = DebuffOnTargetTrigger(debuff);
            notOnTarget.Trigger.MatchesShowOn = "showOnMissing";

            var usable = AbilityUsableTrigger(spells);

            aura.Triggers.Disjunctive = "all";
            aura.Triggers.Group.Add(notOnTarget);
            aura.Triggers.Group.Add(usable);
        }

        public static void WatchAbilityCooldown(this Aura aura, string ability, IEnumerable<int> spells)
        {
            var trigger = AbilityCooldownTrigger(ability, spells);
            aura.Triggers.Group.Add(trigger);
            aura.Triggers.ActiveTriggerMode = -10;
        }

        private static TriggerGroup AbilityCooldownTrigger(string ability, IEnumerable<int> spells) // int spellId)
        {
            var trigger = new TriggerGroup
            {
                Trigger = new Trigger
                {
                    // AuraNames = new List<string>(),
                    // AuraSpellIds = new List<string>(),
                    DebuffType = "HELPFUL",//
                    Duration = "1",//
                    Event = "Cooldown Progress (Spell)",//
                    GenericShowOn = "showAlways",//
                    Names = new List<string>(),//
                    RealSpellName = ability, //
                    SpellName = spells.First(),
                    // OwnOnly = true,
                    SpellIds = spells.Select(s => (long)s).ToList(), //
                    SubeventPrefix = "SPELL", //
                    SubeventSuffix = "_CAST_START", //
                    // Track = "auto",
                    Type = "status",//
                    Unevent = "auto",//
                    Unit = "player",//
                    UseGenericShowOn = true,//
                    UseSpellName = true, //
                    UseTrack = true, //
                    UseUnit = true, //
                    // UseName = true,
                },
                UnTrigger = new UnTrigger
                {
                    GenericShowOn = "showAlways"
                }
            };
            return trigger;
        }

        private static TriggerGroup DebuffOnTargetTrigger(string debuff)
        {
            var trigger = new TriggerGroup
            {
                Trigger = new Trigger
                {
                    AuraNames = new List<string> { debuff },
                    AuraSpellIds = new List<string>(),
                    DebuffType = "HARMFUL",
                    Duration = "1",
                    Event = "Cooldown Progress (Spell)",
                    GenericShowOn = "showAlways",
                    Names = new List<string>(),
                    OwnOnly = true,
                    SpellIds = new List<long>(),
                    SubeventPrefix = "SPELL",
                    SubeventSuffix = "_CAST_START",
                    Track = "auto",
                    Type = "aura2",
                    Unevent = "auto",
                    Unit = "target",
                    UseGenericShowOn = true,
                    // todo: all these needed?
                    UseSpellName = true,
                    UseTrack = true,
                    UseUnit = true,
                    UseName = true,
                },
                UnTrigger = new UnTrigger
                {
                    GenericShowOn = "showAlways"
                }
            };
            return trigger;
        }

        // todo: ["activeTriggerMode"] = -10, ???
        private static TriggerGroup BuffOnTargetTrigger(string buff)
        {
            var trigger = DebuffOnTargetTrigger(buff);
            trigger.Trigger.DebuffType = "HELPFUL";
            trigger.Trigger.GenericShowOn = null;
            trigger.UnTrigger.GenericShowOn = null;
            return trigger;
        }

        // todo: ["activeTriggerMode"] = -10, ???
        private static TriggerGroup BuffOnPlayerTrigger(string buffName)
        {
            var trigger = DebuffOnTargetTrigger(buffName);
            trigger.Trigger.DebuffType = "HELPFUL";
            trigger.Trigger.Unit = "player";
            trigger.Trigger.GenericShowOn = null;
            trigger.UnTrigger.GenericShowOn = null;
            return trigger;
        }

        private static TriggerGroup BuffNotOnPlayerTrigger(string buffName)
        {
            var buff = BuffOnPlayerTrigger(buffName);
            buff.Trigger.MatchesShowOn = "showOnMissing";

            return buff;
        }

        private static TriggerGroup AbilityUsableTrigger(IEnumerable<int> spells)
        {
            return new TriggerGroup
            {
                Trigger = new Trigger
                {
                    Duration = "1",
                    Event = "Action Usable",
                    // UseAbsorbMode = true,
                    UseTargetRequired = true,
                    Unit = "player",
                    UseUnit = true,
                    SubeventPrefix = "SPELL",
                    SubeventSuffix = "_CAST_START",
                    UseSpellName = true,
                    SpellName = (long)spells.First(),
                    SpellIds = spells.Select(s => (long)s).ToList(),
                    Unevent = "auto",
                    // RealSpellName = spell,
                    Type = "status"
                }
                // todo: do we need untrigger?
                // "untrigger": []
            };
        }
    }
}