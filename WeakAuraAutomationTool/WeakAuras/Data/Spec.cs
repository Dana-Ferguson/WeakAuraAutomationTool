using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Spec
    {
        [LuaField("multi")] public List<object> Multi;
        // todo: what!?
        [LuaField("single")] public double Single;
    }
}