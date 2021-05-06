using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Reservation
    {
        private int id;

        public Book Book
        {
            get; set;
        }

        public Customer Customer
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public DateTime ResevationDateTime
        {
            get; set;
        }

        public Reservation(int id, Customer customer, Book book)
        {
            this.id = id;
            Customer = customer;
            Book = book;

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
