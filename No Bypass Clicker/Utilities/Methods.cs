using System.Windows.Forms;

namespace NoBypass.Utilities
{
    public class Methods
    {
        public static void LeftClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            Natives.mouse_event(Natives.MOUSEEVENTF_LEFTDOWN | Natives.MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public static void RightClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            Natives.mouse_event(Natives.MOUSEEVENTF_RIGHTDOWN | Natives.MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }
    }
}