using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Animation
    {
        [LuaField("finish")] public AnimationStyle Finish;
        [LuaField("main")] public AnimationStyle Main;
        [LuaField("start")] public AnimationStyle Start;
    }
}