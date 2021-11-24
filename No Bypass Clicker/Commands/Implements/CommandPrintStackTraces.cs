using NoBypass.Commands.API;
using System;

namespace NoBypass.Commands.Implements
{
    public class CommandPrintStackTraces : Command
    {
        public CommandPrintStackTraces(string internalName, string displayName, int id) : base(internalName, displayName, id)
        {
        }

        public override void Execute()
        {
            CommandHandler.PrintStack = !CommandHandler.PrintStack;
            Console.WriteLine(string.Format("{0} printing of stack traces.\n", CommandHandler.PrintStack ? "Enabled" : "Disabled"));
        }
    }
}