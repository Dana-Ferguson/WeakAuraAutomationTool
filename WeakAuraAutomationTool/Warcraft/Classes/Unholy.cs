﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Unholy : DeathKnight
    {
        public Spell AllWillServe = new Spell("All Will Serve", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 194916 }, new[] { 0 }, 2, 132151, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Apocalypse = new Spell("Apocalypse", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 275699, 316961, 343755 }, new[] { 19, 49, 58 }, 0, 1392565, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell ArmyOfTheDamned = new Spell("Army of the Damned", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 276837 }, new[] { 1 }, 19, 1392565, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ArmyOfTheDead = new Spell("Army of the Dead", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 42650 }, new[] { 44 }, 0, 237511, new double[] { 480 }, new double[] { 4 }, false, 0, new[] { "Death Knight - Unholy - Army of the Dead" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell Asphyxiate = new Spell("Asphyxiate", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 108194 }, new[] { 0 }, 9, 538558, new double[] { 0 }, new double[] { 4 }, false, 20, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Strangulate) });
        public Spell BurstingSores = new Spell("Bursting Sores", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207264 }, new[] { 0 }, 4, 236158, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell ClawingShadows = new Spell("Clawing Shadows", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207311 }, new[] { 0 }, 3, 615099, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell DarkSuccor = new Spell("Dark Succor", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 178819 }, new[] { 18 }, 0, 878217, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell DarkTransformation = new Spell("Dark Transformation", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 325554 }, new[] { 52 }, 0, 342913, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell DeathAndDecay = new Spell("Death and Decay", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 316916 }, new[] { 43 }, 0, 136144, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell DeathCoil = new Spell("Death Coil", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 316941 }, new[] { 41 }, 0, 136145, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell DeathStrike = new Spell("Death Strike", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 278223 }, new[] { 28 }, 0, 237517, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell DeathsReach = new Spell("Death's Reach", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 276079 }, new[] { 0 }, 8, 237532, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Defile = new Spell("Defile", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 152280 }, new[] { 0 }, 18, 1029008, new double[] { 20 }, new double[] { 10 }, false, 30, new[] { "Class - Death Knight - Death and Decay" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell EbonFever = new Spell("Ebon Fever", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207269 }, new[] { 0 }, 5, 136134, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Epidemic = new Spell("Epidemic", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207317 }, new[] { 34 }, 0, 136066, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell FesteringStrike = new Spell("Festering Strike", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 85948, 316867 }, new[] { 10, 24 }, 0, 879926, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FesteringWound = new Spell("Festering Wound", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 197147 }, new[] { 1 }, 0, 1129420, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell GripOfTheDead = new Spell("Grip of the Dead", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 273952 }, new[] { 0 }, 7, 132102, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell HarbingerOfDoom = new Spell("Harbinger of Doom", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 276023 }, new[] { 0 }, 11, 136181, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell InfectedClaws = new Spell("Infected Claws", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207272 }, new[] { 0 }, 1, 237535, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell MasteryDreadblade = new Spell("Mastery: Dreadblade", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 77515 }, new[] { 10 }, 0, 236851, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)429), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Outbreak = new Spell("Outbreak", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 77575 }, new[] { 17 }, 0, 348565, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Pestilence = new Spell("Pestilence", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 277234 }, new[] { 0 }, 16, 1029009, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell PestilentPustules = new Spell("Pestilent Pustules", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 194917 }, new[] { 0 }, 10, 1129420, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell RaiseDead = new Spell("Raise Dead", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 46584 }, new[] { 29 }, 0, 1100170, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell RunicCorruption = new Spell("Runic Corruption", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 51462 }, new[] { 21 }, 0, 252272, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ScourgeStrike = new Spell("Scourge Strike", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 55090, 317234 }, new[] { 11, 56 }, 0, 237530, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell SoulReaper = new Spell("Soul Reaper", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 343294 }, new[] { 0 }, 12, 636333, new double[] { 0 }, new double[] { 5 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell SpellEater = new Spell("Spell Eater", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207321 }, new[] { 0 }, 13, 132095, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell SuddenDoom = new Spell("Sudden Doom", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 49530 }, new[] { 23 }, 0, 136181, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell SummonGargoyle = new Spell("Summon Gargoyle", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 49206 }, new[] { 34 }, 20, 458967, new double[] { 180 }, new double[] { 35 }, false, 30, new[] { "Class - Death Knight - Summon Gargoyle/Dark Arbiter" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell UnholyAssault = new Spell("Unholy Assault", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 207289 }, new[] { 0 }, 21, 136224, new double[] { 0 }, new double[] { 12 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell UnholyBlight = new Spell("Unholy Blight", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 115989 }, new[] { 1 }, 6, 136132, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell UnholyPact = new Spell("Unholy Pact", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 319230 }, new[] { 0 }, 17, 237557, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackPowerOfArmor), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell WraithWalk = new Spell("Wraith Walk", ClassType.DeathKnight, ClassSpec.Unholy, new[] { 212552 }, new[] { 25 }, 14, 1100041, new double[] { 0 }, new double[] { 4 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Hover), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDetectRange), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
    }
}