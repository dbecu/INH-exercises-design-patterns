using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Reservation
    {
        private Customer customer;
        private List<Ticket> tickets;

        public Reservation(Customer customer, List<Ticket> tickets)
        {
            Customer = customer;
            Tickets = tickets;
        }

        public Customer Customer
        {
            get; set;
        }

        public List<Ticket> Tickets
        {
            get; set;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                double discount = 1;

                foreach(Ticket ticket in Tickets)
                {
                    if (ticket.Discount)
                        discount -= 0.05;
                    if (Customer.Age >= ticket.MinimumAge)
                        totalprice += ticket.Price*(decimal)discount;
                }

                if (Customer.Discount)
                    totalprice *= (decimal)0.9;

                return totalprice;
            }
        }

        public void PrintReservation()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"creating tickets for {Customer.Name}");
            Console.ResetColor();
            foreach(Ticket ticket in Tickets)
            {
                Console.WriteLine($"creating ticket {ticket}");
            }
            Console.WriteLine($"total price for reservation: {TotalPrice:0.00}\n");
            
        }
    }
}
