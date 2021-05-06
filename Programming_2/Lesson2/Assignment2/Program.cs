using System;

namespace Assignment2
{


    public class Position
    {
        public int row;
        public int col;
    }

    class Program
    {
        Random rand = new Random();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

        }

        void Start()
        {

            int[,] test = new int[4, 4];

            Console.WriteLine("Execute InitMatrixRandom");
            InitMatrixRandom(test, 10, 40);

            Console.WriteLine("Execute DisplayMatrix");
            DisplayMatrix(test);

            Console.WriteLine("Execute DisplayMatrix");

            Console.Write("Enter a number (to search for): ");
            int search = int.Parse(Console.ReadLine());

            Position positionOfSearch = SearchNumber(test, search);
            Console.WriteLine("Number {0} is found at position [{1},{2}]",
                search, positionOfSearch.row, positionOfSearch.col);

            Position positionOfSearchBackwards = SearchNumberBackwards(test, search);
            Console.WriteLine("Number {0} is found at position [{1},{2}]",
                search, positionOfSearchBackwards.row, positionOfSearchBackwards.col);

            Console.ReadKey();


        }

        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = rand.Next(min, max);

        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write($"{matrix[row, col],3} ");

                Console.WriteLine();
            }
        }

        Position SearchNumber(int[,] matrix, int number)
        {
            Position position = new Position();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] == number)
                    {
                        position.row = row;
                        position.col = col;

                        return position;
                    }

                }
            }

            Console.WriteLine($"Number {number} is not in the matrix");
            return null;
        }

        Position SearchNumberBackwards(int[,] matrix, int number)   //debug!
        {

            Position position = new Position();

            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    if (matrix[row, col] == number)
                    {
                        position.row = row;
                        position.col = col;

                        return position;
                    }

                }
            }

            Console.WriteLine($"Number {number} is not in the matrix");
            return null;

        }
    }
}
