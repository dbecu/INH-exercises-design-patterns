using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Player
    {
        //rand
        public string name;
        public List<PlayingCard> playingCards;

        public Player(string name)
        {
            //rand
            this.name = name;
            playingCards = new List<PlayingCard>();
        }

        public void AddCard(PlayingCard card)
        {
            playingCards.Add(card);
        }

        public PlayingCard GetNextCard()
        {
            PlayingCard card = playingCards[0];
            playingCards.RemoveAt(0);

            return card;
        }


    }
}
