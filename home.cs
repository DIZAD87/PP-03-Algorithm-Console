//DIZAD 01/04/17-START
//DIZAD XX/XX/XX-END

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHMS
{
    class home
    {
        public static void Main(string[] args)
        {
            Console.WindowWidth = 60;
            Console.WindowHeight = 40;
            mainMenu();         
        }
        public static void mainMenu()
            {
            instruments.titleStamp("01 / 04 / 17");
            style.print("Select an algorithm:", ConsoleColor.Yellow, true);
            instruments.newLine();
                style.menu("1", "EVEN", "Returns the even number(s) of a list:", "exINPUT: [1, 2, 3], exOUTPUT: 2", false);
                style.menu("2", "ODD", "Returns the odd number(s) of a list:", "exINPUT: [1, 2, 3], exOUTPUT: 1,3", false);
                style.menu("3", "SUM", "Returns the SUM of a list:", "exINPUT: [1 , 2 , 3], exOUTPUT: 6", false);
                style.menu("4", "FACTORIAL", "Returns the factorial of an integer", "exINPUT: 5, exOUTPUT: 1*2*3*4*5 = 120", false);
                style.menu("5", "PRIME", "Returns the prime number(s) of an integer", "exINPUT: 5, exOUTPUT: 2,3", false);
                style.menu("6", "REVERSE", "Reverses a string", "exINPUT: hello, exOUTPUT: olleh", false); //in progress

                style.menu("7", "COMBINE", "Combines two or more strings together", "exINPUT: Max, Payne, exOUTPUT: Max Payne", false);
                style.menu("8", "VOWELS", "Removes vowel(s) from a string", "exINPUT: Hello there!, exOUTPUT: Hll thr!", false);
                style.menu("9", "CENSOR", "Replaces a word from a phrase with asterisks(*)", "exINPUT: Replace this word, word, exOUTPUT: Replace this ****", false);
                style.menu("10", "COUNT", "Counts the quantity of a duplicate integer in a list", "exINPUT: [1, 1, 2], 1, exOUTPUT: 2", false);
                style.menu("11", "DUPLICATES", "Removes duplicates from a list", "exINPUT: [1, 1, 2], exOUTPUT: [1,2]", false);
                style.menu("12", "MEDIAN, DEV, AVG", "Determines data properties of list", "exINPUT: [1, 2, 3], exOUTPUT: M=2, D=1, A=2", false);
                style.menu("13", "SORT", "Sorts a list from smallest to largest", "exINPUT: [3, 1, 2], exOUTPUT: [1, 2, 3]", false);

            instruments.entryPrompt();
            switch (response.integerControl(1,5))
                {
                    case 1: algorithmEven.algorithm(); break;
                    case 2: algorithmOdd.algorithm(); break;
                    case 3: algorithmSum.algorithm(); break;
                    case 4: algorithmFactorial.algorithm(); break;
                    case 5: algorithmPrime.algorithm(); break;
                    case 6: algorithmReverse.algorithm(); break;
                    default: break;
                }
        }
    }
}
