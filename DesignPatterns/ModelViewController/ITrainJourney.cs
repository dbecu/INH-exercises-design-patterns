using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    //Observable
    //The Model
    public interface ITrainJourney
    {

        //TrainJourney will be controlled with this method
        void NextTrainStation();

        //Add how many observers we want
        void AddObserver(ITrainDisplay observer);
        void RemoveObserver(ITrainDisplay observer);
    }
}
