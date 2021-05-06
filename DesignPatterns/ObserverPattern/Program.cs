using System;

namespace ObserverPattern
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
            // create an MP3 player
            IObservable player = new MP3Player();

            // create the displays
            IObserver mp3Display1 = new SimpleMP3Display(player);
            IObserver mp3Display2 = new FancyMP3Display(player);
            // change song a few times
            // (since there is no hardware, we do it hardcoded here...)

            //Each observer will be notified of the next songs
            player.NextSong();
            player.NextSong();
            player.NextSong();
            Console.ReadKey();
        }
    }
}