using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Trigger
    {
        [LuaField("auranames")] public List<string> AuraNames;
        [LuaField("auraspellids")] public List<string> AuraSpellIds;
        [LuaField("debuffType")] public string DebuffType;
        [LuaField("duration")] public string Duration;
        [LuaField("event")] public string Event;
        [LuaField("genericShowOn")] public string GenericShowOn;
        [LuaField("itemName")] public long ItemName;
        [LuaField("itemSlot")] public double ItemSlot;
        [LuaField("matchesShowOn")] public string MatchesShowOn;
        [LuaField("names")] public List<string> Names;
        [LuaField("ownOnly")] public bool OwnOnly;
        // todo: this can be a string or number (SpellId)
        [LuaField("realSpellName")] public string RealSpellName;
        [LuaField("rem")] public string Rem;
        [LuaField("remOperator")] public string RemOperator;
        [LuaField("spellIds")] public List<long> SpellIds;
        [LuaField("spellName")] public long SpellName;
        [LuaField("subeventPrefix")] public string SubeventPrefix;
        [LuaField("subeventSuffix")] public string SubeventSuffix;
        [LuaField("talent")] public Talent Talent;
        [LuaField("track")] public string Track;
        [LuaField("type")] public string Type;
        [LuaField("unevent")] public string Unevent;
        [LuaField("unit")] public string Unit;
        [LuaField("use_absorbMode")] public bool UseAbsorbMode;
        [LuaField("use_genericShowOn")] public bool UseGenericShowOn;
        [LuaField("use_inverse")] public bool UseInverse;
        [LuaField("use_itemName")] public bool UseItemName;
        [LuaField("use_itemSlot")] public bool UseItemSlot;
        [LuaField("use_showIncomingHeal")] public bool UseShowIncomingHeal;
        [LuaField("use_spellName")] public bool UseSpellName;
        [LuaField("use_talent")] public bool UseTalent;
        [LuaField("use_targetRequired")] public bool UseTargetRequired;
        [LuaField("use_track")] public bool UseTrack;
        [LuaField("use_unit")] public bool UseUnit;
        [LuaField("useName")] public bool UseName;
        [LuaField("useRem")] public bool UseRem;
    }
}