using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Functions
    {
        [LuaField("custom")] public string Custom;
        [LuaField("do_custom")] public bool DoCustom;
        // Only Finish?
        [LuaField("hide_all_glows")] public bool HideAllGlows;
    }
}