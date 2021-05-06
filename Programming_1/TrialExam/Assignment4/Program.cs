using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(0, 10);
            int factorialNumber;

            while (randomNumber > 0)
            {
                factorialNumber = Factorial(randomNumber);
                Console.WriteLine("Factorial of {0} is {1}", randomNumber, factorialNumber);

                randomNumber = rand.Next(0, 10);
            }

            Console.WriteLine();
            Console.WriteLine("End of program");
            Console.ReadKey();

        }


        static int Factorial(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;
        }

    }
}
