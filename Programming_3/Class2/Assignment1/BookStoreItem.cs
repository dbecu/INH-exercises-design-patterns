using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class BookStoreItem
    {
        public string title;
        public double price;

        public BookStoreItem(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

    }
}
