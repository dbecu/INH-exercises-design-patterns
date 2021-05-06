using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Reservation
    {
        private int id;
        private Book book;
        private Customer customer;

        public Book Book
        {
            get
            {
                return this.book;
            }

            set
            {
                this.book = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
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
            return String.Format($"{Id}. {Book.Title} reserved by {Customer.FullName}");
        }

    }
}
