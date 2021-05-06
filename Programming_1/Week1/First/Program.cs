using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("\nWelcome " + name + "!");

            if (name.Equals("Dewi"))
            {
                Console.WriteLine("Hell yeah.");
            }
        }
    }
}
