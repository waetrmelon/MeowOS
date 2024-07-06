using MeowOS.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace MeowOS
{
    public class Kernel : Sys.Kernel
    {
        public static string User = "root";
        public static string os_name = "MeowOS v1 (Core)";
        public static string kernel_version = "1.0";
        public static bool prelaunch_state = false;
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Attempting to enter Kernel ...");
            Console.WriteLine("Sucessfully entered kernel!");
            prelaunch_state = true;
            Console.WriteLine("");
            Console.Write("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Meow OS ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("!");
            Console.WriteLine("");
        }

        protected override void Run()
        {
            if (prelaunch_state)
            {
                CommandHandler.ExecuteCommand();
            }
        }
    }
}
