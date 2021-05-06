using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Program
    {

        public static void Main(String[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            
        }

        void Start()
        {
            Month monthTest = Month.July;

            Console.WriteLine("PrintMonth method:");
            PrintMonth(monthTest);          //prints July
            Console.WriteLine();

            Console.WriteLine("\nPrintMonths method:");
            PrintMonths();                  //print all months with respective int
            Console.WriteLine();

            Console.WriteLine("\nImproved ReadMonth method:");
            Month monthTest2 = (ReadMonth("Enter a month number: "));         


        }

        public enum Month
        {
            January = 1, Febuary, March, April, May, June, July, August, September, October, November, December
        }

        void PrintMonth(Month month)
        {
            Console.Write(String.Format("{0, 4}", month));
        }

        void PrintMonths()
        {
            for(Month m = Month.January; m <= Month.December; m++)
            {
                Console.Write(String.Format("{0, 4}. ", (int)m));
                PrintMonth(m);
                Console.WriteLine();
            }
        }

        Month ReadMonth(string question)
        {

            int temp;

            while (true)
            {
                try
                {
                    Console.Write(question);
                    temp = int.Parse(Console.ReadLine());

                    if (Enum.IsDefined(typeof(Month), temp))
                    {
                        Month returnValue = (Month) temp;
                        Console.Write($"{temp} => ");
                        PrintMonth(returnValue);

                        return returnValue;
                    }
                        

                    Console.WriteLine("{0} is not a valid value!", temp);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\nPlease input an int number between 1 and 12! >:(");
                }
            }
        }
    }
}
