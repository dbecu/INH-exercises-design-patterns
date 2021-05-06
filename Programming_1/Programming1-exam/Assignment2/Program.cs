using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = 42;

            while (number > 1)
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());

                int calcNum = number;

                int factor = 2;

                while (factor <= calcNum)
                {
                    if (calcNum % factor == 0)
                    {
                        Console.Write(factor + " ");
                        calcNum = calcNum / factor;
                    }
                        
                    else
                        factor++;

                }

                Console.WriteLine();

            }

            Console.WriteLine("End of program");
            Console.ReadKey();
        }
    }
}
