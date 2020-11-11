﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Enhancement : Shaman
    {
        public Spell Ascendance = new Spell("Ascendance", ClassType.Shaman, ClassSpec.Enhancement, new[] { 114051 }, new[] { 50 }, 21, 135791, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideAutoattackWithRangedSpell), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Transform), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell ChainLightning = new Spell("Chain Lightning", ClassType.Shaman, ClassSpec.Enhancement, new[] { 334308 }, new[] { 52 }, 0, 136015, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell CleanseSpirit = new Spell("Cleanse Spirit", ClassType.Shaman, ClassSpec.Enhancement, new[] { 51886 }, new[] { 18 }, 0, 236288, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell CrashLightning = new Spell("Crash Lightning", ClassType.Shaman, ClassSpec.Enhancement, new[] { 187874 }, new[] { 38 }, 0, 1370984, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell CrashingStorm = new Spell("Crashing Storm", ClassType.Shaman, ClassSpec.Enhancement, new[] { 192246 }, new[] { 0 }, 16, 136111, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DualWield = new Spell("Dual Wield", ClassType.Shaman, ClassSpec.Enhancement, new[] { 86629 }, new[] { 10 }, 0, 132147, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.DualWield, EffectAuraType.None) });
        public Spell EarthShield = new Spell("Earth Shield", ClassType.Shaman, ClassSpec.Enhancement, new[] { 974 }, new[] { 22 }, 8, 136089, new double[] { 0 }, new double[] { 600 }, false, 40, new[] { "Earth Shield" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingReceived) });
        public Spell EarthenSpike = new Spell("Earthen Spike", ClassType.Shaman, ClassSpec.Enhancement, new[] { 188089 }, new[] { 1 }, 20, 1016245, new double[] { 0 }, new double[] { 10 }, false, 10, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolMaskDamageFromCaster), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell ElementalAssault = new Spell("Elemental Assault", ClassType.Shaman, ClassSpec.Enhancement, new[] { 210853 }, new[] { 0 }, 10, 650636, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ElementalBlast = new Spell("Elemental Blast", ClassType.Shaman, ClassSpec.Enhancement, new[] { 117014 }, new[] { 0 }, 3, 651244, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell FeralLunge = new Spell("Feral Lunge", ClassType.Shaman, ClassSpec.Enhancement, new[] { 196884 }, new[] { 1 }, 14, 1027879, new double[] { 0 }, new double[] { }, false, 25, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.JumpDest, EffectAuraType.None) });
        public Spell FeralSpirit = new Spell("Feral Spirit", ClassType.Shaman, ClassSpec.Enhancement, new[] { 51533 }, new[] { 34 }, 0, 237577, new double[] { 120 }, new double[] { }, false, 30, new[] { "Enhancement Shaman - Feral Spirits" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell FireNova = new Spell("Fire Nova", ClassType.Shaman, ClassSpec.Enhancement, new[] { 333974 }, new[] { 1 }, 12, 459027, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell HotHand = new Spell("Hot Hand", ClassType.Shaman, ClassSpec.Enhancement, new[] { 201900 }, new[] { 0 }, 5, 135823, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell IceStrike = new Spell("Ice Strike", ClassType.Shaman, ClassSpec.Enhancement, new[] { 342240 }, new[] { 1 }, 6, 135845, new double[] { 0 }, new double[] { 6 }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell LavaLash = new Spell("Lava Lash", ClassType.Shaman, ClassSpec.Enhancement, new[] { 60103, 334033 }, new[] { 11, 22 }, 0, 236289, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell MaelstromWeapon = new Spell("Maelstrom Weapon", ClassType.Shaman, ClassSpec.Enhancement, new[] { 187880 }, new[] { 29 }, 0, 237584, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MasteryEnhancedElements = new Spell("Mastery: Enhanced Elements", ClassType.Shaman, ClassSpec.Enhancement, new[] { 77223 }, new[] { 10 }, 0, 136029, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell SpiritWalk = new Spell("Spirit Walk", ClassType.Shaman, ClassSpec.Enhancement, new[] { 58875 }, new[] { 44 }, 0, 132328, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "Speed" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell SpiritWolf = new Spell("Spirit Wolf", ClassType.Shaman, ClassSpec.Enhancement, new[] { 260878 }, new[] { 1 }, 7, 1033494, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell StaticCharge = new Spell("Static Charge", ClassType.Shaman, ClassSpec.Enhancement, new[] { 265046 }, new[] { 1 }, 9, 136013, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Stormbringer = new Spell("Stormbringer", ClassType.Shaman, ClassSpec.Enhancement, new[] { 201845, 319930 }, new[] { 27, 43 }, 0, 136099, new double[] { }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Stormkeeper = new Spell("Stormkeeper", ClassType.Shaman, ClassSpec.Enhancement, new[] { 320137 }, new[] { 0 }, 17, 839977, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Stormstrike = new Spell("Stormstrike", ClassType.Shaman, ClassSpec.Enhancement, new[] { 17364 }, new[] { 20 }, 0, 132314, new double[] { 7.5 }, new double[] { }, false, 5, new[] { "Class - Shaman - Stormstrike" }, new[] { new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Sundering = new Spell("Sundering", ClassType.Shaman, ClassSpec.Enhancement, new[] { 197214 }, new[] { 0 }, 18, 524794, new double[] { 0 }, new double[] { 2 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell WindfuryTotem = new Spell("Windfury Totem", ClassType.Shaman, ClassSpec.Enhancement, new[] { 8512, 343211 }, new[] { 49, 58 }, 0, 136114, new double[] { 0 }, new double[] { 120 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell WindfuryWeapon = new Spell("Windfury Weapon", ClassType.Shaman, ClassSpec.Enhancement, new[] { 33757 }, new[] { 10 }, 0, 462329, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
    }
}