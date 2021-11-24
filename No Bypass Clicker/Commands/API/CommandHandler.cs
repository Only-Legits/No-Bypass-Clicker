using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoBypass.Commands.API
{
    public class CommandHandler
    {
        public static bool PrintStack;

        public static void HandleCommand(int input)
        {
            switch (input)
            {
                case 1:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Non-existent command.");
                        break;
                    }
            }
        }
    }
}
