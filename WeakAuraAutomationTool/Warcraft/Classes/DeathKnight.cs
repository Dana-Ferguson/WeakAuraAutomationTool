﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class DeathKnight
    {
        public Spell AbominationsMight = new Spell("Abomination's Might", ClassType.DeathKnight, ClassSpec.Base, new[] { 207161 }, new[] { 1 }, 0, 237526, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell AncientDrakeBreath = new Spell("Ancient Drake Breath", ClassType.DeathKnight, ClassSpec.Base, new[] { 332365 }, new[] { 44 }, 0, 135833, new double[] { }, new double[] { 1.5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None) });
        public Spell Anti_MagicBarrier = new Spell("Anti-Magic Barrier", ClassType.DeathKnight, ClassSpec.Base, new[] { 205725 }, new[] { 1 }, 0, 136120, new double[] { }, new double[] { 10 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseHealth2), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Anti_MagicShell = new Spell("Anti-Magic Shell", ClassType.DeathKnight, ClassSpec.Base, new[] { 48707, 218977, 218988, 311975 }, new[] { 14, 24, 26 }, 0, 136120, new double[] { 0, 60 }, new double[] { 5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModImmuneAuraApplySchool), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Anti_MagicZone = new Spell("Anti-Magic Zone", ClassType.DeathKnight, ClassSpec.Base, new[] { 51052, 332829 }, new[] { 47 }, 0, 237510, new double[] { 45 }, new double[] { 10 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None) });
        public Spell ArmyOfTheDead = new Spell("Army of the Dead", ClassType.DeathKnight, ClassSpec.Base, new[] { 280440 }, new[] { 30 }, 0, 237511, new double[] { 480 }, new double[] { 3.5 }, true, 0, new[] { "Death Knight - Unholy - Army of the Dead" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Avoidance = new Spell("Avoidance", ClassType.DeathKnight, ClassSpec.Base, new[] { 62137 }, new[] { 1 }, 0, 132332, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAoeDamageAvoidance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModCreatureAoeDamageAvoidance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDetectedRange) });
        public Spell BloodBoil = new Spell("Blood Boil", ClassType.DeathKnight, ClassSpec.Base, new[] { 331962 }, new[] { 17 }, 0, 237513, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BloodMirror = new Spell("Blood Mirror", ClassType.DeathKnight, ClassSpec.Base, new[] { 206977 }, new[] { 1 }, 0, 134084, new double[] { 0 }, new double[] { 10 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell BloodShield = new Spell("Blood Shield", ClassType.DeathKnight, ClassSpec.Base, new[] { 77535 }, new[] { 1 }, 0, 237517, new double[] { }, new double[] { 10 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell BloodStrike = new Spell("Blood Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 45902 }, new[] { 23 }, 0, 135772, new double[] { 0 }, new double[] { 8 }, false, 5, new[] { "Blood Strike" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Bloodbolt = new Spell("Bloodbolt", ClassType.DeathKnight, ClassSpec.Base, new[] { 205750 }, new[] { 1 }, 0, 136160, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell BloodyReprisal = new Spell("Bloody Reprisal", ClassType.DeathKnight, ClassSpec.Base, new[] { 206935 }, new[] { 1 }, 0, 236158, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BoneShield = new Spell("Bone Shield", ClassType.DeathKnight, ClassSpec.Base, new[] { 195181, 232049 }, new[] { 23 }, 0, 458717, new double[] { }, new double[] { 30 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)268), new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)408), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseHealthPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell CadaverousPallor = new Spell("Cadaverous Pallor", ClassType.DeathKnight, ClassSpec.Base, new[] { 201995 }, new[] { 20 }, 0, 135983, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell ChainsOfIce = new Spell("Chains of Ice", ClassType.DeathKnight, ClassSpec.Base, new[] { 45524 }, new[] { 13 }, 0, 135834, new double[] { 0 }, new double[] { 8 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell ChillStreak = new Spell("Chill Streak", ClassType.DeathKnight, ClassSpec.Base, new[] { 204160 }, new[] { 13 }, 0, 429386, new double[] { 0 }, new double[] { }, true, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell ControlUndead = new Spell("Control Undead", ClassType.DeathKnight, ClassSpec.Base, new[] { 111673 }, new[] { 37 }, 0, 237273, new double[] { 0 }, new double[] { 300 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModCharm), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentDone) });
        public Spell CorpseExploder = new Spell("Corpse Exploder", ClassType.DeathKnight, ClassSpec.Base, new[] { 127344 }, new[] { 10 }, 0, 136133, new double[] { 0 }, new double[] { -0.001 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Transform), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell DancingRuneWeapon = new Spell("Dancing Rune Weapon", ClassType.DeathKnight, ClassSpec.Base, new[] { 81256 }, new[] { 23 }, 0, 135277, new double[] { }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModParryPercent) });
        public Spell DarkCommand = new Spell("Dark Command", ClassType.DeathKnight, ClassSpec.Base, new[] { 56222 }, new[] { 9 }, 0, 136088, new double[] { 8 }, new double[] { 3 }, false, 30, new[] { "Taunt/Detaunt" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTaunt), new SpellEffectData(SpellEffectName.AttackMe, EffectAuraType.None) });
        public Spell DarkInfusion = new Spell("Dark Infusion", ClassType.DeathKnight, ClassSpec.Base, new[] { 198943 }, new[] { 1 }, 0, 136188, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DarkSimulacrum = new Spell("Dark Simulacrum", ClassType.DeathKnight, ClassSpec.Base, new[] { 77606, 77616, 94984 }, new[] { 32 }, 0, 135888, new double[] { 0 }, new double[] { 12, 20, 30 }, true, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.HasteRanged), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamageDone), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingDone), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpellsTriggered) });
        public Spell DeathAndDecay = new Spell("Death and Decay", ClassType.DeathKnight, ClassSpec.Base, new[] { 43265, 203157 }, new[] { 3, 25 }, 0, 136144, new double[] { 30 }, new double[] { 10 }, true, 30, new[] { "Class - Death Knight - Death and Decay", "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell DeathChain = new Spell("Death Chain", ClassType.DeathKnight, ClassSpec.Base, new[] { 203173 }, new[] { 1 }, 0, 1390941, new double[] { 0 }, new double[] { 10 }, true, 10, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell DeathCoil = new Spell("Death Coil", ClassType.DeathKnight, ClassSpec.Base, new[] { 47541, 47633, 121147, 333470 }, new[] { 2, 23 }, 0, 136145, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerMissile, EffectAuraType.None) });
        public Spell DeathGate = new Spell("Death Gate", ClassType.DeathKnight, ClassSpec.Base, new[] { 50977 }, new[] { 10 }, 0, 135766, new double[] { 0 }, new double[] { 60 }, false, 0, new[] { "Astral Recall" }, new[] { new SpellEffectData(SpellEffectName.KillCredit, EffectAuraType.None), new SpellEffectData(SpellEffectName.TransDoor, EffectAuraType.None) });
        public Spell DeathGrip = new Spell("Death Grip", ClassType.DeathKnight, ClassSpec.Base, new[] { 49576, 311977 }, new[] { 5, 23 }, 0, 237532, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell DeathPact = new Spell("Death Pact", ClassType.DeathKnight, ClassSpec.Base, new[] { 48743 }, new[] { 0 }, 15, 136146, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolHealAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell DeathStrike = new Spell("Death Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 49998 }, new[] { 4 }, 0, 237517, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell DeathsAdvance = new Spell("Death's Advance", ClassType.DeathKnight, ClassSpec.Base, new[] { 48265, 311984, 343257 }, new[] { 23, 42, 49 }, 0, 237561, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunityMask), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMovementForceMagnitude) });
        public Spell DecomposingAura = new Spell("Decomposing Aura", ClassType.DeathKnight, ClassSpec.Base, new[] { 232352 }, new[] { 25 }, 0, 132205, new double[] { }, new double[] { 3 }, false, 15, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell EmpowerRuneWeapon = new Spell("Empower Rune Weapon", ClassType.DeathKnight, ClassSpec.Base, new[] { 89831 }, new[] { 29 }, 0, 135372, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell Fixate = new Spell("Fixate", ClassType.DeathKnight, ClassSpec.Base, new[] { 141918 }, new[] { 10 }, 0, 136080, new double[] { }, new double[] { 3 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPossessPet) });
        public Spell FreezingFog = new Spell("Freezing Fog", ClassType.DeathKnight, ClassSpec.Base, new[] { 207060 }, new[] { 1 }, 0, 135833, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell FrostShield = new Spell("Frost Shield", ClassType.DeathKnight, ClassSpec.Base, new[] { 207203 }, new[] { 1 }, 0, 135850, new double[] { }, new double[] { 10 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell FrostStrike = new Spell("Frost Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 213793 }, new[] { 23 }, 0, 237520, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.NormalizedWeaponDmg, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None), new SpellEffectData(SpellEffectName.WeaponPercentDamage, EffectAuraType.None) });
        public Spell GargoyleStrike = new Spell("Gargoyle Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 51963 }, new[] { 14 }, 0, 458967, new double[] { }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell GlyphOfFoulMenagerie = new Spell("Glyph of Foul Menagerie", ClassType.DeathKnight, ClassSpec.Base, new[] { 58642 }, new[] { 1 }, 0, 237511, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell GlyphOfHornOfWinter = new Spell("Glyph of Horn of Winter", ClassType.DeathKnight, ClassSpec.Base, new[] { 121920 }, new[] { 1 }, 0, 134228, new double[] { }, new double[] { 10 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Gnaw = new Spell("Gnaw", ClassType.DeathKnight, ClassSpec.Base, new[] { 47481, 91800 }, new[] { 22 }, 0, 237524, new double[] { 0 }, new double[] { 1 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell HeartstopAura = new Spell("Heartstop Aura", ClassType.DeathKnight, ClassSpec.Base, new[] { 199719 }, new[] { 20 }, 0, 1390944, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell HowlingBlast = new Spell("Howling Blast", ClassType.DeathKnight, ClassSpec.Base, new[] { 316800 }, new[] { 38 }, 0, 135833, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell HungeringRuneWeapon = new Spell("Hungering Rune Weapon", ClassType.DeathKnight, ClassSpec.Base, new[] { 207127 }, new[] { 1 }, 0, 1376744, new double[] { 0 }, new double[] { 12 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicEnergize) });
        public Spell IceboundFortitude = new Spell("Icebound Fortitude", ClassType.DeathKnight, ClassSpec.Base, new[] { 48792 }, new[] { 38 }, 0, 237525, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingReceived) });
        public Spell InexorableAssault = new Spell("Inexorable Assault", ClassType.DeathKnight, ClassSpec.Base, new[] { 253594, 253595, 281043 }, new[] { 1 }, 0, 343637, new double[] { }, new double[] { -0.001 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AreaTrigger), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell KillingMachine = new Spell("Killing Machine", ClassType.DeathKnight, ClassSpec.Base, new[] { 51124 }, new[] { 1 }, 0, 135305, new double[] { }, new double[] { 10 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRatingFromStat) });
        public Spell Lichborne = new Spell("Lichborne", ClassType.DeathKnight, ClassSpec.Base, new[] { 49039, 50397 }, new[] { 1, 33 }, 0, 136187, new double[] { 0 }, new double[] { 10, 30 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModLeech), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MindFreeze = new Spell("Mind Freeze", ClassType.DeathKnight, ClassSpec.Base, new[] { 47528 }, new[] { 7 }, 0, 237527, new double[] { 15 }, new double[] { 3 }, false, 15, new[] { "Silence" }, new[] { new SpellEffectData(SpellEffectName.InterruptCast, EffectAuraType.None) });
        public Spell MonstrousBlow = new Spell("Monstrous Blow", ClassType.DeathKnight, ClassSpec.Base, new[] { 91797 }, new[] { 22 }, 0, 135860, new double[] { 0 }, new double[] { 2 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell NecroticAura = new Spell("Necrotic Aura", ClassType.DeathKnight, ClassSpec.Base, new[] { 199642 }, new[] { 20 }, 0, 1390942, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell NecroticStrike = new Spell("Necrotic Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 73975, 233408 }, new[] { 31 }, 0, 132481, new double[] { 0 }, new double[] { 10 }, true, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolHealAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell OceanPower = new Spell("Ocean Power", ClassType.DeathKnight, ClassSpec.Base, new[] { 291107, 291108 }, new[] { 25 }, 0, 132205, new double[] { }, new double[] { 3 }, false, 15, new string[] { }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell OnAPaleHorse = new Spell("On a Pale Horse", ClassType.DeathKnight, ClassSpec.Base, new[] { 51986 }, new[] { 22 }, 0, 132264, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModFlightSpeedNotStack), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMountedSpeedNotStack) });
        public Spell Pandemic = new Spell("Pandemic", ClassType.DeathKnight, ClassSpec.Base, new[] { 199799 }, new[] { 1 }, 0, 348565, new double[] { }, new double[] { }, true, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell PathOfFrost = new Spell("Path of Frost", ClassType.DeathKnight, ClassSpec.Base, new[] { 3714, 212522, 212523 }, new[] { 26, 27 }, 0, 237528, new double[] { 0 }, new double[] { 600 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAreaAuraRaid, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAreaAuraRaid, EffectAuraType.WaterWalk), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell PowerfulSmash = new Spell("Powerful Smash", ClassType.DeathKnight, ClassSpec.Base, new[] { 212337 }, new[] { 1 }, 0, 132154, new double[] { 0 }, new double[] { 2 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell RaiseAlly = new Spell("Raise Ally", ClassType.DeathKnight, ClassSpec.Base, new[] { 61999 }, new[] { 39 }, 0, 136143, new double[] { 600 }, new double[] { }, false, 40, new[] { "Raise Ally" }, new[] { new SpellEffectData(SpellEffectName.Resurrect, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell RaiseDead = new Spell("Raise Dead", ClassType.DeathKnight, ClassSpec.Base, new[] { 46585, 52150 }, new[] { 12, 22 }, 0, 1100170, new double[] { 120 }, new double[] { -0.001, 60 }, false, 30, new[] { "Raise Dead" }, new[] { new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None), new SpellEffectData(SpellEffectName.SummonPet, EffectAuraType.None) });
        public Spell RaiseSkulker = new Spell("Raise Skulker", ClassType.DeathKnight, ClassSpec.Base, new[] { 196910, 198832, 198837 }, new[] { 1 }, 0, 136119, new double[] { }, new double[] { -0.001 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell RecentlyUsedDeathStrike = new Spell("Recently Used Death Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 180612 }, new[] { 1 }, 0, 237517, new double[] { }, new double[] { 3 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell RuneStrike = new Spell("Rune Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 316239 }, new[] { 1 }, 0, 237518, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell RunicCorruption = new Spell("Runic Corruption", ClassType.DeathKnight, ClassSpec.Base, new[] { 51460 }, new[] { 23 }, 0, 252272, new double[] { }, new double[] { 3 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPowerRegenPercent) });
        public Spell SacrificialPact = new Spell("Sacrificial Pact", ClassType.DeathKnight, ClassSpec.Base, new[] { 327574 }, new[] { 54 }, 0, 136133, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell ScourgeStrike = new Spell("Scourge Strike", ClassType.DeathKnight, ClassSpec.Base, new[] { 213795 }, new[] { 23 }, 0, 237530, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell ShadowBolt = new Spell("Shadow Bolt", ClassType.DeathKnight, ClassSpec.Base, new[] { 288546, 317791 }, new[] { 22 }, 0, 136197, new double[] { }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell ShamblingRush = new Spell("Shambling Rush", ClassType.DeathKnight, ClassSpec.Base, new[] { 91807 }, new[] { 14 }, 0, 237569, new double[] { }, new double[] { 2 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRoot2), new SpellEffectData(SpellEffectName.InterruptCast, EffectAuraType.None) });
        public Spell SludgeBelcher = new Spell("Sludge Belcher", ClassType.DeathKnight, ClassSpec.Base, new[] { 212027 }, new[] { 1 }, 0, 136119, new double[] { }, new double[] { -0.001 }, false, 30, new[] { "Raise Dead" }, new[] { new SpellEffectData(SpellEffectName.SummonPet, EffectAuraType.None) });
        public Spell Smash = new Spell("Smash", ClassType.DeathKnight, ClassSpec.Base, new[] { 212332, 212336 }, new[] { 1 }, 0, 132154, new double[] { 0 }, new double[] { 1 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Strangulate = new Spell("Strangulate", ClassType.DeathKnight, ClassSpec.Base, new[] { 47476 }, new[] { 24 }, 0, 136214, new double[] { 0 }, new double[] { 5 }, true, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSilence) });
        public Spell SummonGargoyle = new Spell("Summon Gargoyle", ClassType.DeathKnight, ClassSpec.Base, new[] { 61777, 317250 }, new[] { 23, 52 }, 0, 132182, new double[] { }, new double[] { 30 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Superstrain = new Spell("Superstrain", ClassType.DeathKnight, ClassSpec.Base, new[] { 331959 }, new[] { 10 }, 0, 135833, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell SweepingClaws = new Spell("Sweeping Claws", ClassType.DeathKnight, ClassSpec.Base, new[] { 91778 }, new[] { 22 }, 0, 237535, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell TrembleBeforeMe = new Spell("Tremble Before Me", ClassType.DeathKnight, ClassSpec.Base, new[] { 206960 }, new[] { 1 }, 0, 136122, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell UnholyBlight = new Spell("Unholy Blight", ClassType.DeathKnight, ClassSpec.Base, new[] { 115994 }, new[] { 1 }, 0, 136132, new double[] { }, new double[] { 14 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)381), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModGlobalCooldownByHaste), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage) });
        public Spell UnholyMight = new Spell("Unholy Might", ClassType.DeathKnight, ClassSpec.Base, new[] { 91107 }, new[] { 23 }, 0, 136225, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell UnholyPact = new Spell("Unholy Pact", ClassType.DeathKnight, ClassSpec.Base, new[] { 319255 }, new[] { 23 }, 0, 237557, new double[] { }, new double[] { 15 }, false, 40, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell UnholyStrength = new Spell("Unholy Strength", ClassType.DeathKnight, ClassSpec.Base, new[] { 53365 }, new[] { 10 }, 0, 135882, new double[] { }, new double[] { 15 }, false, 40, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage), new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell VeteranOfTheThirdWar = new Spell("Veteran of the Third War", ClassType.DeathKnight, ClassSpec.Base, new[] { 48263 }, new[] { 8 }, 0, 136005, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell VolatileShielding = new Spell("Volatile Shielding", ClassType.DeathKnight, ClassSpec.Base, new[] { 207188 }, new[] { 1 }, 0, 236224, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell WinterIsComing = new Spell("Winter is Coming", ClassType.DeathKnight, ClassSpec.Base, new[] { 207170 }, new[] { 1 }, 0, 930077, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell WraithWalk = new Spell("Wraith Walk", ClassType.DeathKnight, ClassSpec.Base, new[] { 218999, 219006, 219014 }, new[] { 27 }, 0, 1100041, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
    }
}