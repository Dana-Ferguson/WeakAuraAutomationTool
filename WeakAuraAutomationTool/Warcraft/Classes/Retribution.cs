﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Retribution : Paladin
    {
        public Spell ArtOfWar = new Spell("Art of War", ClassType.Paladin, ClassSpec.Retribution, new[] { 267344, 317912 }, new[] { 24, 48 }, 0, 236246, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BladeOfJustice = new Spell("Blade of Justice", ClassType.Paladin, ClassSpec.Retribution, new[] { 184575, 327981 }, new[] { 19, 34 }, 0, 1360757, new double[] { 0 }, new double[] { }, false, 12, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BladeOfWrath = new Spell("Blade of Wrath", ClassType.Paladin, ClassSpec.Retribution, new[] { 231832 }, new[] { 1 }, 5, 1360757, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell CleanseToxins = new Spell("Cleanse Toxins", ClassType.Paladin, ClassSpec.Retribution, new[] { 213644 }, new[] { 12 }, 0, 135953, new double[] { 8 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell Crusade = new Spell("Crusade", ClassType.Paladin, ClassSpec.Retribution, new[] { 231895 }, new[] { 0 }, 20, 236262, new double[] { 0 }, new double[] { 25 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AbilityIgnoreAuraState), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAutoattackDamage) });
        public Spell CrusaderStrike = new Spell("Crusader Strike", ClassType.Paladin, ClassSpec.Retribution, new[] { 231667, 342348 }, new[] { 11, 33 }, 0, 135891, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges) });
        public Spell DivineStorm = new Spell("Divine Storm", ClassType.Paladin, ClassSpec.Retribution, new[] { 53385 }, new[] { 23 }, 0, 236250, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell EmpyreanPower = new Spell("Empyrean Power", ClassType.Paladin, ClassSpec.Retribution, new[] { 326732 }, new[] { 0 }, 6, 236263, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell ExecutionSentence = new Spell("Execution Sentence", ClassType.Paladin, ClassSpec.Retribution, new[] { 343527 }, new[] { 0 }, 3, 613954, new double[] { 0 }, new double[] { 8 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage) });
        public Spell EyeForAnEye = new Spell("Eye for an Eye", ClassType.Paladin, ClassSpec.Retribution, new[] { 205191 }, new[] { 0 }, 12, 135986, new double[] { 0 }, new double[] { 10 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken) });
        public Spell FinalReckoning = new Spell("Final Reckoning", ClassType.Paladin, ClassSpec.Retribution, new[] { 343721 }, new[] { 0 }, 21, 135878, new double[] { 0 }, new double[] { 8 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpellDamageFromCaster), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FiresOfJustice = new Spell("Fires of Justice", ClassType.Paladin, ClassSpec.Retribution, new[] { 203316 }, new[] { 1 }, 4, 135891, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMultiplier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell HandOfHindrance = new Spell("Hand of Hindrance", ClassType.Paladin, ClassSpec.Retribution, new[] { 183218 }, new[] { 18 }, 0, 1360760, new double[] { 0 }, new double[] { 10 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed) });
        public Spell HealingHands = new Spell("Healing Hands", ClassType.Paladin, ClassSpec.Retribution, new[] { 326734 }, new[] { 0 }, 18, 236254, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Judgment = new Spell("Judgment", ClassType.Paladin, ClassSpec.Retribution, new[] { 231663, 315867 }, new[] { 16, 29 }, 0, 135959, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell JusticarsVengeance = new Spell("Justicar's Vengeance", ClassType.Paladin, ClassSpec.Retribution, new[] { 215661 }, new[] { 0 }, 17, 135957, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.HealthLeech, EffectAuraType.None) });
        public Spell MasteryHandOfLight = new Spell("Mastery: Hand of Light", ClassType.Paladin, ClassSpec.Retribution, new[] { 267316 }, new[] { 10 }, 0, 236248, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Rebuke = new Spell("Rebuke", ClassType.Paladin, ClassSpec.Retribution, new[] { 96231 }, new[] { 27 }, 0, 523893, new double[] { 15 }, new double[] { 4 }, false, 5, new[] { "Silence" }, new[] { new SpellEffectData(SpellEffectName.InterruptCast, EffectAuraType.None) });
        public Spell RighteousVerdict = new Spell("Righteous Verdict", ClassType.Paladin, ClassSpec.Retribution, new[] { 267610 }, new[] { 0 }, 2, 461860, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell SanctifiedWrath = new Spell("Sanctified Wrath", ClassType.Paladin, ClassSpec.Retribution, new[] { 317866 }, new[] { 0 }, 19, 236259, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackPowerOfArmor) });
        public Spell SelflessHealer = new Spell("Selfless Healer", ClassType.Paladin, ClassSpec.Retribution, new[] { 85804 }, new[] { 0 }, 16, 236252, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell ShieldOfVengeance = new Spell("Shield of Vengeance", ClassType.Paladin, ClassSpec.Retribution, new[] { 184662 }, new[] { 26 }, 0, 236264, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell TemplarsVerdict = new Spell("Templar's Verdict", ClassType.Paladin, ClassSpec.Retribution, new[] { 85256 }, new[] { 10 }, 0, 461860, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell WakeOfAshes = new Spell("Wake of Ashes", ClassType.Paladin, ClassSpec.Retribution, new[] { 255937 }, new[] { 39 }, 0, 1112939, new double[] { 0 }, new double[] { 5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpellDamageFromCaster), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Zeal = new Spell("Zeal", ClassType.Paladin, ClassSpec.Retribution, new[] { 269569 }, new[] { 0 }, 1, 135961, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
    }
}