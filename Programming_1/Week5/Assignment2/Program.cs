using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] array = new int[20];
            const int BOUND = 200;
            double lowest = BOUND + 1;
            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = rand.Next(0, BOUND);

                if (array[i] == lowest)
                    count++;

                if (array[i] < lowest)
                    lowest = array[i];

                Console.WriteLine("Element {0} = {1}", i, array[i]);

            }

            Console.WriteLine();

            Console.WriteLine("Smallest number = {0}", lowest);
            Console.WriteLine("Number of occurence = {0}", count);

            Console.ReadKey();
        }
    }
}
