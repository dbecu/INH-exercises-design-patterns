using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            int[,] test = new int[11, 11];

            //Console.WriteLine("Execute InitMatrix");
            //InitMatrix(test);

            Console.WriteLine("Execute InitMatrixLinear");
            InitMatrixLinear(test);

            Console.WriteLine("Execute DisplayMatrix");
            DisplayMatrix(test);

            Console.WriteLine("Execute DisplayMatrixWithCross");
            DisplayMatrixWithCross(test);
        }

        void InitMatrix(int[,] matrix)
        {

            int num = 1;

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = num;
                    num++;
                }

            }
        }

        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    Console.Write($"{matrix[row, col], 3} ");

                Console.WriteLine();
            }
        }

        void InitMatrixLinear(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            double row, col;

            for (int i = 0; i < matrix.Length; i++)
            {
                col = i / rowLength;
                row = i - (col * rowLength);

                matrix[(int)col, (int)row] = i + 1;
            }
        }

        void DisplayMatrixWithCross(int[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                        Console.ForegroundColor = ConsoleColor.Red;

                    if (matrix.GetLength(0) - 1 - row == col)
                        Console.BackgroundColor = ConsoleColor.Yellow;

                    Console.Write($"{matrix[row, col], 3} ");

                    Console.ResetColor();
                }
                    

                Console.WriteLine();
            }
        }

        //int number = (row * matrix.GetLength(1) + col + 1)
        //bool exp = row + col == matrix.GetLength(1) -1;
    }
}
