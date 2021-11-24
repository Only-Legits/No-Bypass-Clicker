using NoBypass.Commands.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBypass.Commands
{
    public class CommandManager
    {
        public static readonly List<Command> Commands = new List<Command>();

        public static void Initialize()
        {
            Commands.Add(new CommandPrintStackTraces("PRINT_STACK_TRACES", "Print Stack Traces (For Developers)", 1));
        }
    }
}
