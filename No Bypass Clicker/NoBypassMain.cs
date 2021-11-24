using NoBypass.Commands.API;
using NoBypass.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_Bypass_Clicker
{
    public class NoBypassMain
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Title = "No Bypass";

            while (true)
            {
                try
                {
                    CommandHandler.HandleCommand(int.Parse(Console.ReadLine()));
                } catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
