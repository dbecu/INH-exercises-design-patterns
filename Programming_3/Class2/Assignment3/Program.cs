using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");
            // create game and play it
            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }
        static void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();

            Console.WriteLine();

            if (war.player1.playingCards.Count == 0)
                Console.WriteLine($"{war.player1.name} has won!");
            else
                Console.WriteLine($"{war.player2.name} has won!");

        }
    }
}
