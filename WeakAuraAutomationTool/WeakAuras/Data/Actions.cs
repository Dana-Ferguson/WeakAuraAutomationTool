using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Actions
    {
        [LuaField("finish")] public Functions Finish;
        [LuaField("init")] public Functions Init;
        [LuaField("start")] public Functions Start;
    }
}