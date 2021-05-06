using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class PlayingCard
    {
        public CardSuit suit;
        public int rank;

        public PlayingCard(CardSuit suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string ToString()
        {

            string rankStr = rank.ToString();

            switch(rank)
            {
                case 1:
                    rankStr = "Ace";
                    break;
                case 11:
                    rankStr = "Jack";
                    break;
                case 12:
                    rankStr = "Queen";
                    break;
                case 13:
                    rankStr = "King";
                    break;
                default:
                    break;
            }

            return rankStr + " of " + suit;
        }

    }
}
