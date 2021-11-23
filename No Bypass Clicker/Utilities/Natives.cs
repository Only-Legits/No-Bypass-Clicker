using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NoBypass.Utilities
{
    /**
     * Sources provided by...
     * https://stackoverflow.com/questions/2416748/how-do-you-simulate-mouse-click-in-c
     */
    public class Natives
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public static readonly uint MOUSEEVENTF_LEFTDOWN = 0x02;
        public static readonly uint MOUSEEVENTF_LEFTUP = 0x04;
        public static readonly uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        public static readonly uint MOUSEEVENTF_RIGHTUP = 0x10;
    }
}
