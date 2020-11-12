﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Warrior
    {
        public Spell Attack = new Spell("Attack", ClassType.Warrior, ClassSpec.Base, new[] { 88163 }, new[] { 1 }, 0, 135274, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell BastionOfDefense = new Spell("Bastion of Defense", ClassType.Warrior, ClassSpec.Base, new[] { 84608 }, new[] { 25 }, 0, 132359, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBlockPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDodgePercent) });
        public Spell BattleShout = new Spell("Battle Shout", ClassType.Warrior, ClassSpec.Base, new[] { 6673, 193451 }, new[] { 39, 50 }, 0, 132333, new double[] { 0 }, new double[] { 5, 3600 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackPowerPct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRangedAttackPowerPct) });
        public Spell BattleStance = new Spell("Battle Stance", ClassType.Warrior, ClassSpec.Base, new[] { 260710 }, new[] { 1 }, 0, 132349, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BerserkerRage = new Spell("Berserker Rage", ClassType.Warrior, ClassSpec.Base, new[] { 18499 }, new[] { 29 }, 0, 136009, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity) });
        public Spell BladeDance = new Spell("Blade Dance", ClassType.Warrior, ClassSpec.Base, new[] { 236386 }, new[] { 26 }, 0, 236303, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AllowOnlyAbility), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunityMask), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell Bladestorm = new Spell("Bladestorm", ClassType.Warrior, ClassSpec.Base, new[] { 50622 }, new[] { 1 }, 0, 236303, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell BladestormOff_Hand = new Spell("Bladestorm Off-Hand", ClassType.Warrior, ClassSpec.Base, new[] { 95738 }, new[] { 1 }, 0, 236303, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Bloodbath = new Spell("Bloodbath", ClassType.Warrior, ClassSpec.Base, new[] { 335096 }, new[] { 10 }, 0, 236304, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Bloodcraze = new Spell("Bloodcraze", ClassType.Warrior, ClassSpec.Base, new[] { 280742, 280743 }, new[] { 10 }, 0, 132277, new double[] { }, new double[] { 20 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BloodcurdlingShout = new Spell("Bloodcurdling Shout", ClassType.Warrior, ClassSpec.Base, new[] { 23690 }, new[] { 1 }, 0, 236308, new double[] { }, new double[] { 6 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModFear), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed) });
        public Spell BloodthirstHeal = new Spell("Bloodthirst Heal", ClassType.Warrior, ClassSpec.Base, new[] { 117313 }, new[] { 1 }, 0, 136012, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell Bodyguard = new Spell("Bodyguard", ClassType.Warrior, ClassSpec.Base, new[] { 213871 }, new[] { 1 }, 0, 132359, new double[] { 0 }, new double[] { 60 }, true, 10, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SplitDamagePct) });
        public Spell BoundingStride = new Spell("Bounding Stride", ClassType.Warrior, ClassSpec.Base, new[] { 202163 }, new[] { 0 }, 11, 236171, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMod) });
        public Spell ChallengingShout = new Spell("Challenging Shout", ClassType.Warrior, ClassSpec.Base, new[] { 1161 }, new[] { 54 }, 0, 132091, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTaunt), new SpellEffectData(SpellEffectName.AttackMe, EffectAuraType.None) });
        public Spell Charge = new Spell("Charge", ClassType.Warrior, ClassSpec.Base, new[] { 100, 198337, 319157 }, new[] { 2, 3, 14 }, 0, 132337, new double[] { 1 }, new double[] { }, false, 25, new[] { "Class - Warrior - Mobility Shared Cooldown", "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell CrushingBlow = new Spell("Crushing Blow", ClassType.Warrior, ClassSpec.Base, new[] { 335097 }, new[] { 12 }, 0, 132215, new double[] { 0 }, new double[] { }, false, 10, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell DeadlyCalm = new Spell("Deadly Calm", ClassType.Warrior, ClassSpec.Base, new[] { 314520 }, new[] { 1 }, 0, 1561254, new double[] { 0 }, new double[] { 20 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAdditionalPowerCost) });
        public Spell DeathWish = new Spell("Death Wish", ClassType.Warrior, ClassSpec.Base, new[] { 199261 }, new[] { 10 }, 0, 136146, new double[] { 0 }, new double[] { 15 }, true, 0, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentDone), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken) });
        public Spell DeepWounds = new Spell("Deep Wounds", ClassType.Warrior, ClassSpec.Base, new[] { 262304 }, new[] { 10 }, 0, 132090, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell DefensiveStance = new Spell("Defensive Stance", ClassType.Warrior, ClassSpec.Base, new[] { 212520 }, new[] { 19 }, 0, 132349, new double[] { 6 }, new double[] { }, false, 0, new[] { "Class - Warrior - Defensive Stance" }, new[] { new SpellEffectData(SpellEffectName.RemoveAura, EffectAuraType.None) });
        public Spell DieByTheSword = new Spell("Die by the Sword", ClassType.Warrior, ClassSpec.Base, new[] { 236385 }, new[] { 18 }, 0, 132336, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerSpellAndWeaponCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModParryPercent) });
        public Spell DiveAttack = new Spell("Dive Attack", ClassType.Warrior, ClassSpec.Base, new[] { 324408 }, new[] { 19 }, 0, 1380676, new double[] { 0 }, new double[] { 0.25 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AllowOnlyAbility), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AreaTrigger), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedNoControl), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.UseNormalMovementSpeed) });
        public Spell DoubleTime = new Spell("Double Time", ClassType.Warrior, ClassSpec.Base, new[] { 103827 }, new[] { 1 }, 4, 237377, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMod), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges) });
        public Spell DragonCharge = new Spell("Dragon Charge", ClassType.Warrior, ClassSpec.Base, new[] { 206572 }, new[] { 19 }, 0, 1380676, new double[] { 0 }, new double[] { 1.2 }, true, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AllowOnlyAbility), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AreaTrigger), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedNoControl), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.UseNormalMovementSpeed) });
        public Spell Enrage = new Spell("Enrage", ClassType.Warrior, ClassSpec.Base, new[] { 184362 }, new[] { 1 }, 0, 136224, new double[] { }, new double[] { 4 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed) });
        public Spell Execute = new Spell("Execute", ClassType.Warrior, ClassSpec.Base, new[] { 163201, 217955, 260798, 280735, 280849, 281000, 316406 }, new[] { 1, 8, 9, 10, 42 }, 0, 135358, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell ExecuteOff_Hand = new Spell("Execute Off-Hand", ClassType.Warrior, ClassSpec.Base, new[] { 163558 }, new[] { 7 }, 0, 135358, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FocusedRage = new Spell("Focused Rage", ClassType.Warrior, ClassSpec.Base, new[] { 207982 }, new[] { 1 }, 0, 132345, new double[] { 0 }, new double[] { 30 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FuriousSlash = new Spell("Furious Slash", ClassType.Warrior, ClassSpec.Base, new[] { 100130, 231824, 255812, 256565 }, new[] { 10, 14 }, 0, 132367, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell GlyphOfThunderStrike = new Spell("Glyph of Thunder Strike", ClassType.Warrior, ClassSpec.Base, new[] { 115942 }, new[] { 1 }, 0, 136105, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Hamstring = new Spell("Hamstring", ClassType.Warrior, ClassSpec.Base, new[] { 1715 }, new[] { 4 }, 0, 132316, new double[] { 0 }, new double[] { 15 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell HeroicLeap = new Spell("Heroic Leap", ClassType.Warrior, ClassSpec.Base, new[] { 6544, 178368 }, new[] { 15, 33 }, 0, 236171, new double[] { 0.8 }, new double[] { 0.25 }, false, 40, new[] { "Class - Warrior - Heroic Leap" }, new[] { new SpellEffectData((SpellEffectName)254, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell HeroicThrow = new Spell("Heroic Throw", ClassType.Warrior, ClassSpec.Base, new[] { 57755 }, new[] { 24 }, 0, 132453, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell IgnorePain = new Spell("Ignore Pain", ClassType.Warrior, ClassSpec.Base, new[] { 190456 }, new[] { 17 }, 0, 1377132, new double[] { 0 }, new double[] { 12 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBaseResistancePct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell InForTheKill = new Spell("In For The Kill", ClassType.Warrior, ClassSpec.Base, new[] { 248622 }, new[] { 1 }, 0, 1029718, new double[] { }, new double[] { 10 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow) });
        public Spell Intercept = new Spell("Intercept", ClassType.Warrior, ClassSpec.Base, new[] { 198304, 198760 }, new[] { 1, 16 }, 0, 132365, new double[] { 0 }, new double[] { 10 }, true, 25, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddCasterHitTrigger), new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell Intervene = new Spell("Intervene", ClassType.Warrior, ClassSpec.Base, new[] { 3411, 147833, 316531 }, new[] { 1, 43 }, 0, 132365, new double[] { 1 }, new double[] { 6 }, false, 25, new[] { "Class - Warrior - Mobility Shared Cooldown" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddCasterHitTrigger), new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell IntimidatingShout = new Spell("Intimidating Shout", ClassType.Warrior, ClassSpec.Base, new[] { 5246, 316593 }, new[] { 27, 34 }, 0, 132154, new double[] { 0 }, new double[] { 8, 15 }, false, 8, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModFear), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRoot2), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.UseNormalMovementSpeed), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell JumpToHallsOfValor = new Spell("Jump to Halls of Valor", ClassType.Warrior, ClassSpec.Base, new[] { 233730 }, new[] { 12 }, 0, 298674, new double[] { }, new double[] { 60 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.TeleportToLfgDungeon, EffectAuraType.None) });
        public Spell JumpToSkyhold = new Spell("Jump to Skyhold", ClassType.Warrior, ClassSpec.Base, new[] { 192085 }, new[] { 12 }, 0, 298674, new double[] { 0 }, new double[] { }, false, 0, new[] { "Astral Recall" }, new[] { new SpellEffectData(SpellEffectName.JumpDest, EffectAuraType.None) });
        public Spell LearnExecute = new Spell("Learn Execute", ClassType.Warrior, ClassSpec.Base, new[] { 317072 }, new[] { 3 }, 0, 135358, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell MassSpellReflection = new Spell("Mass Spell Reflection", ClassType.Warrior, ClassSpec.Base, new[] { 172497 }, new[] { 1 }, 0, 132358, new double[] { 0 }, new double[] { 5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ReflectSpells), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ReflectSpellsSchool) });
        public Spell MortalStrike = new Spell("Mortal Strike", ClassType.Warrior, ClassSpec.Base, new[] { 192945, 213791, 339385 }, new[] { 5, 10 }, 0, 132355, new double[] { 0, 6 }, new double[] { 10 }, false, 5, new[] { "Class - Warrior - Mortal Strike", "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingPct), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Onslaught = new Spell("Onslaught", ClassType.Warrior, ClassSpec.Base, new[] { 235285, 235286 }, new[] { 1, 10 }, 0, 132364, new double[] { 0 }, new double[] { 12 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)408), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Overwatch = new Spell("Overwatch", ClassType.Warrior, ClassSpec.Base, new[] { 330279 }, new[] { 1 }, 0, 132361, new double[] { }, new double[] { 6 }, true, 25, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ReflectSpells) });
        public Spell Phalanx = new Spell("Phalanx", ClassType.Warrior, ClassSpec.Base, new[] { 287353 }, new[] { 19 }, 0, 132359, new double[] { 0 }, new double[] { 12 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)264), new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)371), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed) });
        public Spell Pummel = new Spell("Pummel", ClassType.Warrior, ClassSpec.Base, new[] { 6552 }, new[] { 7 }, 0, 132938, new double[] { 15 }, new double[] { 4 }, false, 5, new[] { "Silence" }, new[] { new SpellEffectData(SpellEffectName.InterruptCast, EffectAuraType.None) });
        public Spell RallyingCry = new Spell("Rallying Cry", ClassType.Warrior, ClassSpec.Base, new[] { 97462, 316825 }, new[] { 46, 56 }, 0, 132351, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Rampage = new Spell("Rampage", ClassType.Warrior, ClassSpec.Base, new[] { 184707, 184709, 201363, 201364, 218617 }, new[] { 1 }, 0, 132352, new double[] { }, new double[] { }, false, 8, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Rebound = new Spell("Rebound", ClassType.Warrior, ClassSpec.Base, new[] { 213915 }, new[] { 1 }, 0, 132358, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Rend = new Spell("Rend", ClassType.Warrior, ClassSpec.Base, new[] { 314533, 327258 }, new[] { 1 }, 0, 132155, new double[] { 0 }, new double[] { 15 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Retaliation = new Spell("Retaliation", ClassType.Warrior, ClassSpec.Base, new[] { 264085 }, new[] { 1 }, 0, 132269, new double[] { }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Revenge_ = new Spell("Revenge!", ClassType.Warrior, ClassSpec.Base, new[] { 5302 }, new[] { 12 }, 0, 132353, new double[] { }, new double[] { 6 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Safeguard = new Spell("Safeguard", ClassType.Warrior, ClassSpec.Base, new[] { 223658 }, new[] { 1 }, 0, 236311, new double[] { }, new double[] { 6 }, false, 40, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SplitDamagePct) });
        public Spell SecondWind = new Spell("Second Wind", ClassType.Warrior, ClassSpec.Base, new[] { 202147, 202149 }, new[] { 1 }, 0, 132175, new double[] { }, new double[] { 5 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ObsModHealth) });
        public Spell Sentinel = new Spell("Sentinel", ClassType.Warrior, ClassSpec.Base, new[] { 199130 }, new[] { 16 }, 0, 236310, new double[] { 0 }, new double[] { 8 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentDone), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken) });
        public Spell ShatteringThrow = new Spell("Shattering Throw", ClassType.Warrior, ClassSpec.Base, new[] { 64382 }, new[] { 41 }, 0, 311430, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerMissile, EffectAuraType.None) });
        public Spell ShieldBash = new Spell("Shield Bash", ClassType.Warrior, ClassSpec.Base, new[] { 198912 }, new[] { 14 }, 0, 132357, new double[] { 0 }, new double[] { 8 }, true, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentDone), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell ShieldBlock = new Spell("Shield Block", ClassType.Warrior, ClassSpec.Base, new[] { 2565, 132404, 199129, 231847 }, new[] { 4, 6, 13, 22 }, 0, 132110, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBlockPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell ShieldSlam = new Spell("Shield Slam", ClassType.Warrior, ClassSpec.Base, new[] { 23922 }, new[] { 3 }, 0, 134951, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Slam = new Spell("Slam", ClassType.Warrior, ClassSpec.Base, new[] { 1464 }, new[] { 1 }, 0, 132340, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell SpellReflection = new Spell("Spell Reflection", ClassType.Warrior, ClassSpec.Base, new[] { 23920, 169339 }, new[] { 26, 47 }, 0, 132361, new double[] { 0 }, new double[] { 5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ReflectSpells), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ReflectSpellsSchool) });
        public Spell StormBolt = new Spell("Storm Bolt", ClassType.Warrior, ClassSpec.Base, new[] { 132169 }, new[] { 1 }, 0, 613535, new double[] { }, new double[] { 4 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun) });
        public Spell Tactician = new Spell("Tactician", ClassType.Warrior, ClassSpec.Base, new[] { 199854 }, new[] { 1 }, 0, 236317, new double[] { }, new double[] { 2 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Taunt = new Spell("Taunt", ClassType.Warrior, ClassSpec.Base, new[] { 355 }, new[] { 8 }, 0, 136080, new double[] { 8 }, new double[] { 3 }, false, 30, new[] { "Taunt/Detaunt" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTaunt), new SpellEffectData(SpellEffectName.AttackMe, EffectAuraType.None) });
        public Spell Trauma = new Spell("Trauma", ClassType.Warrior, ClassSpec.Base, new[] { 215537 }, new[] { 1 }, 0, 132364, new double[] { }, new double[] { 6 }, false, 20, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage) });
        public Spell UnbridledWrath = new Spell("Unbridled Wrath", ClassType.Warrior, ClassSpec.Base, new[] { 198732 }, new[] { 1 }, 0, 800997, new double[] { }, new double[] { 10 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicEnergize) });
        public Spell UnwaveringSentinel = new Spell("Unwavering Sentinel", ClassType.Warrior, ClassSpec.Base, new[] { 29144 }, new[] { 10 }, 0, 133123, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerMeleeCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModExpertise) });
        public Spell VictoriousState = new Spell("Victorious State", ClassType.Warrior, ClassSpec.Base, new[] { 32215 }, new[] { 5 }, 0, 132342, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell VictoryRush = new Spell("Victory Rush", ClassType.Warrior, ClassSpec.Base, new[] { 34428, 319158 }, new[] { 5, 11 }, 0, 132342, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell WarBanner = new Spell("War Banner", ClassType.Warrior, ClassSpec.Base, new[] { 236320, 236435, 236437 }, new[] { 50 }, 0, 603532, new double[] { 1 }, new double[] { 15 }, true, 0, new[] { "War Banner" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell Warbringer = new Spell("Warbringer", ClassType.Warrior, ClassSpec.Base, new[] { 103828 }, new[] { 1 }, 0, 236319, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Warpath = new Spell("Warpath", ClassType.Warrior, ClassSpec.Base, new[] { 199088 }, new[] { 1 }, 0, 463281, new double[] { }, new double[] { -0.001 }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AreaTrigger) });
        public Spell Whirlwind = new Spell("Whirlwind", ClassType.Warrior, ClassSpec.Base, new[] { 1680, 85739, 199852, 259679, 347360 }, new[] { 1, 9 }, 0, 132369, new double[] { 0 }, new double[] { 1.4, 20 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell WhirlwindOff_Hand = new Spell("Whirlwind Off-Hand", ClassType.Warrior, ClassSpec.Base, new[] { 199851, 347362 }, new[] { 1 }, 0, 132369, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
    }
}