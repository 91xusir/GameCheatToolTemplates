using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TbBaiZhouKeJi
{
    public class RegisterHotKeyTool
    {
        private static readonly TimeSpan DebounceTime = TimeSpan.FromMilliseconds(300); // 设置防抖时间（500ms）
        private static Dictionary<int, DateTime> lastHotkeyTimes = new Dictionary<int, DateTime>(); // 存储每个热键的最后处理时间
        private static List<int> registeredHotKeys = new List<int>(); // 用于存储已注册的热键ID

        public enum ModifierKeys
        {
            None = 0x0000,
            Alt = 0x0001,
            Control = 0x0002
        }

        // 注册快捷键
        public static void RegisterNumberHotKeys(Form form)
        {
            // 注册数字小键盘 1-9 和它们的组合
            for (int i = 1; i <= 9; i++)
            {
                Register(form, i, ModifierKeys.None, (Keys)((int)Keys.NumPad1 + i - 1));
                Register(form, i + 9, ModifierKeys.Alt, (Keys)((int)Keys.NumPad1 + i - 1));
                Register(form, i + 18, ModifierKeys.Control, (Keys)((int)Keys.NumPad1 + i - 1));
            }
        }

        // 注册单个快捷键
        private static bool Register(Form form, int hotkeyId, ModifierKeys modifiers, Keys key)
        {
            if (DllImport.RegisterHotKey(form.Handle, hotkeyId, (uint)modifiers, (uint)key))
            {
                registeredHotKeys.Add(hotkeyId); // 成功注册后记录热键ID
                return true;
            }
            return false;
        }

        // 注销所有已注册的快捷键
        public static void UnregisterAllHotKeys(Form form)
        {
            foreach (int id in registeredHotKeys)
            {
                DllImport.UnregisterHotKey(form.Handle, id); // 注销已注册的热键
            }
            // 清空已注册热键的记录
            registeredHotKeys.Clear();
        }

        // 处理热键消息
        public static void ProcessHotKeyMessage(ref Message m, Action<int> hotkeyPressedCallback)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)
            {
                int hotkeyId = m.WParam.ToInt32();
                if (DebounceHotkey(hotkeyId))
                {
                    hotkeyPressedCallback?.Invoke(hotkeyId); 
                }
            }
        }

        // 防抖机制：检查热键是否超出了防抖时间
        private static bool DebounceHotkey(int hotkeyId)
        {
            DateTime currentTime = DateTime.Now;

            // 如果是首次按下或超过防抖时间，允许处理
            if (!lastHotkeyTimes.ContainsKey(hotkeyId) || currentTime - lastHotkeyTimes[hotkeyId] > DebounceTime)
            {
                lastHotkeyTimes[hotkeyId] = currentTime; // 更新该热键的最后处理时间
                return true; // 允许处理
            }

            return false; // 在防抖时间内，跳过处理
        }
    }
}
