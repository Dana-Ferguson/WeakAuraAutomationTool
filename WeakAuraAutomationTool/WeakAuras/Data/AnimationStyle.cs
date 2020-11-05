using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class AnimationStyle
    {
        [LuaField("duration_type")] public string DurationType;
        [LuaField("easeStrength")] public double EaseStrength;
        [LuaField("easeType")] public string EaseType;
        [LuaField("type")] public string Type;
    }
}