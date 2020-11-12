﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Havoc : DemonHunter
    {
        public Spell BladeDance = new Spell("Blade Dance", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 188499, 320402 }, new[] { 12, 22 }, 0, 1305149, new double[] { 15 }, new double[] { 1 }, false, 0, new[] { "Demon Hunter - Blade Dance" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SuppressTransforms), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell BlindFury = new Spell("Blind Fury", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 203550 }, new[] { 0 }, 1, 1117876, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Blur = new Spell("Blur", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 198589, 320407 }, new[] { 21, 33 }, 0, 1305150, new double[] { 60 }, new double[] { }, false, 0, new[] { "Demon Hunter - Blur" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell BurningHatred = new Spell("Burning Hatred", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320374 }, new[] { 0 }, 5, 1344649, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ChaosNova = new Spell("Chaos Nova", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320412 }, new[] { 38 }, 0, 135795, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ChaosStrike = new Spell("Chaos Strike", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 197125, 320413, 343206 }, new[] { 1, 14, 56 }, 0, 1305152, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell CycleOfHatred = new Spell("Cycle of Hatred", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 258887 }, new[] { 0 }, 13, 1035055, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Darkness = new Spell("Darkness", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 196718, 320420 }, new[] { 39, 47 }, 0, 1305154, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None) });
        public Spell DemonBlades = new Spell("Demon Blades", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 203555 }, new[] { 0 }, 6, 237507, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Demonic = new Spell("Demonic", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 213410 }, new[] { 0 }, 19, 237558, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DemonicAppetite = new Spell("Demonic Appetite", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 206478 }, new[] { 0 }, 2, 2120320, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell DemonicWards = new Spell("Demonic Wards", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320383 }, new[] { 28 }, 0, 1266395, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell DesperateInstincts = new Spell("Desperate Instincts", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 205411 }, new[] { 0 }, 11, 136171, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.TriggerSpellOnHealthBelowPct) });
        public Spell EssenceBreak = new Spell("Essence Break", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 258860 }, new[] { 0 }, 15, 136189, new double[] { 0 }, new double[] { }, false, 10, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell EyeBeam = new Spell("Eye Beam", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 198013, 320415, 343311 }, new[] { 11, 23, 58 }, 0, 1305156, new double[] { 30 }, new double[] { 2 }, false, 20, new[] { "Demon Hunter - Eye Beam" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPowerRegen), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell FelBarrage = new Spell("Fel Barrage", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 258925 }, new[] { 0 }, 21, 2065580, new double[] { 0 }, new double[] { 3 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Hover), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell FelEruption = new Spell("Fel Eruption", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 211881 }, new[] { 0 }, 18, 1118739, new double[] { 0 }, new double[] { 4 }, false, 20, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FelRush = new Spell("Fel Rush", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320416, 343017 }, new[] { 28, 52 }, 0, 1247261, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges) });
        public Spell Felblade = new Spell("Felblade", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 232893 }, new[] { 0 }, 3, 1344646, new double[] { 0 }, new double[] { }, false, 15, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell FirstBlood = new Spell("First Blood", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 206416 }, new[] { 0 }, 14, 538039, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell GlaiveTempest = new Spell("Glaive Tempest", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 342817 }, new[] { 0 }, 9, 1455916, new double[] { 20 }, new double[] { 3 }, false, 0, new[] { "Demon Hunter - Glaive Tempest" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None) });
        public Spell ImmolationAura = new Spell("Immolation Aura", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320377 }, new[] { 27 }, 0, 1344649, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell InsatiableHunger = new Spell("Insatiable Hunger", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 258876 }, new[] { 0 }, 4, 236276, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MasterOfTheGlaive = new Spell("Master of the Glaive", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 203556 }, new[] { 0 }, 17, 1278164, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell MasteryDemonicPresence = new Spell("Mastery: Demonic Presence", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 185164, 320654 }, new[] { 10, 44 }, 0, 236293, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedAlways) });
        public Spell Metamorphosis = new Spell("Metamorphosis", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320421, 320422, 320645 }, new[] { 20, 48, 54 }, 0, 1247262, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Momentum = new Spell("Momentum", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 206476 }, new[] { 0 }, 20, 1029722, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Netherwalk = new Spell("Netherwalk", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 196555 }, new[] { 0 }, 12, 463284, new double[] { 0 }, new double[] { 5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.DamageImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPacify), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedNotStack) });
        public Spell SoulRending = new Spell("Soul Rending", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 204909 }, new[] { 0 }, 10, 1354410, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModLeech) });
        public Spell TrailOfRuin = new Spell("Trail of Ruin", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 258881 }, new[] { 0 }, 7, 1305149, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell UnboundChaos = new Spell("Unbound Chaos", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 347461 }, new[] { 0 }, 8, 1392567, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell UnleashedPower = new Spell("Unleashed Power", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 206477 }, new[] { 0 }, 16, 1305151, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell UnrestrainedFury = new Spell("Unrestrained Fury", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320770, 343006 }, new[] { 32, 43 }, 0, 132346, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxPower) });
        public Spell VengefulRetreat = new Spell("Vengeful Retreat", ClassType.DemonHunter, ClassSpec.Havoc, new[] { 320635 }, new[] { 41 }, 0, 1348401, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });

        public Spell FuriousGaze = new Spell("FuriousGaze", ClassType.DemonHunter, ClassSpec.Havoc, 343311, 0, SpellType.BuffOnPlayer);
    }
}