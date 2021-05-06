using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class WarCardGame : CardGame
    {
        public Player player1;
        public Player player2;

        public WarCardGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            deck = new DeckOfCards();
        }

        public void StartNewGame()
        {
            deck.Shuffle();
            int index = 1;

            DeckOfCards tempDeck = new DeckOfCards();
            tempDeck.playingCards.RemoveRange(0, tempDeck.playingCards.Count);

            for(int i = 0; i < deck.playingCards.Count; i++)
                tempDeck.playingCards.Add(deck.playingCards[i]);

            while(tempDeck.playingCards.Count > 0)
            {
                if (index % 2 == 0)
                    player1.AddCard(tempDeck.playingCards[0]);
                else
                    player2.AddCard(tempDeck.playingCards[0]);

                tempDeck.playingCards.RemoveAt(0);
                index++;
            }

        }

        public bool EndOfGame()
        {
            return (player1.playingCards.Count == 0) || (player2.playingCards.Count == 0);
        }

        public void NextCard()
        {
            PlayingCard cardPlayer1 = player1.GetNextCard();
            PlayingCard cardPlayer2 = player2.GetNextCard();
            Console.WriteLine($"[{player1.name}] {cardPlayer1.ToString()} - [{player2.name}] {cardPlayer2.ToString()}");

            if (cardPlayer1.rank == cardPlayer2.rank)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost...\n" +
                    $"cards left: [{player1.name}] {player1.playingCards.Count}x, [{player2.name}] {player2.playingCards.Count}x");
                
            }
            else if (cardPlayer1.rank > cardPlayer2.rank)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player1.name} got the cards");
                player1.AddCard(cardPlayer1);
                player1.AddCard(cardPlayer2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{player2.name} got the cards");
                player2.AddCard(cardPlayer2);
                player2.AddCard(cardPlayer1);
            }

            Console.ResetColor();
        }
    }
}
