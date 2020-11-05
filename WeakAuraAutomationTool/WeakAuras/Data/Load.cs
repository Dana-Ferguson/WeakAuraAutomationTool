using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Load
    {
        [LuaField("class")] public Class Class;
        [LuaField("class_and_spec")] public ClassAndSpec ClassAndSpec;
        [LuaField("itemequiped")] public long ItemEquipped;
        [LuaField("size")] public Size Size;
        [LuaField("spec")] public Spec Spec;
        [LuaField("talent")] public Talent Talent;

        //[LuaField("use_class")] public bool UseClass;

        [LuaField("use_class_and_spec")] public bool? UseClassAndSpec;
        [LuaField("use_combat")] public bool? UseCombat;

        //[LuaField("use_itemequiped")] public bool UseItemEquipped;
        //[LuaField("use_spec")] public bool UseSpec;
        //[LuaField("use_spellknown")] public bool UseSpellKnown;
        //[LuaField("use_talent")] public bool UseTalent;
    }
}