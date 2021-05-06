using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            double year;
            string message = "";

            do
            {
                Console.Write("Enter a year: ");
                year = double.Parse(Console.ReadLine());

                if (year < 0)
                    message = "Year must be positive!";
                //else if ((year % 100 == 0 && year % 4 == 0) || (year % 400 != 0))
                else if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    message = (year + " is a leap year.");
                else
                    message = (year + " is not a leap year.");

                if (year != 0)
                    Console.WriteLine(message);


            }
            while (year != 0);

            Console.ReadKey();

        }
    }
}
