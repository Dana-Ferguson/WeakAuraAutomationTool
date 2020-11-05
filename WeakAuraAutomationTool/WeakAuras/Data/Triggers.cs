using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Triggers
    {
        // todo: name
        [LuaArray] public List<TriggerGroup> Group;
        [LuaField("activeTriggerMode")] public double ActiveTriggerMode;
        [LuaField("disjunctive")] public string Disjunctive;
        [LuaField("trigger")] public Trigger Trigger;
        [LuaField("untrigger")] public UnTrigger UnTrigger;
    }
}