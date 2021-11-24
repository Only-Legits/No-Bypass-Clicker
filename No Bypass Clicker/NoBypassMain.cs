using NoBypass.Commands;
using NoBypass.Commands.API;
using System;

namespace No_Bypass_Clicker
{
    public class NoBypassMain
    {
        public static void Main()
        {
            CommandManager.Initialize();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Title = "No Bypass";

            while (true)
            {
                Console.WriteLine("No Bypass Clicker (by uncodable)\nNot made to be good, rather made to prove a point.\n");
                foreach (Command command in CommandManager.Commands)
                {
                    Console.WriteLine(string.Format("[{0}] {1} ({2})", command.ID, command.DisplayName, command.InternalName));
                }
                Console.Write("\nEnter a valid ID... ");
                try
                {
                    CommandHandler.HandleCommand(int.Parse(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine(string.Format("{0}\n", e.Message));
                }
            }
        }
    }
}