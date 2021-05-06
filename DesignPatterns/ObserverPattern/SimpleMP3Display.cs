using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    //The class that looks at the observable for changes
    class SimpleMP3Display : IObserver
    {
        private IObservable observable;
        public SimpleMP3Display(IObservable observable)
        {
            this.observable = observable;
            observable.AddObserver(this);
        }
        
        public void Update(Song song)
        {
            Console.WriteLine($"Simple display: {song.Artist} - '{song.SongName}'");
        }
    }
}
