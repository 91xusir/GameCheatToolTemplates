using Memory;
using System;
using System.Collections.Generic;

namespace TbBaiZhouKeJi
{
    internal class Service1
    {
        public static Mem MemLib = new Mem();
        private static List<Func<bool, bool>> openingFunctionList = new List<Func<bool, bool>>();



        //卡牌无冷却
        public static bool Cheat1(bool isOpen)
        {
            var address = "GameAssembly.dll+3BFF85";
            var oldValue = "F3 0F 10 43 48";
            var newValue = "90 90 90 90 90";
            if (isOpen)
            {
                return MemLib.WriteMemory(address, "bytes", newValue);
            }
            else
            {
                return MemLib.WriteMemory(address, "bytes", oldValue);
            }
        }
        //无条件种植
        public static bool Cheat2(bool isOpen)
        {
            //ui
            var address1 = "GameAssembly.dll+3C004B";
            var oldValue1 = "7C 49 80 7B 51 00";
            var newValue1 = "90 90 90 90 90 00";
            //阳光
            var address2 = "GameAssembly.dll+36EFB2";
            var oldValue2 = "7C 26";
            var newValue2 = "90 90";
            if (isOpen)
            {
                var a = MemLib.WriteMemory(address1, "bytes", newValue1);
                var b = MemLib.WriteMemory(address2, "bytes", newValue2);
                return a && b;
            }
            else
            {
                var a = MemLib.WriteMemory(address1, "bytes", oldValue1);
                var b = MemLib.WriteMemory(address2, "bytes", oldValue2);
                return a && b;
            }
        }
        //手套无冷却
        public static bool Cheat3(bool isOpen)
        {
            var address = "GameAssembly.dll+375394";
            var oldValue = "C7 47 34 00 00 00 00";
            var newValue = "C7 47 34 00 00 30 41";
            if (isOpen)
            {
                return MemLib.WriteMemory(address, "bytes", newValue);
            }
            else
            {
                return MemLib.WriteMemory(address, "bytes", oldValue);
            }
        }
        //全屏秒杀
        public static bool Cheat4(bool isOpen)
        {
            var address = "GameAssembly.dll+346DC6";
            var oldValue = "72 15 48 8B 03";
            var newValue = "90 90 48 8B 03";
            if (isOpen)
            {
                return MemLib.WriteMemory(address, "bytes", newValue);
            }
            else
            {
                return MemLib.WriteMemory(address, "bytes", oldValue);
            }
        }
        //大嘴花增强
        public static bool Cheat5(bool isOpen)
        {
            //秒吞
            var address1 = "GameAssembly.dll+3E308D";
            var oldValue1 = "72 19";
            var newValue1 = "90 90";
            //距离
            var address2 = "GameAssembly.dll+3FEA12";
            var oldValue2 = "C7 83 60 01 00 00 00 00 C0 3F";
            var newValue2 = "C7 83 60 01 00 00 00 00 C0 43";
            if (isOpen)
            {
                var a = MemLib.WriteMemory(address1, "bytes", newValue1);
                var b = MemLib.WriteMemory(address2, "bytes", newValue2);
                return a && b;
            }
            else
            {
                var a = MemLib.WriteMemory(address1, "bytes", oldValue1);
                var b = MemLib.WriteMemory(address2, "bytes", oldValue2);
                return a && b;
            }
        }
    }
}
