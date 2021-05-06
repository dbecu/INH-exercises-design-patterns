using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    //The class that looks at the observable for changes
    public interface IObserver
    {
        void Update(Song song);
    }
}
