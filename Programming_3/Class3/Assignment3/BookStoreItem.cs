using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class BookStoreItem
    {
        private string title;
        private double price;
        private int copies;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return copies; }
            set { copies = value;  }
        }

        public double TotalPrice
        {
            get { return price * copies; }
        }

        public BookStoreItem(string title, double price, int copies)
        {
            this.title = title;
            this.price = price;
            this.copies = copies;
        }

    }
}
