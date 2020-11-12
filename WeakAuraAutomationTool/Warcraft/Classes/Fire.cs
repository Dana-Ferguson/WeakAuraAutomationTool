﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Fire : Mage
    {
        public Spell AlexstraszasFury = new Spell("Alexstrasza's Fury", ClassType.Mage, ClassSpec.Fire, new[] { 235870 }, new[] { 1 }, 11, 1380676, new double[] { 0 }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell AlterTime = new Spell("Alter Time", ClassType.Mage, ClassSpec.Fire, new[] { 108978 }, new[] { 58 }, 0, 609811, new double[] { 1 }, new double[] { 20 }, false, 0, new[] { "Alter Time" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell BlastWave = new Spell("Blast Wave", ClassType.Mage, ClassSpec.Fire, new[] { 157981 }, new[] { 1 }, 6, 135903, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BlazingBarrier = new Spell("Blazing Barrier", ClassType.Mage, ClassSpec.Fire, new[] { 235313, 321708 }, new[] { 11, 48 }, 0, 132221, new double[] { 0 }, new double[] { 60 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.HasteRanged), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell BlazingSoul = new Spell("Blazing Soul", ClassType.Mage, ClassSpec.Fire, new[] { 235365 }, new[] { 1 }, 4, 236215, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Cauterize = new Spell("Cauterize", ClassType.Mage, ClassSpec.Fire, new[] { 86949 }, new[] { 42 }, 0, 252268, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHaste), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Combustion = new Spell("Combustion", ClassType.Mage, ClassSpec.Fire, new[] { 190319, 321710 }, new[] { 29, 56 }, 0, 135824, new double[] { 0 }, new double[] { 10 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRating), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell Conflagration = new Spell("Conflagration", ClassType.Mage, ClassSpec.Fire, new[] { 205023 }, new[] { 1 }, 17, 459026, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell CriticalMass = new Spell("Critical Mass", ClassType.Mage, ClassSpec.Fire, new[] { 117216, 231630 }, new[] { 23, 47 }, 0, 236216, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRatingPct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpellCritChance) });
        public Spell DragonsBreath = new Spell("Dragon's Breath", ClassType.Mage, ClassSpec.Fire, new[] { 31661, 321707 }, new[] { 27, 38 }, 0, 134153, new double[] { 20 }, new double[] { 4 }, false, 0, new[] { "Dragon's Breath" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModConfuse), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FireBlast = new Spell("Fire Blast", ClassType.Mage, ClassSpec.Fire, new[] { 108853, 231567, 231568 }, new[] { 18, 32, 37 }, 0, 135807, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Fireball = new Spell("Fireball", ClassType.Mage, ClassSpec.Fire, new[] { 133, 157642, 343194 }, new[] { 10, 33, 41 }, 0, 135812, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Firestarter = new Spell("Firestarter", ClassType.Mage, ClassSpec.Fire, new[] { 205026 }, new[] { 1 }, 1, 135805, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FlameOn = new Spell("Flame On", ClassType.Mage, ClassSpec.Fire, new[] { 205029 }, new[] { 1 }, 10, 519830, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMultiplier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell FlamePatch = new Spell("Flame Patch", ClassType.Mage, ClassSpec.Fire, new[] { 205037 }, new[] { 1 }, 16, 451164, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Flamestrike = new Spell("Flamestrike", ClassType.Mage, ClassSpec.Fire, new[] { 2120, 321709, 343230 }, new[] { 17, 43, 52 }, 0, 135826, new double[] { 0 }, new double[] { 8 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FreneticSpeed = new Spell("Frenetic Speed", ClassType.Mage, ClassSpec.Fire, new[] { 236058 }, new[] { 1 }, 13, 135788, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell FromTheAshes = new Spell("From the Ashes", ClassType.Mage, ClassSpec.Fire, new[] { 342344 }, new[] { 1 }, 12, 652130, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Mastery) });
        public Spell HotStreak = new Spell("Hot Streak", ClassType.Mage, ClassSpec.Fire, new[] { 195283 }, new[] { 14 }, 0, 236218, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Kindling = new Spell("Kindling", ClassType.Mage, ClassSpec.Fire, new[] { 155148 }, new[] { 0 }, 19, 1033910, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell LivingBomb = new Spell("Living Bomb", ClassType.Mage, ClassSpec.Fire, new[] { 44457 }, new[] { 1 }, 18, 236220, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MasteryIgnite = new Spell("Mastery: Ignite", ClassType.Mage, ClassSpec.Fire, new[] { 12846 }, new[] { 10 }, 0, 135818, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Meteor = new Spell("Meteor", ClassType.Mage, ClassSpec.Fire, new[] { 153561 }, new[] { 0 }, 21, 1033911, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell PhoenixFlames = new Spell("Phoenix Flames", ClassType.Mage, ClassSpec.Fire, new[] { 257541, 343222 }, new[] { 19, 46 }, 0, 1392549, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.TriggerMissile, EffectAuraType.None) });
        public Spell Pyroblast = new Spell("Pyroblast", ClassType.Mage, ClassSpec.Fire, new[] { 11366, 321711 }, new[] { 12, 54 }, 0, 135808, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell PyroblastClearcastingDriver = new Spell("Pyroblast Clearcasting Driver", ClassType.Mage, ClassSpec.Fire, new[] { 44448 }, new[] { 14 }, 0, 236218, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Pyroclasm = new Spell("Pyroclasm", ClassType.Mage, ClassSpec.Fire, new[] { 269650 }, new[] { 1 }, 20, 451169, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Pyromaniac = new Spell("Pyromaniac", ClassType.Mage, ClassSpec.Fire, new[] { 205020 }, new[] { 1 }, 2, 463567, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Scorch = new Spell("Scorch", ClassType.Mage, ClassSpec.Fire, new[] { 2948 }, new[] { 13 }, 0, 135827, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell SearingTouch = new Spell("Searing Touch", ClassType.Mage, ClassSpec.Fire, new[] { 269644 }, new[] { 1 }, 3, 236290, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
    }
}