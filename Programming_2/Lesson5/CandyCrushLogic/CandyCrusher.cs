using System;
using System.Collections.Generic;
using System.Text;

namespace CandyCrushLogic
{

    public class CandyCrusher
    {
        public static bool ScoreRowPresent(RegularCandies[,] rc)
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


        public static bool ScoreColumnPresent(RegularCandies[,] rc)
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
