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
        public static readonly List<Command> commands = new List<Command>();

        public CommandManager()
        {
            commands.Add(new CommandPrintStackTraces("PRINT_STACK_TRACES", "Print Stack Traces (For Developers)", 1));
        }
    }
}
