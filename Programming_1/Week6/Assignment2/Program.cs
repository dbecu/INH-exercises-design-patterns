using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;

            while (input != 0)
            {
                try
                {
                    Console.Write("Enter a number (0 is stop value): ");
                    input = int.Parse(Console.ReadLine());
                    if (input == 0)
                    {
                        Console.WriteLine("End of program. Bye!");
                        break;
                    }
                    if (input < 0)
                        Console.WriteLine("Negative number entered...");
                    else if (isPrimeNumber(input))
                        Console.WriteLine("{0} is a prime number!", input);
                    else
                        Console.WriteLine("{0} is not a prime number!", input);
                }
                catch(Exception e)
                {
                    Console.WriteLine("You didn't even try! :(");
                    Console.WriteLine("Error: " + e.Message);
                }

            }
            
        }

        public static bool isPrimeNumber(int input)
        {

            for (int i = 2; i < input - 1; i++)
            {
                if (input % i == 0)
                    return false;
            }

            return true;
        }
    }
}
