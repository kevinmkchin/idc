using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace idc
{
    static class Program
    {
        const UInt32 WM_KEYDOWN = 0x0100;
        const int VK_F5 = 0x74;
        const int VK_A = 0x0041;
        const int VK_B = 0x0042;
        const int VK_C = 0x0043;
        const int VK_D = 0x0044;
        const int VK_E = 0x0045;
        const int VK_F = 0x0046;
        const int VK_G = 0x0047;
        const int VK_H = 0x0048;
        const int VK_I = 0x0049;
        const int VK_J = 0x004A;
        const int VK_K = 0x004B;
        const int VK_L = 0x004C;
        const int VK_M = 0x004D;
        const int VK_N = 0x004E;
        const int VK_O = 0x004F;
        const int VK_P = 0x0050;
        const int VK_Q = 0x0051;
        const int VK_R = 0x0052;
        const int VK_S = 0x0053;
        const int VK_T = 0x0054;
        const int VK_U = 0x0055;
        const int VK_V = 0x0056;
        const int VK_W = 0x0057;
        const int VK_X = 0x0058;
        const int VK_Y = 0x0059;
        const int VK_Z = 0x005A;
        const int VK_RETURN = 0x0D;
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        [STAThread]
        static void Main()
        {
            while(true)
            {
                Process [] processes = Process.GetProcessesByName("chrome");

                foreach (Process proc in processes)
                {
                    PostMessage(proc.MainWindowHandle, WM_KEYDOWN, VK_I, 0);
                    PostMessage(proc.MainWindowHandle, WM_KEYDOWN, VK_D, 0);
                    PostMessage(proc.MainWindowHandle, WM_KEYDOWN, VK_C, 0);
                    PostMessage(proc.MainWindowHandle, WM_KEYDOWN, VK_RETURN, 0);
                }

                Thread.Sleep(5000);
            }
        }
    }
}
