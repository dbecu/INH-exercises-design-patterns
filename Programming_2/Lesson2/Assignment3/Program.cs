using System;

namespace Assignment3
{

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
            RegularCandies[,] playingField = new RegularCandies[9,9];
            InitCandies(playingField);
            DisplayCandies(playingField);

            Console.WriteLine("Note: [row,column]");

            if (ScoreRowPresent(playingField))
                Console.WriteLine("GOOD! ROW SCORE!!!");
            else
                Console.WriteLine("BIG RIP BOI, NO ROWS FOUND!");

            if (ScoreColumnPresent(playingField))
                Console.WriteLine("GOOD! COL SCORE!!!");
            else
                Console.WriteLine("LOSER!! NO COLUMNS FOUND!");



        }

        void InitCandies(RegularCandies[,] rc)
        {
            for(int row = 0; row < rc.GetLength(0); row++)
            {
                for(int col = 0; col < rc.GetLength(1); col++)
                {
                    rc[row, col] = (RegularCandies)rand.Next(1, 7);
                }
            }
        }

        void DisplayCandies(RegularCandies[,] rc)
        {
            for (int row = 0; row < rc.GetLength(0); row++)
            {
                for (int col = 0; col < rc.GetLength(1); col++)
                {
                    int color = (int)rc[row, col];
                    switch (color)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkYellow; //Orange
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                            break;

                    }

                    Console.Write("# ");

                    Console.ResetColor();
                }
                    

                Console.WriteLine();
            }

        }

        //bool ScoreRowPresentBad(RegularCandies[,] rc)
        //{

        //    RegularCandies currentCandy;
        //    int counter;

        //    for (int row = 0; row < rc.GetLength(0) - 3; row++)
        //    {
        //        for (int col = 0; col < rc.GetLength(1); col++)
        //        {
        //            counter = 0;
        //            currentCandy = rc[row, col];


        //            if(row + 2 < rc.GetLength(0))
        //                if (rc[row, col].Equals(rc[row + 1, col]) && (rc[row, col].Equals(rc[row + 2, col])))
        //                {
        //                    Console.WriteLine($"{row},{col}");

        //                    return true;
        //        }
        //    }

        //    return false;       
        //}

        //bool ScoreRowPresent(RegularCandies[,] rc)
        //{

        //    RegularCandies currentCandy = rc[0, 0];
        //    int counter = 1;
        //    int temp = 0;

        //    for (int row = 0; row < rc.GetLength(0); row++)
        //    { 


        //        temp += counter;

        //        currentCandy = rc[row, temp];
        //        if (currentCandy == rc[row, temp])
        //        {
        //            debug = temp + counter;
        //            counter++;
        //        }


        //        if (counter >= 3)
        //        {

        //            Console.WriteLine($"{row},{debug}");
        //            return true;

        //        }

        //        else
        //        {
        //            counter = 1;

        //        }

        //    }
        //    return false;
        //}

        bool ScoreRowPresent(RegularCandies[,] rc)
        {

            int counter = 1;
            int tempRow = -1;
            int tempCol = -1;
            RegularCandies currentCandy;


            for (int row = 0; row < rc.GetLength(0); row++)
            {
                currentCandy = RegularCandies.NoCandy;

                for (int col = 0; col < rc.GetLength(1); col++)
                {
                    if (counter >= 3)
                    {
                        Console.Write("[{0},{1}] --> ", tempRow, tempCol);
                        return true;
                    }
                        

                    if (currentCandy.Equals(rc[row, col]))
                    {
                        counter++;
                        continue;
                    }

                    currentCandy = rc[row, col];
                    tempRow = row;
                    tempCol = col;
                    counter = 1;

                }
            }

            return false;
        }


        bool ScoreColumnPresent(RegularCandies[,] rc)
        {

            int counter = 1;
            int tempRow = -1;
            int tempCol = -1;
            RegularCandies currentCandy;

            for (int col = 0; col < rc.GetLength(1); col++)
            {
                currentCandy = RegularCandies.NoCandy;

                for (int row = 0; row < rc.GetLength(0); row++)
                {
                    if (counter >= 3)
                    {
                        Console.Write("[{0},{1}] --> ", tempRow, tempCol);
                        return true;
                    }


                    if (currentCandy.Equals(rc[row, col]))
                    {
                        counter++;
                        continue;
                    }

                    currentCandy = rc[row, col];
                    tempRow = row;
                    tempCol = col;
                    counter = 1;

                }
            }

            return false;
        }





    }
}
