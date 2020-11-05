using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Condition
    {
        [LuaField("changes")] public List<Change> Changes;
        [LuaField("check")] public Check Check;
    }
}