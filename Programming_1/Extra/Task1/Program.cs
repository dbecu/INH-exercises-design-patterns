using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //finds my list.txt is resources
            string myList = Properties.Resources.list;

            //turns my txt into a list, split by every line
            //a dandy line i found online
            List<string> lines = myList.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
  
            int i = 1;
            foreach (string line in lines)
            {
                //which lines im gonna be editting
                Console.WriteLine("Line " + i + ":\t"+ line);

                //Splitting up the string line so that each year is seperated in the array
                //You can manipulate is that way i guess
                string[] split = lines[i - 1].Split(",");

                //display the join & leave year
                Console.WriteLine("Join year: {0}\tLeave year: {1}", split[0], split[1]);
                Console.WriteLine();

                i++;

            }
   
            //console open to debug
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
