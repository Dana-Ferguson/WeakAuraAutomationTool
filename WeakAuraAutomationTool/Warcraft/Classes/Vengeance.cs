﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Vengeance : DemonHunter
    {
        public Spell AbyssalStrike = new Spell("Abyssal Strike", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207550 }, new[] { 0 }, 1, 615096, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ChargeRecoveryMod) });
        public Spell AgonizingFlames = new Spell("Agonizing Flames", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207548 }, new[] { 0 }, 2, 574795, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell BulkExtraction = new Spell("Bulk Extraction", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 320341 }, new[] { 0 }, 21, 136194, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell BurningAlive = new Spell("Burning Alive", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207739 }, new[] { 0 }, 6, 135791, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ChaosBrand = new Spell("Chaos Brand", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 281242 }, new[] { 49 }, 0, 1450142, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell CharredFlesh = new Spell("Charred Flesh", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 336639 }, new[] { 0 }, 8, 236290, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ConcentratedSigils = new Spell("Concentrated Sigils", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207666 }, new[] { 0 }, 13, 1121022, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell DemonSpikes = new Spell("Demon Spikes", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 203720, 321028 }, new[] { 1, 41 }, 0, 1344645, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Demonic = new Spell("Demonic", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 321453 }, new[] { 0 }, 17, 237558, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell DemonicWards = new Spell("Demonic Wards", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 203513, 320381, 320382 }, new[] { 13, 28, 43 }, 0, 1266395, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken) });
        public Spell Fallout = new Spell("Fallout", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 227174 }, new[] { 0 }, 5, 840409, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FeastOfSouls = new Spell("Feast of Souls", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207697 }, new[] { 0 }, 4, 136211, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FeedTheDemon = new Spell("Feed the Demon", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 218612 }, new[] { 0 }, 11, 1378283, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FelDevastation = new Spell("Fel Devastation", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 212084, 320639 }, new[] { 11, 23 }, 0, 1450143, new double[] { 0 }, new double[] { 2 }, false, 20, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell Felblade = new Spell("Felblade", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 232893 }, new[] { 0 }, 3, 1344646, new double[] { 0 }, new double[] { }, false, 15, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell FieryBrand = new Spell("Fiery Brand", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 204021, 320962, 343010 }, new[] { 1, 38, 54 }, 0, 1344647, new double[] { 1 }, new double[] { }, false, 30, new[] { "Demon Hunter - Brands" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Fracture = new Spell("Fracture", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 263642 }, new[] { 0 }, 12, 1388065, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell ImmolationAura = new Spell("Immolation Aura", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 320378 }, new[] { 27 }, 0, 1344649, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell InfernalArmor = new Spell("Infernal Armor", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 320331 }, new[] { 0 }, 7, 1344649, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell InfernalStrike = new Spell("Infernal Strike", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 320791, 343016 }, new[] { 28, 52 }, 0, 1344650, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMaxCharges) });
        public Spell LastResort = new Spell("Last Resort", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 209258 }, new[] { 0 }, 19, 1348655, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHaste), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MasteryFelBlood = new Spell("Mastery: Fel Blood", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 203747, 321299 }, new[] { 10, 44 }, 0, 576311, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackPowerPct) });
        public Spell Metamorphosis = new Spell("Metamorphosis", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 321067, 321068 }, new[] { 20, 48 }, 0, 1247262, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell QuickenedSigils = new Spell("Quickened Sigils", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 209281 }, new[] { 0 }, 14, 1450141, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell RevelInPain = new Spell("Revel in Pain", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 343014 }, new[] { 58 }, 0, 1122135, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Riposte = new Spell("Riposte", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207197 }, new[] { 29 }, 0, 135340, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ConvertCritRatingPctToParryRating) });
        public Spell RuinousBulwark = new Spell("Ruinous Bulwark", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 326853 }, new[] { 0 }, 20, 1450143, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Shear = new Spell("Shear", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 203783 }, new[] { 1 }, 0, 1344648, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell SigilOfChains = new Spell("Sigil of Chains", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 202138 }, new[] { 0 }, 15, 1418286, new double[] { 90 }, new double[] { 2 }, false, 30, new[] { "Demon Hunter - Sigil of Chains" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SigilOfFlame = new Spell("Sigil of Flame", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 204596, 320794 }, new[] { 12, 22 }, 0, 1344652, new double[] { 30 }, new double[] { 2 }, false, 30, new[] { "Demon Hunter - Sigil of Flame" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SigilOfMisery = new Spell("Sigil of Misery", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 207684, 320418 }, new[] { 21, 33 }, 0, 1418287, new double[] { 180 }, new double[] { 2 }, false, 30, new[] { "Demon Hunter - Sigil of Misery" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SigilOfSilence = new Spell("Sigil of Silence", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 202137, 320417 }, new[] { 39, 48 }, 0, 1418288, new double[] { 120 }, new double[] { 2 }, false, 30, new[] { "Demon Hunter - Sigil of Silence" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SoulBarrier = new Spell("Soul Barrier", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 263648 }, new[] { 0 }, 18, 2065625, new double[] { 0 }, new double[] { 12 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolAbsorb) });
        public Spell SoulCleave = new Spell("Soul Cleave", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 228477, 321021, 343207 }, new[] { 1, 14, 56 }, 0, 1344653, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell SoulRending = new Spell("Soul Rending", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 217996 }, new[] { 0 }, 10, 1354410, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModLeech) });
        public Spell SpiritBomb = new Spell("Spirit Bomb", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 247454 }, new[] { 0 }, 9, 1097742, new double[] { 0 }, new double[] { 1.5 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ThickSkin = new Spell("Thick Skin", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 320380 }, new[] { 1 }, 0, 895888, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerMeleeCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBaseResistancePct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModExpertise), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell ThrowGlaive = new Spell("Throw Glaive", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 204157, 320387 }, new[] { 10, 32 }, 0, 1305159, new double[] { 0 }, new double[] { }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell VoidReaver = new Spell("Void Reaver", ClassType.DemonHunter, ClassSpec.Vengeance, new[] { 268175 }, new[] { 0 }, 16, 237561, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });

        // Debuff associated with SpiritBomb
        public Spell Frailty = new Spell("Glide", ClassType.DemonHunter, ClassSpec.Vengeance, 224509, 9, SpellType.DebuffOnTarget);
    }
}