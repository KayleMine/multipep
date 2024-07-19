using multipep;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Seth.lib
{
    public class WindowResizer
    {
        // P/Invoke declarations
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static void ResizeWowWindows()
        {
            var wowWindows = GetWowWindows();
            if (wowWindows.Length == 0)
            {
                new MainFrame().LogMe("No World of Warcraft windows found.");
                return;
            }
            RenameWowWindows(GetWowWindows());
            ResizeAndRepositionWindows(wowWindows);
        }

        public static IntPtr[] GetWowWindows()
        {
            var wowProcesses = Process.GetProcessesByName("wow");
            var windowHandles = new List<IntPtr>();

            foreach (var process in wowProcesses)
            {
                IntPtr hWnd = process.MainWindowHandle;
                if (hWnd != IntPtr.Zero)
                {
                    windowHandles.Add(hWnd);
                }
            }

            return windowHandles.ToArray();
        }

        public static void RenameWowWindows(IntPtr[] windows)
        {
            for (int i = 0; i < windows.Length; i++)
            {
                string windowTitle = $"Wow{i + 1}";
                SetWindowText(windows[i], windowTitle);
            }
        }

        public static void BringWindows()
        {
            var wowWindows = GetWowWindows();
            foreach (var window in wowWindows)
            {
                SetForegroundWindow(window);
                Thread.Sleep(85);
            }
           
        }

        static void ResizeAndRepositionWindows(IntPtr[] windows)
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            int screenWidth = screenBounds.Width;
            int screenHeight = screenBounds.Height;

            int numWindows = windows.Length;
            int cols = (int)Math.Ceiling(Math.Sqrt(numWindows));
            int rows = (int)Math.Ceiling((double)numWindows / cols);

            int windowWidth = screenWidth / cols;
            int windowHeight = screenHeight / rows;

            for (int i = 0; i < numWindows; i++)
            {
                int col = i % cols;
                int row = i / cols;
                int x = col * windowWidth;
                int y = row * windowHeight;

                MoveWindow(windows[i], x, y, windowWidth, windowHeight, true);
            }
        }
    }
}
