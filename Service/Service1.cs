using Memory;
using System;
using System.Collections.Generic;

namespace TbBaiZhouKeJi
{
    internal class Service1
    {
        public static Mem MemLib = new Mem();
        private static List<Func<bool, bool>> openingFunctionList = new List<Func<bool, bool>>();

        //无CD
        public static bool RemoveCd(bool isOpen)
        {
            if (isOpen)
            {
                return MemLib.WriteMemory("GameAssembly.dll+3BFF85", "bytes", "90 90 90 90 90");
            }
            else
            {
                return MemLib.WriteMemory("GameAssembly.dll+3BFF85", "bytes", "F3 0F 10 43 48");
            }
        }
        //无条件种植
        public static bool RemoveCost(bool isOpen)
        {
            if (isOpen)
            {
                var a = MemLib.WriteMemory("GameAssembly.dll+3C004B", "bytes", "90 90 90 90 90 00");
                var b = MemLib.WriteMemory("GameAssembly.dll+36EFB2", "bytes", "90 90");
                return a && b;
            }
            else
            {
                var a = MemLib.WriteMemory("GameAssembly.dll+3C004B", "bytes", "7C 49 80 7B 51 00");
                var b = MemLib.WriteMemory("GameAssembly.dll+36EFB2", "bytes", "7C 26");
                return a && b;
            }
        }
    }
}
