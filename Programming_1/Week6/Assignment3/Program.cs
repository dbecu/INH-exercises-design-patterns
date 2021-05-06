using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            do
            {
                Console.Write("Enter a year (0 is stop value): ");
                year = int.Parse(Console.ReadLine());

                if (year < 0)
                    Console.WriteLine("Year must be positive!");              
                else if (isLeapYear(year))
                    Console.WriteLine(year + " is a leap year.");
                else
                    Console.WriteLine(year + " is not a leap year.");

                
            }
            while (year != 0);
            Console.WriteLine("End of program. Bye!");

            Console.ReadKey();
        }

        public static bool isLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
    }
}
