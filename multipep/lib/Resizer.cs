using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                Console.WriteLine("No World of Warcraft windows found.");
                return;
            }

            ResizeAndRepositionWindows(wowWindows);
        }

        private static IntPtr[] GetWowWindows()
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
