using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Ticket
    {
        private string movieName;
        private int cinemaRoom;
        private DateTime startTime;
        private decimal price;
        private int minimum;

        public Ticket(string movieName, int cinemaRoom, DateTime startTime, decimal price, int minimum)
        {
            MovieName = movieName;
            CinemaRoom = cinemaRoom;
            StartTime = startTime;
            Price = price;
            MinimumAge = minimum;
        }

        public string MovieName
        {
            get { return movieName; }
            set 
            {
                if (value.Length != 0)
                    movieName = value;
            }
        }

        public int CinemaRoom
        {
            get { return cinemaRoom; }
            set 
            {
                if (value == 1 || value == 2 || value == 3 || value == 4 || value == 5)
                    cinemaRoom = value;
                else
                {
                    Exception e = new Exception($"Error occured: Invalid cinema room ({value})!");
                    Console.WriteLine(e.Message);
                };
            }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                if (value.Minute % 30 == 0)
                    startTime = value;
                else
                {
                    Exception e = new Exception($"Error occured: Invalid start time ({value})!");
                    Console.WriteLine(e.Message);
                }
            }
        }

        public decimal Price
        {
            get; set;
        }

        public int MinimumAge
        {
            get { return minimum; }
            set
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16)
                    minimum = value;
                else
                {
                    Exception e = new Exception($"Error occured: Invalid minimum age ({value})!");
                    Console.WriteLine(e.Message);
                }
                    
            }
        }

        
        public bool Discount
        {
            get
            {
                return StartTime.DayOfWeek == DayOfWeek.Monday || StartTime.DayOfWeek == DayOfWeek.Tuesday;
            }
        }

        public override string ToString()
        {
            return String.Format($"'{MovieName}', starttime: {StartTime.DayOfWeek} " +
                $"price: {Price}, room: {CinemaRoom} ({MinimumAge}+)");
        }



    }
}
