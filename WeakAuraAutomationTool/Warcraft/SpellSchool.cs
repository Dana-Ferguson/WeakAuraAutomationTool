using System;

namespace WeakAuraAutomationTool.Warcraft
{
    // https://wow.gamepedia.com/COMBAT_LOG_EVENT#Spell_School
    [Flags]
    public enum SpellSchool
    {
        Physical = 0x1,
        Holy = 0x2,
        Fire = 0x4,
        Nature = 0x8,
        Frost = 0x10,
        Shadow = 0x20,
        Arcane = 0x40,

        Holystrike = Holy | Physical,
        Flamestrike = Fire | Physical,
        // HolyFire
        Radiant = Fire | Holy,
        Stormstrike = Nature | Physical,
        Holystorm = Nature | Holy,
        Firestorm = Nature | Fire,
        Froststrike = Frost | Physical,
        Holyfrost = Frost | Holy,
        Frostfire = Frost | Fire,
        Froststorm = Frost | Nature,
        Shadowstrike = Shadow | Physical,
        // Shadowlight
        Twilight = Shadow | Holy,
        Shadowflame = Shadow | Fire,
        // Shadowstorm
        Plague = Shadow | Nature,
        Shadowfrost = Shadow | Frost,
        Spellstrike = Arcane | Physical,
        Divine = Arcane | Holy,
        Spellfire = Arcane | Fire,
        // Spellstorm
        Astral = Arcane | Nature,
        Spellfrost = Arcane | Frost,
        Spellshadow = Arcane | Shadow,

        Elemental = Frost | Nature | Fire,
        Chromatic = Arcane | Shadow | Frost | Nature | Fire,
        Magic = Arcane | Shadow | Frost | Nature | Fire | Holy,
        Chaos = Arcane | Shadow | Frost | Nature | Fire | Holy | Physical,
    }
}