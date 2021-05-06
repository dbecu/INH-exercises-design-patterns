using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] array = new int[20];
            double sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 200);
                sum += array[i];

                Console.WriteLine("Element {0} is {1}", i + 1, array[i]);

            }

            double average = sum / 20;

            Console.WriteLine();

            Console.WriteLine("The average is: {0}", average.ToString("0.00"));

            Console.WriteLine();




            for (int i = 0; i < array.Length; i++)
                Console.WriteLine("Difference between average " +
                    "and element {0} is {1}", i, Math.Abs(array[i] - average).ToString("0.00"));

            Console.ReadKey();
        }
    }
}
