using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 is preschool, 1 is child, 2 is adults
            int[,] categories = new int[3,10];

            int insert = -1;

            int[] index = new int[3];
            index[0] = 0; index[1] = 0; index[2] = 0;

            double[] avg = new double[3];
            avg[0] = 0; avg[1] = 0; avg[2] = 0;

            while (insert != 0)
            {
                Console.Write("Enter age (0 = stop): ");
                insert = int.Parse(Console.ReadLine());

                if (insert >= 1 && insert <= 3)
                {
                    categories[0, index[0]] = insert;
                    index[0]++;
                    avg[0] += insert;
                }
                else if (insert >= 4 && insert <= 17)
                {
                    categories[1, index[1]] = insert;
                    index[1]++;
                    avg[1] += insert;
                }
                else if (insert >= 18)
                {
                    categories[2, index[2]] = insert;
                    index[2]++;
                    avg[2] += insert;
                }

            }

            Console.WriteLine();

            string[] title = new string[3];
            title[0] = "Preschoolers"; title[1] = "Children"; title[2] = "Adults";

            string[] names = new string[3];
            names[0] = "Preschooler"; names[1] = "Child"; names[2] = "Adult";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(title[i].ToUpper());
                int forIndex = 0;

                while(categories[i, forIndex] != 0)
                {
                    Console.WriteLine("{0} {1} is {2} years old.", names[i], forIndex + 1, categories[i, forIndex]);
                    forIndex++;
                }

                Console.WriteLine("Average {0} is {1} years old", names[i].ToLower(), (avg[i] / index[i]).ToString("0.00"));

                double oldest = -1;
                for (int j = 0; j < 10; j++)
                {
                    if (categories[i, j] > oldest)
                        oldest = categories[i, j];
                }

                Console.WriteLine("Oldest {0} is: {1}", names[i].ToLower(), oldest);
                Console.WriteLine();

            }


            Console.ReadKey();
        }
    }
}
