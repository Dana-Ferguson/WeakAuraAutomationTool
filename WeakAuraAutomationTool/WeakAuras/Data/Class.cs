using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Class
    {
        [LuaField("multi")] public List<object> Multi;
        [LuaField("single")] public string Single;
    }
}