using System;

namespace WeakAuraAutomationTool.Warcraft
{
    public static class ClassSpecExtensions
    {
        public static string ToAuraPrefix(this ClassSpec classSpec)
        {
            return classSpec switch
            {
                ClassSpec.FrostMage => "mage_frost",
                ClassSpec.HolyPaladin => "paladin_holy",
                ClassSpec.ProtectionPaladin => "paladin_protection",
                ClassSpec.Retribution => "paladin_retribution",
                ClassSpec.Arms => "warrior_arms",
                ClassSpec.Fury => "warrior_fury",
                ClassSpec.ProtectionWarrior => "warrior_protection",
                ClassSpec.Balance => "druid_balance",
                ClassSpec.Feral => "druid_feral",
                ClassSpec.Guardian => "druid_guardian",
                ClassSpec.RestorationDruid => "druid_restoration",
                ClassSpec.Blood => "deathknight_blood",
                ClassSpec.Frost => "deathknight_frost",
                ClassSpec.Unholy => "deathknight_unholy",
                ClassSpec.BeastMastery => "hunter_beastmastery",
                ClassSpec.Marksmanship => "hunter_marksmanship",
                ClassSpec.Survival => "hunter_survival",
                ClassSpec.Discipline => "priest_discipline",
                ClassSpec.HolyPriest => "priest_holy",
                ClassSpec.Shadow => "priest_shadow",
                ClassSpec.Assassination => "rogue_assassination",
                ClassSpec.Outlaw => "rogue_outlaw",
                ClassSpec.Subtlety => "rogue_subtlety",
                ClassSpec.Elemental => "shaman_elemental",
                ClassSpec.Enhancement => "shaman_enhancement",
                ClassSpec.RestorationShaman => "shaman_restoration",
                ClassSpec.Affliction => "warlock_affliction",
                ClassSpec.Demonology => "warlock_demonology",
                ClassSpec.Destruction => "warlock_destruction",
                ClassSpec.Brewmaster => "monk_brewmaster",
                ClassSpec.Windwalker => "monk_windwalker",
                ClassSpec.Mistweaver => "monk_mistweaver",
                ClassSpec.Havoc => "demonhunter_havoc",
                ClassSpec.Vengeance => "demonhunter_vengeance",
                _ => throw new ArgumentOutOfRangeException(nameof(classSpec), classSpec, null)
            };
        }
    }

    public enum ClassSpec
    {
        Base = 0,

        // ClassSets
        Mage = 3,
        Warrior = 4,
        Warlock = 5,
        Priest = 6,
        Druid = 7,
        Rogue = 8,
        Hunter = 9,
        Paladin = 10,
        Shaman = 11,
        DeathKnight = 15,
        Monk = 53,
        // Maybe just generic special ability?
        WarlockDemon = 57,
        DemonHunter = 107,

        // Specializations
        Arcane = 62,
        Fire = 63,
        FrostMage = 64,
        HolyPaladin = 65,
        ProtectionPaladin = 66,
        Retribution = 70,
        Arms = 71,
        Fury = 72,
        ProtectionWarrior = 73,
        // Ferocity = 74,
        // Cunning = 79,
        // Tenacity = 81,
        Balance = 102,
        Feral = 103,
        Guardian = 104,
        RestorationDruid = 105,
        Blood = 250,
        Frost = 251,
        Unholy = 252,
        BeastMastery = 253,
        Marksmanship = 254,
        Survival = 255,
        Discipline = 256,
        HolyPriest = 257,
        Shadow = 258,
        Assassination = 259,
        Outlaw = 260,
        Subtlety = 261,
        Elemental = 262,
        Enhancement = 263,
        RestorationShaman = 264,
        Affliction = 265,
        Demonology = 266,
        Destruction = 267,
        Brewmaster = 268,
        Windwalker = 269,
        Mistweaver = 270,
        // Ferocity = 535,
        // Cunning = 536,
        // Tenacity = 537,
        Havoc = 577,
        Vengeance = 581,
        InitialWarrior = 1446,
        InitialPaladin = 1451,
        InitialHunter = 1448,
        InitialRogue = 1453,
        InitialPriest = 1452,
        InitialDeathKnight = 1455,
        InitialShaman = 1444,
        InitialMage = 1449,
        InitialWarlock = 1454,
        InitialMonk = 1450,
        InitialDruid = 1447,
        InitialDemonHunter = 1456
    }
}