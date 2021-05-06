using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Observers
    //The View
    public interface ITrainDisplay
    {
        void Update(TrainStation currentTrainStation);
    }
}
