using System;
using System.Collections.Generic;
using System.Threading; //Added for thread sleep

namespace ALGORITHMS
{
    class algorithmOdd
    {
        public static void algorithm()
        {
            //Setup
            Console.Clear();
            instruments.titleStamp("01 / 05 / 17");
            style.menu("2", "ODD", "Returns the odd numbers of a list:", "exINPUT: [1, 2, 3], exOUTPUT: 1,3", false);
            style.redInput();
            instruments.newLine();
            List<int> entryList = response.integerList();
            instruments.newLine();
            List<int> returnList = new List<int>() { };
            Thread.Sleep(500);
            instruments.notify("Processing algorithm...");

            //Algorithm
            for (int i = 0; i < entryList.Count; i++)
            {
                if (entryList[i]%2 != 0)
                {
                    returnList.Add(entryList[i]);
                }
            }

            instruments.printList(returnList, "Here are your ODD numbers:");
            instruments.newLine();
            Thread.Sleep(500);

            //end
            instruments.consoleControl(2); //# depends on the algorithm
            style.end();
        }
    }
}
