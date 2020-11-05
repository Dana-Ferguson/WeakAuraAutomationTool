using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Check
    {
        [LuaField("op")] public string Op;
        [LuaField("trigger")] public double Trigger;
        // the type here depends in the value in "Variable"
        // "customcheck" --> string; for a lot of things, long
        [LuaField("value")] public object Value;
        [LuaField("variable")] public string Variable;
    }
}