using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //Just a class
    public class TrainStation
    {
        public string Name { get; private set; }
        public string ArrivalTrack { get; private set; }
        public DateTime ArrivalTime { get; private set; }
        public DateTime DepartureTime { get; private set; }

        public TrainStation(string name, string arrivalTrack, DateTime arrivalTime, DateTime departureTime)
        {
            Name = name;
            ArrivalTrack = arrivalTrack;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
        }

        public override string ToString()
        {
            return String.Format($"Station Name: {Name} \nArrival Track: {ArrivalTrack} \n" +
                $"Arrival Time: {ArrivalTime.ToString("HH:mm")} \n" +
                $"Departure Time: {DepartureTime.ToString("HH:mm")}");
        }

    }
}
