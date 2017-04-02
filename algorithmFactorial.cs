using System;
using System.Collections.Generic;
using System.Threading; //Added for thread sleep

namespace ALGORITHMS
{
    class algorithmFactorial
    {
        public static void algorithm()
        {
            //Setup
                Console.Clear();
                instruments.titleStamp("01 / 05 / 17");
                style.menu("4", "FACTORIAL", "Returns the factorials of an integer", "exINPUT: 5, exOUTPUT: 1*2*3*4*5 = 120", false);
                style.redInput();
                instruments.newLine();
                int entryInt =  response.integerValue();
                instruments.newLine();
                List<int> returnList = new List<int>() { };
                Thread.Sleep(500);
                instruments.notify("Processing algorithm...");

            //Algorithm
                int factorial = 1;
                for (int j = 1; j <= entryInt; j++)
                    {factorial = factorial * j; }
                returnList.Add(factorial);                   
                instruments.printList(returnList, "Here is your FACTORIAL:");
                instruments.newLine();
                Thread.Sleep(500);

            //end
                instruments.consoleControl(4); //# depends on the algorithm
                style.end();
        }
    }
}
