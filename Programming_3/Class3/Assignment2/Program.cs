using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer lionel = new Customer("Lionel Messi", new DateTime(1987, 6, 24));
            lionel.RegistrationDate = new DateTime(2020, 1, 1);
            lionel.PrintCustomer();

            Customer piet = new Customer("Piet Paulusma", new DateTime(1957, 2, 20));
            piet.RegistrationDate = new DateTime(2000, 1, 1);
            piet.PrintCustomer();


            List<Ticket> tickets = new List<Ticket>();
            tickets.Add(new Ticket("Bohemian Rapsody", 1, new DateTime(2019, 2, 23, 21, 30, 0), 10.50m, 6));
            tickets.Add(new Ticket("The Progidy", 4, new DateTime(2019, 2, 23, 21, 0, 0), 10.50m, 16));
            tickets.Add(new Ticket("Green Book", 5, new DateTime(2019, 2, 25, 19, 0, 0), 10.50m, 12));

            Reservation r1 = new Reservation(lionel, tickets);
            r1.PrintReservation();


            Reservation r2 = new Reservation(piet, tickets);
            r2.PrintReservation();



        }
    }
}
