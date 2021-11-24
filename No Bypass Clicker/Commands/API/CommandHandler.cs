using System;

namespace NoBypass.Commands.API
{
    public class CommandHandler
    {
        public static bool PrintStack;

        public static void HandleCommand(int input)
        {
            foreach (Command command in CommandManager.Commands)
            {
                if (input == command.ID)
                {
                    command.Execute();
                    return;
                }
            }
            Console.WriteLine("Non-existent option.");
        }
    }
}