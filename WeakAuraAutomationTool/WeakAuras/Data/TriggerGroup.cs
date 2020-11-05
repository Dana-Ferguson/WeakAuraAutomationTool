using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    // todo: no clue what the best name is here
    public class TriggerGroup
    {
        [LuaField("trigger")] public Trigger Trigger;
        [LuaField("untrigger")] public UnTrigger UnTrigger;
    }
}