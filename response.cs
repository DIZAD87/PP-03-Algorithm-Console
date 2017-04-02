using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ALGORITHMS
{
    class response
    {
        //Integer list control
        public static List<int> integerList() //needs to return a list
            {

            List<int> responseList = new List<int>(){};
            style.print("Enter the size of your list(Integer only):", ConsoleColor.Yellow, true);
            int listSize = integerControl(0, 100);

            for (int i = 0; i < listSize; i++)
                {
                    style.print(String.Format("Enter the {0}th integer of the list:", i), ConsoleColor.Yellow, true);
                    responseList.Add(integerControl(0, 9999));
                }

            instruments.newLine();
            instruments.notify("Completing list...");
            instruments.printList(responseList, "Here is the list you specified:");
            return responseList;
            }

        //Integer value control
            public static int integerValue()
                {
                    style.print("Enter the integer value:", ConsoleColor.Yellow, true);
                    int entryInt = integerControl(0, 99999);
                    return entryInt;
                }

        //String value control
            public static string stringValue()
                {
                return "hello";
                }

        //String list control
            public static void stringList()
                {
                }

        //Integer value control        
        public static int integerControl(int intMin, int intMax)
        {
            string entryString = "";       
            bool entryPass = false;
            while (entryPass == false)
            {               
                style.redInput();
                entryString = Console.ReadLine();

                //Check for empty
                if (entryString.Length == 0)
                {
                    style.print("ERROR! The entry is " , ConsoleColor.Gray , false); style.print("EMPTY", ConsoleColor.White , false);
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(", Enter #s between [{0}] to [{1}] ONLY: ", intMin, intMax);
                    instruments.newLine();
                }
                else
                {
                    try
                    {
                        int entryInt = Convert.ToInt32(entryString);
                //Check for range
                        if (entryInt > intMax || entryInt < intMin)
                        {
                            style.print("ERROR! The entry is outside of " , ConsoleColor.Gray , false); style.print("RANGE", ConsoleColor.White , false);
                            style.print(String.Format(", Enter #s between [{0}] to [{1}] ONLY: ", intMin, intMax), ConsoleColor.DarkGray, true);
                            instruments.newLine();
                            entryPass = false;
                        }
                        else { entryPass = true; }
                    }

                //Check for strings
                    catch (FormatException)
                    {

                        style.print("ERROR! The entry has " , ConsoleColor.Gray , false); style.print("STRINGS" , ConsoleColor.White , false);
                        style.print(String.Format(", Enter #s between [{0}] to [{1}] ONLY: ", intMin, intMax), ConsoleColor.DarkGray, true);
                        instruments.newLine();
                    }

                //Any other errors
                    catch (Exception)
                    {
                        style.print("ERROR!",ConsoleColor.Gray,true);
                    }
                 
                }
            }
            return Convert.ToInt32(entryString);
        }//End of integer value control
    }
}
