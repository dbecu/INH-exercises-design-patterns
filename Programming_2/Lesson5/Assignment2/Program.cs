using System;
using System.IO;
using CandyCrushLogic;

namespace Assignment2
{

    class Program
    {

        const int ROWSIZE = 9;
        const int COLSIZE = 9;
        const string FILENAME = "candy.txt";

        Random rand = new Random();
        static void Main(string[] args)
        {

            Program myProgram = new Program();
            myProgram.Start();

        }

        void Start()
        {
            RegularCandies[,] playingField = new RegularCandies[ROWSIZE, COLSIZE];
            //InitCandies(playingField);

            //if file exists 
            //        code
            //else
            //    the stuff in catch
            try
            {
                playingField = ReadPlayingField(FILENAME);  //made a try catch in here, is that fine?
            }
            catch (Exception e)
            {
                Console.WriteLine("Yikes!! " + e.Message);
                Console.WriteLine("Made a new candy field!");
                InitCandies(playingField);
                WritePlayingField(playingField, FILENAME);
            }


            //WritePlayingField(playingField, "candy.txt");
            DisplayCandies(playingField);

            Console.WriteLine("Note: [row,column]");

            if (CandyCrusher.ScoreRowPresent(playingField))
                Console.WriteLine("GOOD! ROW SCORE!!!");
            else
                Console.WriteLine("BIG RIP BOI, NO ROWS FOUND!");

            if (CandyCrusher.ScoreColumnPresent(playingField))
                Console.WriteLine("GOOD! COL SCORE!!!");
            else
                Console.WriteLine("LOSER!! NO COLUMNS FOUND!");





        }

        void InitCandies(RegularCandies[,] rc)
        {
            for (int row = 0; row < rc.GetLength(0); row++)
            {
                for (int col = 0; col < rc.GetLength(1); col++)
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



        void WritePlayingField(RegularCandies[,] playingField, string filename)
        {


            StreamWriter writer = new StreamWriter(filename);       //opening

            string line;

            for (int row = 0; row < playingField.GetLength(0); row++)
            {
                line = "";

                for (int col = 0; col < playingField.GetLength(1); col++)
                    line += (int)playingField[row, col] + " ";

                writer.WriteLine(line);
            }

            writer.Close();     //closing, has to!


        }

        RegularCandies[,] ReadPlayingField(string filename)
        {
            RegularCandies[,] playingField = new RegularCandies[ROWSIZE, COLSIZE];

            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);

                try
                {


                    string line;
                    string[] numberStrings;

                    for (int row = 0; row < playingField.GetLength(0); row++)
                    {
                        line = reader.ReadLine();
                        numberStrings = line.Split(' ');

                        for (int col = 0; col < playingField.GetLength(1); col++)
                        {
                            playingField[row, col] = (RegularCandies)int.Parse(numberStrings[col]);
                        }

                    }

                }
                catch
                {
                    reader.Close();
                    throw;
                }

                reader.Close();

            }

            return playingField;
        }

    }
}
