using NoBypass.Commands.Implements;
using System.Collections.Generic;

namespace NoBypass.Commands
{
    public class CommandManager
    {
        public static readonly List<Command> Commands = new List<Command>();

        public static void Initialize()
        {
            Commands.Add(new CommandPrintStackTraces("PRINT_STACK_TRACES", "Print Stack Traces (For Developers)", 1));
            Commands.Add(new CommandLeftClick("LEFT_CLICK", "Left Click Autoclicker", 2));
        }
    }
}