using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

using WeakAuraAutomationTool.LuaMachine;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;
using WeakAuraAutomationTool.WeakAuras.Utility;

namespace WeakAuraAutomationTool
{
    internal class Program
    {
        // this would have been helpful to find before I started this
        // https://github.com/oratory/wago.io/tree/master/backend/api/lua
        // todo: https://www.wowhead.com/spell=329487/ardenweald-covenant-ability

        // todo: optional -- match new LuaFields \ Classes to existing classes to make it easier to update things
        // todo: optional -- tool/script to do WAGO.io uploads?
        // todo: what can we do to make our Import-String smaller?

        private static void Main(string[] args)
        {
            Console.WriteLine("Generating WeakAura!");
            var sw = Stopwatch.StartNew();

            BarbequeParty();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"Complete! {elapsed} ms");
        }

        private static void BarbequeParty()
        {
            var wa = Barbeque.Generate.Go();
            var importString = wa.ToCompressedString();

            // Console.WriteLine(importString);

            Directory.CreateDirectory("output");
            const string filepath = "output/importString.txt";
            File.WriteAllText(filepath, importString);
            Console.WriteLine($"File '{filepath}' written. {importString.Length} bytes.");
        }
    }
}