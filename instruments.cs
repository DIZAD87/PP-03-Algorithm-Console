using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //added for my thread sleep

namespace ALGORITHMS
{
    class instruments
    {
        //Paragraph the text
        public static void newLine()
            {
                Console.WriteLine("");
            }

        //Notify prompt
        public static void notify(string message)
            {
                style.print(message, ConsoleColor.DarkGray, true);
                Thread.Sleep(1000);
            }
        //Print a list visuals
        public static void printList(List<int> list, string message)
            {
                style.print(message, ConsoleColor.Yellow, true);
                style.print("[", ConsoleColor.Red, false);
                for (int i = 0; i < list.Count; i++)
                {
                    style.print(Convert.ToString(list[i]), ConsoleColor.Red, false);
                    if (i == list.Count - 1)
                    { style.print("", ConsoleColor.Red, false); }
                    else { style.print(",", ConsoleColor.Red, false); }
                }
                style.print("]", ConsoleColor.Red, true);
            }

        //Entry prompt
        public static void entryPrompt()
            {
                style.print("ENTRY: ", ConsoleColor.Magenta, false);
                style.redInput();
            }

        //Title stamp
        public static void titleStamp(string date)
            {
                style.print(String.Format("ALGORITHMS BY: DIZAD, COMPLETION DATE: ({0})", date), ConsoleColor.Cyan, true);
            }

        //consoleControl        
            public static void consoleControl(int algorithmInMem)
                {
                    style.print("[1] ", ConsoleColor.Red,false); style.print("Main Menu", ConsoleColor.White,true);
                    style.print("[2] ", ConsoleColor.Red,false); style.print("Restart", ConsoleColor.White,true);
                    style.print("[3] ", ConsoleColor.Red,false); style.print("Exit", ConsoleColor.White,true);

                    style.redInput();
                    instruments.newLine();
                    switch (response.integerControl(1, 3))
                    {
                        case 1: Console.Clear(); home.mainMenu(); break;
                        case 2: 
                            switch (algorithmInMem)
                            {
                                case 1: algorithmEven.algorithm(); break;
                                case 2: algorithmOdd.algorithm(); break;
                                case 3: algorithmSum.algorithm(); break;
                                case 4: algorithmFactorial.algorithm(); break;
                                case 5: algorithmEven.algorithm(); break;
                                default: home.mainMenu(); break;
                            }
                            break;
                        case 3: style.end(); Environment.Exit(0); break;
                        default: break;
                    }
                }
    }
}
