﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class BeastMastery : Hunter
    {
        public Spell AMurderOfCrows = new Spell("A Murder of Crows", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 131894 }, new[] { 1 }, 12, 645217, new double[] { 0 }, new double[] { 15 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell AnimalCompanion = new Spell("Animal Companion", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 267116 }, new[] { 0 }, 2, 461112, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)429), new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)493) });
        public Spell BarbedShot = new Spell("Barbed Shot", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 217200 }, new[] { 12 }, 0, 2058007, new double[] { 0 }, new double[] { 8 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Barrage = new Spell("Barrage", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 120360 }, new[] { 1 }, 17, 236201, new double[] { 0 }, new double[] { 3 }, false, 40, new[] { "Direct Damage (AE-Chain) - Ability" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell BeastCleave = new Spell("Beast Cleave", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 115939 }, new[] { 32 }, 0, 461121, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BestialWrath = new Spell("Bestial Wrath", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 231548 }, new[] { 34 }, 0, 132127, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Bloodshed = new Spell("Bloodshed", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 321530 }, new[] { 10 }, 21, 132139, new double[] { 0 }, new double[] { }, false, 50, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell ChimaeraShot = new Spell("Chimaera Shot", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 53209 }, new[] { 0 }, 6, 236176, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell CobraShot = new Spell("Cobra Shot", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 193455, 262838 }, new[] { 14, 49 }, 0, 461114, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell ConcussiveShot = new Spell("Concussive Shot", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 5116, 321023 }, new[] { 13 }, 0, 135860, new double[] { 0 }, new double[] { 6 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed) });
        public Spell CounterShot = new Spell("Counter Shot", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 147362 }, new[] { 18 }, 0, 249170, new double[] { 0 }, new double[] { 3 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.InterruptCast, EffectAuraType.None) });
        public Spell DireBeast = new Spell("Dire Beast", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 120679 }, new[] { 0 }, 3, 236186, new double[] { 0 }, new double[] { 8 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Exhilaration = new Spell("Exhilaration", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 231546 }, new[] { 44 }, 0, 461117, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ExoticBeasts = new Spell("Exotic Beasts", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 53270 }, new[] { 39 }, 0, 236175, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AllowTamePetType) });
        public Spell KillCommand = new Spell("Kill Command", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 34026 }, new[] { 10 }, 0, 132176, new double[] { 0 }, new double[] { }, false, 50, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell KillerCobra = new Spell("Killer Cobra", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 199532 }, new[] { 0 }, 20, 132211, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell KillerInstinct = new Spell("Killer Instinct", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 273887 }, new[] { 0 }, 1, 132176, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell KindredSpirits = new Spell("Kindred Spirits", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 56315 }, new[] { 28 }, 0, 236202, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseEnergy) });
        public Spell MasteryMasterOfBeasts = new Spell("Mastery: Master of Beasts", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 76657 }, new[] { 10 }, 0, 132164, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)429), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Multi_Shot = new Spell("Multi-Shot", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 2643 }, new[] { 23 }, 0, 132330, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell OneWithThePack = new Spell("One with the Pack", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 199528 }, new[] { 0 }, 5, 666952, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell PackTactics = new Spell("Pack Tactics", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 321014 }, new[] { 11 }, 0, 236184, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPowerRegenPercent) });
        public Spell ScentOfBlood = new Spell("Scent of Blood", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 193532 }, new[] { 0 }, 4, 461121, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SpittingCobra = new Spell("Spitting Cobra", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 257891 }, new[] { 0 }, 10, 135461, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Stampede = new Spell("Stampede", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 201430 }, new[] { 0 }, 18, 461112, new double[] { 0 }, new double[] { 12 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell Stomp = new Spell("Stomp", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 199530 }, new[] { 0 }, 16, 458976, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ThrillOfTheHunt = new Spell("Thrill of the Hunt", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 257944 }, new[] { 0 }, 11, 132216, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell WildCall = new Spell("Wild Call", ClassType.Hunter, ClassSpec.BeastMastery, new[] { 185789 }, new[] { 24 }, 0, 236189, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
    }
}