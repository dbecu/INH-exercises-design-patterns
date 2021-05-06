using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    //The subject, 'the weather station', the main source 
    //What all the smaller things are connected to
    class MP3Player : IObservable
    {
        private List<Song> songList = new List<Song>() { 
            new Song("Pink Floyd", "Wish You Were Here", 3.12f),
            new Song("Led Zeppelin", "Dazed and Confused", 4f),
            new Song("Bruno Mars", "Billionaire", 3.33f)};

        private List<IObserver> observers = new List<IObserver>();

        public Song CurrentSong { get; private set; }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NextSong()
        {
            Random rand = new Random();
            CurrentSong = songList[rand.Next(0, songList.Count)];

            NotifyObervers();
        }

        private void NotifyObervers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(CurrentSong);
            }
        }
    }
}
