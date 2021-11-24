﻿using NoBypass.Commands.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(string.Format("{0} printing of stack traces.", CommandHandler.PrintStack ? "Enabled" : "Disabled"));
        }
    }
}
