using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowOS.Core
{
    internal class LogHandler
    {
        public static void ThrowError(string ErrorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] " + ErrorMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ThrowWarning(string ErrorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[Warning] " + ErrorMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
