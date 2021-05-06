using System;

namespace Assignment4
{

    public class Position
    {
        public int row;
        public int col;
    }
    public class Program
    {

        Random rand = new Random();

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            int[,] chessboard = new int[8, 8];
            InitChessboard(chessboard);
            PositionKnight(chessboard);
            DisplayChessboard(chessboard);
        }

        void InitChessboard(int[,] chessboard)
        {
            for(int row = 0; row < chessboard.GetLength(0); row++)
                for(int col = 0; col < chessboard.GetLength(1); col++)
                    chessboard[row, col] = 0;
            
        }

        void DisplayChessboard(int[,] chessboard)
        {
            int temp;

            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    temp = chessboard[row, col];

                    switch (temp)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("{0, 2}", ".");
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("{0, 2}", "*");
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0, 2}", "*");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("This should not be happening");
                            break;
                    }
                }

                Console.WriteLine();
            }

        }

        Position PositionKnight(int[,] chessboard)
        {
            Position myPosition = new Position();

            myPosition.row = rand.Next(0, chessboard.GetLength(0));   
            myPosition.col = rand.Next(0, chessboard.GetLength(1));

            chessboard[myPosition.row, myPosition.col] = 1;

            return myPosition;

        }

        void PossibleKnightMoves(int[,] chessboard, Position position)
        {
            Position tempPosition = new Position();

            for(int i = 0; i < 8; i++)
            {
                tempPosition.row = position.row + 3;
                tempPosition.col = position.col + 1;
            }
        }


    }
}
