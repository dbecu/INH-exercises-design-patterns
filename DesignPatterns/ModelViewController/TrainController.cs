using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Controller -> interaction between model and view
    //Sometimes passes 1-on-1 to the model (TrainJourney)
    class TrainController : ITrainController
    {
        private ITrainJourney trainJourney;

        public TrainController(ITrainJourney controller)
        {
            this.trainJourney = controller;
        }

        //Sometimes passes 1-on-1 to the model (TrainJourney)
        public void NextTrainStation()
        {
            trainJourney.NextTrainStation();
        }
    }
}
