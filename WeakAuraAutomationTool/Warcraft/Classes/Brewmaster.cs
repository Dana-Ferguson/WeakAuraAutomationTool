﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Brewmaster : Monk
    {
        public Spell BlackOxBrew = new Spell("Black Ox Brew", ClassType.Monk, ClassSpec.Brewmaster, new[] { 115399 }, new[] { 1 }, 9, 629483, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell BlackoutCombo = new Spell("Blackout Combo", ClassType.Monk, ClassSpec.Brewmaster, new[] { 196736 }, new[] { 0 }, 21, 574568, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell BlackoutKick = new Spell("Blackout Kick", ClassType.Monk, ClassSpec.Brewmaster, new[] { 205523 }, new[] { 10 }, 0, 574575, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BobAndWeave = new Spell("Bob and Weave", ClassType.Monk, ClassSpec.Brewmaster, new[] { 280515 }, new[] { 0 }, 13, 132096, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BreathOfFire = new Spell("Breath of Fire", ClassType.Monk, ClassSpec.Brewmaster, new[] { 115181 }, new[] { 29 }, 0, 615339, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BrewmastersBalance = new Spell("Brewmaster's Balance", ClassType.Monk, ClassSpec.Brewmaster, new[] { 245013 }, new[] { 19 }, 0, 574577, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBaseResistancePct) });
        public Spell CelestialBrew = new Spell("Celestial Brew", ClassType.Monk, ClassSpec.Brewmaster, new[] { 322507, 322510 }, new[] { 27, 41 }, 0, 1360979, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingReceived), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell CelestialFlames = new Spell("Celestial Flames", ClassType.Monk, ClassSpec.Brewmaster, new[] { 325177 }, new[] { 0 }, 20, 463567, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell CelestialFortune = new Spell("Celestial Fortune", ClassType.Monk, ClassSpec.Brewmaster, new[] { 216519 }, new[] { 46 }, 0, 656166, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)422), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Clash = new Spell("Clash", ClassType.Monk, ClassSpec.Brewmaster, new[] { 324312 }, new[] { 54 }, 0, 628134, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell ExpelHarm = new Spell("Expel Harm", ClassType.Monk, ClassSpec.Brewmaster, new[] { 322102 }, new[] { 43 }, 0, 627486, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell ExplodingKeg = new Spell("Exploding Keg", ClassType.Monk, ClassSpec.Brewmaster, new[] { 325153 }, new[] { 0 }, 18, 644378, new double[] { 0 }, new double[] { 3 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAutoattackDamage), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHitChance), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FortifyingBrew = new Spell("Fortifying Brew", ClassType.Monk, ClassSpec.Brewmaster, new[] { 322960 }, new[] { 48 }, 0, 615341, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell GiftOfTheOx = new Spell("Gift of the Ox", ClassType.Monk, ClassSpec.Brewmaster, new[] { 124502 }, new[] { 38 }, 0, 236155, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell HealingElixir = new Spell("Healing Elixir", ClassType.Monk, ClassSpec.Brewmaster, new[] { 122281 }, new[] { 1 }, 14, 608939, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell HighTolerance = new Spell("High Tolerance", ClassType.Monk, ClassSpec.Brewmaster, new[] { 196737 }, new[] { 0 }, 19, 627605, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell InvokeNiuzaoTheBlackOx = new Spell("Invoke Niuzao, the Black Ox", ClassType.Monk, ClassSpec.Brewmaster, new[] { 132578, 322740 }, new[] { 42, 58 }, 0, 608951, new double[] { 0 }, new double[] { 25 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell KegSmash = new Spell("Keg Smash", ClassType.Monk, ClassSpec.Brewmaster, new[] { 121253 }, new[] { 21 }, 0, 594274, new double[] { 0 }, new double[] { 15 }, false, 15, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell LeatherSpecialization = new Spell("Leather Specialization", ClassType.Monk, ClassSpec.Brewmaster, new[] { 120225 }, new[] { 27 }, 0, 132721, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell LightBrewing = new Spell("Light Brewing", ClassType.Monk, ClassSpec.Brewmaster, new[] { 325093 }, new[] { 0 }, 7, 623777, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMultiplier) });
        public Spell MasteryElusiveBrawler = new Spell("Mastery: Elusive Brawler", ClassType.Monk, ClassSpec.Brewmaster, new[] { 117906 }, new[] { 10 }, 0, 611417, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackPowerPct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell PurifyingBrew = new Spell("Purifying Brew", ClassType.Monk, ClassSpec.Brewmaster, new[] { 119582, 343743 }, new[] { 23, 47 }, 0, 133701, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell RushingJadeWind = new Spell("Rushing Jade Wind", ClassType.Monk, ClassSpec.Brewmaster, new[] { 116847 }, new[] { 1 }, 17, 606549, new double[] { 0 }, new double[] { 6 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Shuffle = new Spell("Shuffle", ClassType.Monk, ClassSpec.Brewmaster, new[] { 322120 }, new[] { 17 }, 0, 642416, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell SpearHandStrike = new Spell("Spear Hand Strike", ClassType.Monk, ClassSpec.Brewmaster, new[] { 116705 }, new[] { 18 }, 0, 608940, new double[] { 0 }, new double[] { 4 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.InterruptCast, EffectAuraType.None) });
        public Spell SpecialDelivery = new Spell("Special Delivery", ClassType.Monk, ClassSpec.Brewmaster, new[] { 196730 }, new[] { 0 }, 16, 594274, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell SpinningCraneKick = new Spell("Spinning Crane Kick", ClassType.Monk, ClassSpec.Brewmaster, new[] { 322700 }, new[] { 33 }, 0, 606543, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Spitfire = new Spell("Spitfire", ClassType.Monk, ClassSpec.Brewmaster, new[] { 242580 }, new[] { 0 }, 8, 615339, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Stagger = new Spell("Stagger", ClassType.Monk, ClassSpec.Brewmaster, new[] { 115069, 322522 }, new[] { 12, 26 }, 0, 611419, new double[] { 0 }, new double[] { }, false, 0, new[] { "Combat States" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell TouchOfDeath = new Spell("Touch of Death", ClassType.Monk, ClassSpec.Brewmaster, new[] { 325095 }, new[] { 52 }, 0, 606552, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Vivify = new Spell("Vivify", ClassType.Monk, ClassSpec.Brewmaster, new[] { 231602 }, new[] { 37 }, 0, 1360980, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell ZenMeditation = new Spell("Zen Meditation", ClassType.Monk, ClassSpec.Brewmaster, new[] { 115176, 328682 }, new[] { 34, 56 }, 0, 642417, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.CastWhileWalking), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Hover), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken) });
    }
}