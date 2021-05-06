using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            int insert = -1;
            int index = 0;

            while (insert != 0)
            {
                Console.Write("Enter a number (0 = stop): ");
                insert = int.Parse(Console.ReadLine());
                numbers[index] = insert;
                index++;

                if (index > 19)
                    Console.WriteLine("Reached maximum capacity. Please enter '0'.");
            }

            Console.WriteLine();
            Console.Write("Enter a search value: ");
            int searchValue = int.Parse(Console.ReadLine());

            int occurences = 0;

            for (int i = 0; i < 20; i++)
            {
                if (numbers[i] == searchValue)
                    occurences++;
            }

            Console.WriteLine();
            Console.WriteLine("Number of occurences of search value ({0}) is: {1}", searchValue, occurences);

            Console.ReadKey();
        }
    }
}
