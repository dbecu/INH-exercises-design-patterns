using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double num;
            int index = 1;

            do
            {
                Console.Write("Enter a number: ");
                num = double.Parse(Console.ReadLine());
                if (index % 5 == 0)
                    total += num;
              
                index++;

            }
            while (num != 0);

            Console.WriteLine("Sum of 5th, 10th, 15th, ... number is: " + total);

            Console.ReadKey();

        }
    }
}
