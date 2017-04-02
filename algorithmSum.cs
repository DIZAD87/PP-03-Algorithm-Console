using System;
using System.Collections.Generic;
using System.Threading; //Added for thread sleep

namespace ALGORITHMS
{
    class algorithmSum
    {
        public static void algorithm()
        {
            //Setup
            Console.Clear();
            instruments.titleStamp("01 / 05 / 17");
            style.menu("3", "SUM", "Returns the SUM of a list:", "exINPUT: [1 , 2 , 3], exOUTPUT: 6", false);
            style.redInput();
            instruments.newLine();
            List<int> entryList = response.integerList();
            instruments.newLine();
            List<int> returnList = new List<int>() { };
            Thread.Sleep(500);
            instruments.notify("Processing algorithm...");

            //Algorithm
            int sum = 0;
            for (int i = 0; i < entryList.Count; i++)
                {                   
                    sum += entryList[i];
                }
            returnList.Add(sum);
            instruments.printList(returnList, "Here is your SUM:");
            instruments.newLine();
            Thread.Sleep(500);

            //end
            instruments.consoleControl(3); //# depends on the algorithm
            style.end();
        }
    }
}
