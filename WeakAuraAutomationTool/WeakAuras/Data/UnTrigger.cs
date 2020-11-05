using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class UnTrigger
    {
        [LuaField("itemSlot")] public long ItemSlot;
        [LuaField("genericShowOn")] public string GenericShowOn;
    }
}