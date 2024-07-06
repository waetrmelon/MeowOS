using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
namespace MeowOS.Core
{
    internal class CommandHandler
    {

        public static bool Confirmation(string reason)
        {
            Console.WriteLine(":: Are you sure you would like to " + reason);
            Console.WriteLine(":: Proceed with the following? [Y/N]");
            string reponse = Console.ReadLine();
            if (reponse == null)
            {
                Console.WriteLine("Invalid Reponse, cancelling operation.");
                return false;
            }
            else if (reponse[0].ToString().ToLower() == "y")
            {
                return true;
            }
            else if (reponse[0].ToString().ToLower() == "n")
            {
                Console.WriteLine("You have chose to cancel the operation, attempting to cancel operation ...");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Reponse, cancelling operation.");
                return false;
            }
        }

        public static bool ExecuteCommand()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Kernel.User);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("@meow ~ ");


            string cmd = Console.ReadLine();
            string[] cmd_args = cmd.Split(" ");
            string command_name = cmd_args[0];
            switch (cmd_args[0])
            {
                case "help":
                    {
                        Console.WriteLine(" - Help Section -");
                        Console.WriteLine(" \'help\' -> Leads you here.");
                        Console.WriteLine(" \'info\' -> Gives Kernel Information.");
                        Console.WriteLine(" \'echo\' -> Echos what you write in the entry.");
                        Console.WriteLine(" \'clear\' -> Clears the screen.");
                        Console.WriteLine(" \'reboot\' -> Reboots the machine.");
                        Console.WriteLine(" \'shutdown\' -> Shutsdown the machine.");
                        break;
                    }
                case "info":
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(Kernel.User);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("@meow");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("OS: " + Kernel.os_name);
                        Console.WriteLine("Kernel: " + Kernel.kernel_version);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("");
                        break;
                    }
                case "shutdown":
                    {
                        Console.WriteLine("Attempting to reboot ...");
                        if (Confirmation("Shutdown the System?"))
                        {
                            Cosmos.System.Power.Shutdown();
                        }
                        break;
                    }
                case "reboot":
                    {
                        Console.WriteLine("Attempting to reboot ...");
                        if (Confirmation("Reboot the System?"))
                        {
                            Cosmos.System.Power.Reboot();
                        }
                        break;
                    }
                case "clear":
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.Write("Welcome to ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Meow OS ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("!");
                        Console.WriteLine("");
                        break;
                    }
                case "echo":
                    {
                        for (int i = 1; i < cmd_args.Length; i++)
                        {
                            Console.Write(cmd_args[i] + " ");
                        }
                        Console.WriteLine("");
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid Command Sequence!");
                        break;
                    }
            }

            return true;
        }
    }
}

