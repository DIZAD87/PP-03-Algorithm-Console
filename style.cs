using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHMS
{
    class style
    {
        public static void print(string message, ConsoleColor color, bool line)
            {
                Console.ForegroundColor = color;
                if (line == false) { Console.Write(message); }
                else if (line == true) { Console.WriteLine(message); }
            }

        public static void menu(string number, string alTitle, string title, string example, bool truncate)
        {
            style.print(String.Format("[{0}] ", number), ConsoleColor.Red, false);
            style.print(alTitle + ":", ConsoleColor.White, false);
            style.print(" " + title, ConsoleColor.Gray, true);
            if (truncate == false)
                {
                    style.print(example, ConsoleColor.DarkGray, true);
                }
            }

        public static void redInput()
        { Console.ForegroundColor = ConsoleColor.Red;}

        public static void end()
        { Console.ForegroundColor = ConsoleColor.White; }
    }
}
