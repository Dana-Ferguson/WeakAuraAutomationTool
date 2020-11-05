using System;

namespace WeakAuraAutomationTool.Warcraft
{
    // Used for controlling what aura is generated
    [Flags]
    public enum SpellType
    {
        Cooldown = 0x1,
        DebuffOnTarget = 0x2,
        BuffOnPlayer = 0x4,
        BuffOnTarget = 0x8,
        DoT = 0x10,
        // Shadow = 0x20,
        // Arcane = 0x40,
    }
}