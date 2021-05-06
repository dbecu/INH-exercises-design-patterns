using System;

namespace Assignment3
{
    class Program
    {
        const int ARRAYSIZE = 20;
        const int MINVALUE = 0;
        const int MAXVALUE = 100;

        static void Main(string[] args)
        {

            Random rand = new Random();

            int[] randomArray = new int[ARRAYSIZE];

            int min = MAXVALUE;
            int max = MINVALUE;

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rand.Next(MINVALUE, MAXVALUE);

                if (randomArray[i] < min)
                    min = randomArray[i];
                if (randomArray[i] > max)
                    max = randomArray[i];

            }

            Console.WriteLine("Minimum value: {0}", min);
            Console.WriteLine("Maximum value: {0}", max);

            for (int i = 0; i < randomArray.Length; i++)
            {

                if (randomArray[i] > min + 20 && randomArray[i] < max - 20)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (randomArray[i] > min + 10 && randomArray[i] < max - 10)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else 
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(randomArray[i] + " ");

            }

            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
