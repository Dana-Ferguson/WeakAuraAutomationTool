// ReSharper disable UnusedMember.Global

using System;

namespace WeakAuraAutomationTool.Warcraft.Parser.Enumerations
{
    [Flags]
    internal enum ClassMask
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 4,
        Rogue = 8,
        Priest = 16,
        DeathKnight = 32,
        Shaman = 64,
        Mage = 128,
        Warlock = 256,
        Monk = 512,
        Druid = 1024,
        DemonHunter = 2048,
    }

    [Flags]
    internal enum DifficultyFlags
    {
        Heroic = 1,
        Default = 2,
        CanSelect = 4,
        ChallengeMode = 8,
        Legacy = 32,
        DisplayHeroic = 64,
        DisplayMythic = 128,
    }
}