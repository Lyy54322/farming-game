using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace 农场
{
    public static class AutoFullScreen
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private const byte VK_MENU = 0x12;       // Alt 键
        private const byte VK_RETURN = 0x0D;     // Enter 键
        private const int KEYEVENTF_KEYUP = 0x02;

        public static void Enter()
        {
            try
            {
                // 1. 确保控制台窗口在前台
                IntPtr hwnd = GetConsoleWindow();
                SetForegroundWindow(hwnd);
                Thread.Sleep(100); // 等待窗口激活

                // 2. 模拟 Alt + Enter
                keybd_event(VK_MENU, 0, 0, 0);
                Thread.Sleep(50);
                keybd_event(VK_RETURN, 0, 0, 0);
                Thread.Sleep(50);
                keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0);
                Thread.Sleep(50);
                keybd_event(VK_MENU, 0, KEYEVENTF_KEYUP, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"自动全屏失败: {ex.Message}");
            }
        }
    }
}