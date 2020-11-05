using NLua;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal static class LuaState
    {
        private static Lua _lua;

        // Note: doing this makes everyone angry
        // ReSharper disable once InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles
        public static Lua lua => _lua ??= InitializeLua();
#pragma warning restore IDE1006 // Naming Styles

        private static Lua InitializeLua()
        {
            // Note: in theory we don't need Lua - but - I'm not sure LibDeflate is 100% compatible with C# Deflate
            //       their 64 bit encoding is just a little bit different than C#'s version
            //       we'd need to port the AceSerializer too
            var lua = new Lua();

            // lua.DoString(@"LibStub = require(""LibStub"")");
            lua.DoString(@"require(""LibStub"")");

            // note: I might want to bake this all into a separate lua file?
            // https://github.com/WeakAuras/WeakAuras2/blob/master/WeakAuras/Transmission.lua#L582
            lua.DoString("local configForDeflate = {level = 9}");
            lua.DoString(@"LibDeflate = require(""LibDeflate"")");

            // should be: lua.DoString(@"LibDeflate = require(""AceSerializer-3.0"")");
            // the '3.0' confuses NLua, so `AceSerializer-3.0` is renamed to `AceSerializer`
            // lua.DoString(@"Serializer = require(""AceSerializer"")");

            // note: we could convert AceSerializer to no longer require LibStubs -- but -- I bad at Lua (atm) -- AceSerializer:Embed (pro'lly why it can't embed normally, Serializer becomes true)
            lua.DoString(@"require(""AceSerializer"")");
            lua.DoString(@"Serializer = LibStub:GetLibrary(""AceSerializer-3.0"");");

            lua.DoString(@"LibSerialize = require(""LibSerialize"")");
            // lua.DoString(@"local LibSerialize = LibStub(""LibSerialize"")");

            // LoadFile vs DoFile
            // var status = lua.LoadFile("LibDeflate.lua");
            // lua["LibDeflate"] = lua.DoFile("LibDeflate.lua");
            // lua.DoFile("LibDeflate.lua"); <---- doesn't work
            // Console.WriteLine(status);

            // lua.LoadCLRPackage();
            // lua.RegisterFunction("print", typeof(Script).GetMethod("print"));

            return lua;
        }
    }
}