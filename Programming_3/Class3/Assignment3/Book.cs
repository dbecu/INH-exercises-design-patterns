using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        private string author;

        public string Author
        {
            get { return author; }
        }
        public Book(string title, string author, double price, int copies)
            : base(title, price, copies)
        {
            Title = title;
            this.author = author;
            Price = price;
        }

        //public void Print()
        //{
        //    Console.WriteLine("'{0}' by {1}, {2:0.00}", title, author, price);
        //}

        public override string ToString()
        {
            string temp = String.Format("[Book] '{0}' by {1}, {2:0.00} ({3}x)", Title, author, Price, Count);

            return temp;
        }
    }
}

