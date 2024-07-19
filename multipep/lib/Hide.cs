using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Seth.lib
{
    public class Hider
    {
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        const uint WDA_EXCLUDEFROMCAPTURE = 0x00000011;
        const uint WDA_NONE = 0x00000000;

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
        private const uint WS_EX_APPWINDOW = 0x00040000;
        private const uint WS_EX_TOOLWINDOW = 0x00000080;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int GWL_EXSTYLE = -20;

        

        public void Hide(IntPtr Handle)
        {
            int style = GetWindowLong(Handle, GWL_EXSTYLE);
            SetWindowLong(Handle, GWL_EXSTYLE, style | (int)WS_EX_TOOLWINDOW);
            ShowWindow(Handle, SW_SHOW);
            SetWindowDisplayAffinity(Handle, WDA_EXCLUDEFROMCAPTURE);
        }
        public void Unhide(IntPtr handle)
        {
            int style = GetWindowLong(handle, GWL_EXSTYLE);
            SetWindowLong(handle, GWL_EXSTYLE, style & ~(int)WS_EX_TOOLWINDOW);
            ShowWindow(handle, SW_SHOW);
            SetWindowDisplayAffinity(handle, WDA_NONE);
        }
    }
}
