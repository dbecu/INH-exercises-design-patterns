using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int index = 0;

            Console.Write("Enter target number: ");
            double target = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Enter a number: ");
                num = double.Parse(Console.ReadLine());
                if (num == target)
                    index++;

            }
            while (num != 0);

            Console.Write("Count of numbers equal to target number: " + index);
            Console.ReadKey();

        }
    }
}
