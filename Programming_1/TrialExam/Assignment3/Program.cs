using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = new string[20];
            int count = 0;
            string input;

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write("Enter a word: ");
                input = Console.ReadLine();

                if (input.Length == 0)
                    j = array.Length;
                else
                {
                    array[j] = input;
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (array[i].Length % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(array[i]);
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("End of program");
            Console.ReadKey();


        }
    }
}
