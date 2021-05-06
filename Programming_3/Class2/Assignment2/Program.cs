using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            Console.WriteLine("\n\n\nSHUFFLE\n\n\n");

            deck.Shuffle();
            deck.Print();
        }
    }
}
