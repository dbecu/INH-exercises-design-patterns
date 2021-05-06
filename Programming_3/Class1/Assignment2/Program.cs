using System;

namespace Assignment3
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
            //Dice d1 = new Dice();

            
            //for(int i = 0; i < 10; i++)
            //{
            //    d1.Throw();
            //    d1.DisplayValue();
            //}

            
            //YahtzeeGame yahtzeegame = new YahtzeeGame();
            //yahtzeegame.Init();

            //yahtzeegame.Throw();
            //yahtzeegame.DisplayValues();

            //yahtzeegame.Throw();
            //yahtzeegame.DisplayValues();


            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            PlayYahtzee(yahtzeeGame); // play the game

            Console.ReadKey();
        }

        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;

            do
            {
                game.Throw();
                game.DisplayValues();

                if (game.IsThreeOfAKind())
                {
                    game.ThreeOfAKind++;
                }
                if (game.IsFourOfAKind()) game.FourOfAKind++;
                if (game.IsFullHouse()) game.FullHouse++;
                if (game.IsSmallStreet()) game.SmallStreet++;
                if (game.IsBigStreet()) game.BigStreet++;


                nrOfAttempts++;

            } while (!game.Yahtzee());

            Console.WriteLine("Number of attempts needed (Yahtzee): {0}", nrOfAttempts);
            Console.WriteLine("Three of a Kind: {0}", game.ThreeOfAKind);
            Console.WriteLine("Four of a Kind: {0}", game.FourOfAKind);
            Console.WriteLine("Full House: {0}", game.FullHouse);
            Console.WriteLine("Small Street: {0}", game.SmallStreet);
            Console.WriteLine("Big Street: {0}", game.BigStreet);

            //Console.Write("Display statistics? (y/n): ");
            //if (Console.ReadLine().Equals("y"))
            //{
            //    game.DisplayStatistics();
            //}

        }
    }
}
