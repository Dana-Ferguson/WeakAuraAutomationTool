﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Shadow : Priest
    {
        public Spell AncientMadness = new Spell("Ancient Madness", ClassType.Priest, ClassSpec.Shadow, new[] { 341240 }, new[] { 1 }, 19, 1386549, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell AuspiciousSpirits = new Spell("Auspicious Spirits", ClassType.Priest, ClassSpec.Shadow, new[] { 155271 }, new[] { 0 }, 13, 1022944, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Damnation = new Spell("Damnation", ClassType.Priest, ClassSpec.Shadow, new[] { 341374 }, new[] { 0 }, 16, 236295, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell DarkThoughts = new Spell("Dark Thoughts", ClassType.Priest, ClassSpec.Shadow, new[] { 341205 }, new[] { 41 }, 0, 3718862, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DeathAndMadness = new Spell("Death and Madness", ClassType.Priest, ClassSpec.Shadow, new[] { 321291 }, new[] { 0 }, 2, 136149, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DevouringPlague = new Spell("Devouring Plague", ClassType.Priest, ClassSpec.Shadow, new[] { 335467 }, new[] { 10 }, 0, 252997, new double[] { 0 }, new double[] { 6 }, false, 40, new[] { "Devouring Plague" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicLeech), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.HealthLeech, EffectAuraType.None) });
        public Spell Dispersion = new Spell("Dispersion", ClassType.Priest, ClassSpec.Shadow, new[] { 47585, 322108 }, new[] { 16, 44 }, 0, 237563, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPacifySilence), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ObsModHealth) });
        public Spell FortressOfTheMind = new Spell("Fortress of the Mind", ClassType.Priest, ClassSpec.Shadow, new[] { 193195 }, new[] { 0 }, 1, 236225, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Hallucinations = new Spell("Hallucinations", ClassType.Priest, ClassSpec.Shadow, new[] { 280752 }, new[] { 43 }, 0, 136176, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell HungeringVoid = new Spell("Hungering Void", ClassType.Priest, ClassSpec.Shadow, new[] { 345218 }, new[] { 0 }, 20, 1035040, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Intangibility = new Spell("Intangibility", ClassType.Priest, ClassSpec.Shadow, new[] { 288733 }, new[] { 0 }, 6, 237563, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell LastWord = new Spell("Last Word", ClassType.Priest, ClassSpec.Shadow, new[] { 263716 }, new[] { 0 }, 10, 458230, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell MasteryShadowWeaving = new Spell("Mastery: Shadow Weaving", ClassType.Priest, ClassSpec.Shadow, new[] { 343690 }, new[] { 10 }, 0, 136195, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell MindBlast = new Spell("Mind Blast", ClassType.Priest, ClassSpec.Shadow, new[] { 319899 }, new[] { 13 }, 0, 136224, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMod) });
        public Spell MindBomb = new Spell("Mind Bomb", ClassType.Priest, ClassSpec.Shadow, new[] { 205369 }, new[] { 1 }, 11, 136173, new double[] { 0 }, new double[] { 2 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell MindFlay = new Spell("Mind Flay", ClassType.Priest, ClassSpec.Shadow, new[] { 15407 }, new[] { 11 }, 0, 136208, new double[] { 0 }, new double[] { 4.5 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicEnergize), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MindSear = new Spell("Mind Sear", ClassType.Priest, ClassSpec.Shadow, new[] { 48045 }, new[] { 26 }, 0, 237565, new double[] { 0 }, new double[] { 4.5 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Mindbender = new Spell("Mindbender", ClassType.Priest, ClassSpec.Shadow, new[] { 200174 }, new[] { 1 }, 17, 136214, new double[] { 60 }, new double[] { 15 }, false, 40, new[] { "Priest - Shadowfiend" }, new[] { new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Misery = new Spell("Misery", ClassType.Priest, ClassSpec.Shadow, new[] { 238558 }, new[] { 0 }, 8, 132291, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell PsychicHorror = new Spell("Psychic Horror", ClassType.Priest, ClassSpec.Shadow, new[] { 64044 }, new[] { 0 }, 12, 237568, new double[] { 0 }, new double[] { 4 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun) });
        public Spell PurifyDisease = new Spell("Purify Disease", ClassType.Priest, ClassSpec.Shadow, new[] { 213634 }, new[] { 18 }, 0, 135935, new double[] { 8 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell Sanlayn = new Spell("San'layn", ClassType.Priest, ClassSpec.Shadow, new[] { 199855 }, new[] { 0 }, 5, 343633, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell ShadowCrash = new Spell("Shadow Crash", ClassType.Priest, ClassSpec.Shadow, new[] { 205385 }, new[] { 0 }, 15, 136201, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerMissile, EffectAuraType.None) });
        public Spell ShadowMend = new Spell("Shadow Mend", ClassType.Priest, ClassSpec.Shadow, new[] { 186263 }, new[] { 19 }, 0, 136202, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None) });
        public Spell Shadowfiend = new Spell("Shadowfiend", ClassType.Priest, ClassSpec.Shadow, new[] { 34433, 319904 }, new[] { 20, 32 }, 0, 136199, new double[] { 180 }, new double[] { 15 }, false, 40, new[] { "Priest - Shadowfiend" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Shadowform = new Spell("Shadowform", ClassType.Priest, ClassSpec.Shadow, new[] { 232698 }, new[] { 12 }, 0, 136200, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell ShadowyApparitions = new Spell("Shadowy Apparitions", ClassType.Priest, ClassSpec.Shadow, new[] { 341491 }, new[] { 29 }, 0, 458229, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Silence = new Spell("Silence", ClassType.Priest, ClassSpec.Shadow, new[] { 15487, 342991 }, new[] { 29, 56 }, 0, 458230, new double[] { 0 }, new double[] { 4 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSilence) });
        public Spell SurrenderToMadness = new Spell("Surrender to Madness", ClassType.Priest, ClassSpec.Shadow, new[] { 319952 }, new[] { 0 }, 21, 254090, new double[] { 0 }, new double[] { 25 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.CastWhileWalking), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRuneRegenSpeed), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell TwistOfFate = new Spell("Twist of Fate", ClassType.Priest, ClassSpec.Shadow, new[] { 109142 }, new[] { 0 }, 7, 237566, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell UnfurlingDarkness = new Spell("Unfurling Darkness", ClassType.Priest, ClassSpec.Shadow, new[] { 341273 }, new[] { 1 }, 3, 1386547, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell VampiricEmbrace = new Spell("Vampiric Embrace", ClassType.Priest, ClassSpec.Shadow, new[] { 15286, 322110 }, new[] { 25, 47 }, 0, 136230, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell VampiricTouch = new Spell("Vampiric Touch", ClassType.Priest, ClassSpec.Shadow, new[] { 34914, 322116 }, new[] { 15, 48 }, 0, 135978, new double[] { 0 }, new double[] { 21 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicLeech), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell VoidBolt = new Spell("Void Bolt", ClassType.Priest, ClassSpec.Shadow, new[] { 228266, 231688 }, new[] { 23, 37 }, 0, 1035040, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell VoidEruption = new Spell("Void Eruption", ClassType.Priest, ClassSpec.Shadow, new[] { 228260, 319908 }, new[] { 23, 39 }, 0, 1386548, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell VoidTorrent = new Spell("Void Torrent", ClassType.Priest, ClassSpec.Shadow, new[] { 263165 }, new[] { 0 }, 18, 1386551, new double[] { 0 }, new double[] { 3 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Voidform = new Spell("Voidform", ClassType.Priest, ClassSpec.Shadow, new[] { 185916, 228264 }, new[] { 10, 23 }, 0, 1386550, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerSpellCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcOnPowerAmount) });
    }
}