using System;
using System.Collections.Generic;
using System.Threading; //Added for thread sleep

namespace ALGORITHMS
{
    class algorithmPrime
    {
        public static void algorithm()
        {
            //Setup
                Console.Clear();
                instruments.titleStamp("01 / 05 / 17");
                style.menu("5", "PRIME", "Returns the prime number(s) of an integer", "exINPUT: 5, exOUTPUT: 2,3", false);
                style.redInput();
                instruments.newLine();
                int entryInt = response.integerValue();
                instruments.newLine();
                List<int> returnList = new List<int>() { };
                Thread.Sleep(500);
                instruments.notify("Processing algorithm...");

            //Algorithm                
                for (int i = 2; i < entryInt; i++)
                    {
                        int primeCount = 0;
                        for (int j = 2; j < i; j++)
                            {
                                if(i%j == 0)
                                {primeCount++;}
                            }
                        if (primeCount == 0)
                            {
                                returnList.Add(i);
                            }
                    }                   
                instruments.printList(returnList, "Here is(are) your PRIME number(s):");
                instruments.newLine();
                Thread.Sleep(500);

            //end
                instruments.consoleControl(5); //# depends on the algorithm
                style.end();
        }
    }
}
