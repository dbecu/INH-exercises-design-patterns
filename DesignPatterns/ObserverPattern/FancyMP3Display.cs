using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    //The class that looks at the observable for changes
    class FancyMP3Display : IObserver
    {
        private IObservable observable;
        public FancyMP3Display(IObservable observable)
        {
            this.observable = observable;
            observable.AddObserver(this);
        }

        public void Update(Song song)
        {
            Console.WriteLine($"Fancy display: '{song.SongName}' - {song.Artist} ({song.Time.ToString("00.00")})");
        }
    }
}
