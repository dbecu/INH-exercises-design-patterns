using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Observable
    //Model
    class TrainJourney : ITrainJourney
    {
        private List<TrainStation> trainStationList;
        private bool toEnd;

        //List of observers
        private List<ITrainDisplay> trainDisplayObservers;

        public TrainStation CurrentTrainStation { get; private set; }

        public TrainJourney()
        {
            trainStationList = new List<TrainStation>();

            trainStationList.Add(new TrainStation("Haarlem", "5b", 
                new DateTime(1, 1, 1, 8, 30, 0), new DateTime(1, 1, 1, 8, 35, 0)));
            trainStationList.Add(new TrainStation("Leiden", "7b",
                new DateTime(1, 1, 1, 10, 0, 0), new DateTime(1, 1, 1, 10, 5, 0)));
            trainStationList.Add(new TrainStation("Delft", "1a",
                new DateTime(1, 1, 1, 14, 40, 0), new DateTime(1, 1, 1, 14, 50, 0)));

            CurrentTrainStation = trainStationList[0];

            toEnd = true;
            trainDisplayObservers = new List<ITrainDisplay>();
        }

        public void NextTrainStation()
        {

            //list.Reverse()

            int index = trainStationList.IndexOf(CurrentTrainStation);

            //switch direction?
            //if at the end
            if (toEnd && index + 1 >= trainStationList.Count)
            {
                toEnd = false;
            }
            //if at the start
            else if (!toEnd && trainStationList.IndexOf(CurrentTrainStation) <= 0)
            {
                toEnd = true;
            }
            
            //go to next station
            if (toEnd)
                index++;
            else
                index--;

            CurrentTrainStation = trainStationList[index];

            NotifyTrainStationObservers();

        }
        public void AddObserver(ITrainDisplay observer)
        {
            trainDisplayObservers.Add(observer);
            observer.Update(CurrentTrainStation);
        }

        public void RemoveObserver(ITrainDisplay observer)
        {
            trainDisplayObservers.Remove(observer);
        }

        private void NotifyTrainStationObservers()
        {
            foreach (ITrainDisplay trainDisplay in trainDisplayObservers)
            {
                trainDisplay.Update(CurrentTrainStation);
            }
        }

    }
}
