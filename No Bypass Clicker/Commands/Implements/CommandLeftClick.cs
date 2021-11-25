using NoBypass.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NoBypass.Commands.Implements
{
    public class CommandLeftClick : Command
    {
        private Thread Thread = new Thread(new ThreadStart(LeftClickThread));
        private static bool KillThread;
        private static DateTime OldDateTime = DateTime.Now;

        public CommandLeftClick(string internalName, string displayName, int id) : base(internalName, displayName, id)
        {

        }

        public override void Execute()
        {
            Enabled = !Enabled;
            Console.WriteLine(string.Format("{0} the left-click autoclicker.\n", Enabled ? "Enabled" : "Disabled"));
            if (Thread.IsAlive)
            {
                KillThread = true;
            } else
            {
                Thread.Start();
                KillThread = false;
            }
        }

        private static void LeftClickThread()
        {
            while (!KillThread)
            {
                DateTime newDateTime = DateTime.Now;
                if (DateTime.Now.CompareTo(OldDateTime) == 1)
                {
                    Console.WriteLine("REACHED!!");
                    Methods.LeftClick();
                    OldDateTime = newDateTime.AddMilliseconds(50.0);
                }
            }
        }
    }
}
