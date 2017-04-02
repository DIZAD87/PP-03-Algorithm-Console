using System;
using System.Collections.Generic;
using System.Threading; //Added for thread sleep

namespace ALGORITHMS
{
    class algorithmReverse
    {
        public static void algorithm()
        {
            //Setup
            Console.Clear();
            instruments.titleStamp("01 / 05 / 17");
            style.menu("6", "REVERSE", "Reverses a string", "exINPUT: hello, exOUTPUT: olleh", false);
            style.redInput();
            instruments.newLine();
            int entryInt = response.integerValue();
            instruments.newLine();
            List<int> returnList = new List<int>() { };
            Thread.Sleep(500);
            instruments.notify("Processing algorithm...");

            //Algorithm                
            


            instruments.printList(returnList, "Here is(are) your PRIME number(s):");
            instruments.newLine();
            Thread.Sleep(500);

            //end
            instruments.consoleControl(6); //# depends on the algorithm
            style.end();
        }
    }
}
