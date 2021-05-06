using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class DeckOfCards
    {
        public List<PlayingCard> playingCards;

        public DeckOfCards()
        {
            InitCards();
        }

        private void InitCards()
        {
            playingCards = new List<PlayingCard>();
            foreach(CardSuit cardSuit in Enum.GetValues(typeof(CardSuit)))
            {
                for (int i = 1; i <= 13; i++)
                    playingCards.Add(new PlayingCard(cardSuit, i));
            }
        }

        public void Print()
        {
            foreach (PlayingCard playingCard in playingCards)
                Console.WriteLine(playingCard.ToString());
        }

        public void Shuffle()
        {
            //List<PlayingCard> shuffledList = new List<PlayingCard>();
            //Random rand = new Random();
            //PlayingCard playingCard;
            //while(shuffledList.Count != 52)
            //{

            //    playingCard = new PlayingCard((CardSuit)(rand.Next(0, 4)), rand.Next(1, 14));
            //    if (!(shuffledList.Exists(p => p.rank == playingCard.rank)) 
            //        || !(shuffledList.Exists(p => p.suit == playingCard.suit)))
            //        shuffledList.Add(playingCard);

            //}


            List<PlayingCard> shuffledList = new List<PlayingCard>();
            Random rand = new Random();
            int index;
            while(playingCards.Count > 0)
            {
                index = rand.Next(0, playingCards.Count);
                shuffledList.Add(playingCards[index]);
                playingCards.RemoveAt(index);

            }

            playingCards = shuffledList;

        }
    }
}
