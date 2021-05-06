using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    //The subject, 'the weather station', the main source 
    //What all the smaller things are connected to
    //This is the class that's OBSERVED, so all the smaller observers observe this class for changes
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NextSong();
    }
}
