using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double num;
            int index = 0;

            do
            {
                Console.Write("Enter a number: ");
                num = double.Parse(Console.ReadLine());
                if (num > 0)
                {
                    total += num;
                    index++;
                }
                    
            }
            while (num != 0);

            Console.Write("Average of all positive numbers is: ");
            if(index > 0)
                Console.WriteLine((total / index).ToString("0.00"));
            else
                Console.WriteLine(total.ToString("0.00"));

            Console.ReadKey();


        }
    }
}
