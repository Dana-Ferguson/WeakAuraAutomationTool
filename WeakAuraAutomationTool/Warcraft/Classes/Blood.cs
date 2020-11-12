﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Blood : DeathKnight
    {
        public Spell Anti_MagicBarrier = new Spell("Anti-Magic Barrier", ClassType.DeathKnight, ClassSpec.Blood, new[] { 205727 }, new[] { 0 }, 11, 136120, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Asphyxiate = new Spell("Asphyxiate", ClassType.DeathKnight, ClassSpec.Blood, new[] { 221562 }, new[] { 21 }, 0, 538558, new double[] { 0 }, new double[] { 5 }, false, 20, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Strangulate) });
        public Spell BloodBoil = new Spell("Blood Boil", ClassType.DeathKnight, ClassSpec.Blood, new[] { 50842, 316634 }, new[] { 17, 24 }, 0, 237513, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BloodTap = new Spell("Blood Tap", ClassType.DeathKnight, ClassSpec.Blood, new[] { 221699 }, new[] { 0 }, 9, 237515, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell Blooddrinker = new Spell("Blooddrinker", ClassType.DeathKnight, ClassSpec.Blood, new[] { 206931 }, new[] { 0 }, 2, 838812, new double[] { 0 }, new double[] { 3 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicLeech) });
        public Spell Bloodworms = new Spell("Bloodworms", ClassType.DeathKnight, ClassSpec.Blood, new[] { 195679 }, new[] { 0 }, 18, 136211, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.TriggerSpellOnHealthBelowPct), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Bonestorm = new Spell("Bonestorm", ClassType.DeathKnight, ClassSpec.Blood, new[] { 194844 }, new[] { 0 }, 21, 342917, new double[] { 0 }, new double[] { 1 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Consumption = new Spell("Consumption", ClassType.DeathKnight, ClassSpec.Blood, new[] { 274156 }, new[] { 0 }, 6, 1121487, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.HealthLeech, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell CrimsonScourge = new Spell("Crimson Scourge", ClassType.DeathKnight, ClassSpec.Blood, new[] { 81136 }, new[] { 18 }, 0, 236305, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DancingRuneWeapon = new Spell("Dancing Rune Weapon", ClassType.DeathKnight, ClassSpec.Blood, new[] { 49028 }, new[] { 34 }, 0, 135277, new double[] { 0 }, new double[] { 13 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell DeathAndDecay = new Spell("Death and Decay", ClassType.DeathKnight, ClassSpec.Blood, new[] { 316664 }, new[] { 43 }, 0, 136144, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell DeathPact = new Spell("Death Pact", ClassType.DeathKnight, ClassSpec.Blood, new[] { 48743 }, new[] { 0 }, 17, 136146, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolHealAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell DeathsCaress = new Spell("Death's Caress", ClassType.DeathKnight, ClassSpec.Blood, new[] { 195292 }, new[] { 28 }, 0, 1376743, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerMissile, EffectAuraType.None) });
        public Spell FoulBulwark = new Spell("Foul Bulwark", ClassType.DeathKnight, ClassSpec.Blood, new[] { 206974 }, new[] { 0 }, 7, 132390, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell GorefiendsGrasp = new Spell("Gorefiend's Grasp", ClassType.DeathKnight, ClassSpec.Blood, new[] { 108199 }, new[] { 32 }, 0, 538767, new double[] { 0 }, new double[] { 10 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell GripOfTheDead = new Spell("Grip of the Dead", ClassType.DeathKnight, ClassSpec.Blood, new[] { 273952 }, new[] { 0 }, 13, 132102, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell HeartStrike = new Spell("Heart Strike", ClassType.DeathKnight, ClassSpec.Blood, new[] { 206930, 316575, 317090 }, new[] { 10, 23, 52 }, 0, 135675, new double[] { 0 }, new double[] { 8 }, false, 5, new[] { "Blood Strike" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Hemostasis = new Spell("Hemostasis", ClassType.DeathKnight, ClassSpec.Blood, new[] { 273946 }, new[] { 0 }, 5, 538040, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell MarkOfBlood = new Spell("Mark of Blood", ClassType.DeathKnight, ClassSpec.Blood, new[] { 206940 }, new[] { 1 }, 12, 132205, new double[] { 0 }, new double[] { 15 }, false, 15, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Marrowrend = new Spell("Marrowrend", ClassType.DeathKnight, ClassSpec.Blood, new[] { 195182, 316746 }, new[] { 11, 41 }, 0, 1376745, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell MasteryBloodShield = new Spell("Mastery: Blood Shield", ClassType.DeathKnight, ClassSpec.Blood, new[] { 77513 }, new[] { 10 }, 0, 135772, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackPowerPct) });
        public Spell Ossuary = new Spell("Ossuary", ClassType.DeathKnight, ClassSpec.Blood, new[] { 219786 }, new[] { 58 }, 0, 460686, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxPower) });
        public Spell Purgatory = new Spell("Purgatory", ClassType.DeathKnight, ClassSpec.Blood, new[] { 114556 }, new[] { 0 }, 19, 134430, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHaste) });
        public Spell RapidDecomposition = new Spell("Rapid Decomposition", ClassType.DeathKnight, ClassSpec.Blood, new[] { 194662 }, new[] { 0 }, 4, 538560, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell RedThirst = new Spell("Red Thirst", ClassType.DeathKnight, ClassSpec.Blood, new[] { 205723 }, new[] { 0 }, 20, 135770, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell RelishInBlood = new Spell("Relish in Blood", ClassType.DeathKnight, ClassSpec.Blood, new[] { 317610 }, new[] { 0 }, 8, 538561, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Riposte = new Spell("Riposte", ClassType.DeathKnight, ClassSpec.Blood, new[] { 161797 }, new[] { 29 }, 0, 135340, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ConvertCritRatingPctToParryRating) });
        public Spell RuneTap = new Spell("Rune Tap", ClassType.DeathKnight, ClassSpec.Blood, new[] { 194679, 316616 }, new[] { 19, 44 }, 0, 237529, new double[] { 0 }, new double[] { 4 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges) });
        public Spell TighteningGrasp = new Spell("Tightening Grasp", ClassType.DeathKnight, ClassSpec.Blood, new[] { 206970 }, new[] { 0 }, 14, 538767, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Tombstone = new Spell("Tombstone", ClassType.DeathKnight, ClassSpec.Blood, new[] { 219809 }, new[] { 0 }, 3, 132151, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell VampiricBlood = new Spell("Vampiric Blood", ClassType.DeathKnight, ClassSpec.Blood, new[] { 55233, 317133 }, new[] { 29, 56 }, 0, 136168, new double[] { 0 }, new double[] { 10 }, false, 0, new[] { "Class - Death Knight - Vampiric Blood" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)422), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingPct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseHealth) });
        public Spell VeteranOfTheThirdWar = new Spell("Veteran of the Third War", ClassType.DeathKnight, ClassSpec.Blood, new[] { 316714 }, new[] { 49 }, 0, 136005, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Voracious = new Spell("Voracious", ClassType.DeathKnight, ClassSpec.Blood, new[] { 273953 }, new[] { 0 }, 16, 1035055, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell WraithWalk = new Spell("Wraith Walk", ClassType.DeathKnight, ClassSpec.Blood, new[] { 212552 }, new[] { 25 }, 15, 1100041, new double[] { 0 }, new double[] { 4 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Hover), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDetectRange), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });

        public Spell BloodPlague = new Spell("Blood Plague", ClassType.DeathKnight, ClassSpec.Blood, 55078, 0, SpellType.DebuffOnTarget);
    }
}