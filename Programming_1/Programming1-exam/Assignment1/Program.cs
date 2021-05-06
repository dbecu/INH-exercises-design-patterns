using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your number of exemption ECs: ");
            int ex = int.Parse(Console.ReadLine());

            Console.Write("Enter your total number of ECs (of the first year): ");
            int totalec = int.Parse(Console.ReadLine());

            double min = 0.75 * (60 - ex) + ex;
            Console.WriteLine("(Minimum required ECs to go to the 2nd year: {0})", min);

            Console.WriteLine();

            if (totalec >= min)
                Console.WriteLine("{0}, you have enough ECs to go to 2nd year.", name);
            else
                Console.WriteLine("{0}, you don't have enough ECs to go to 2nd year.", name);

            Console.ReadKey();

        }
    }
}
