using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        public string author;
        public Book(string title, string author, double price)
            : base(title, price)
        {
            this.author = author;
        }

        //public void Print()
        //{
        //    Console.WriteLine("'{0}' by {1}, {2:0.00}", title, author, price);
        //}

        public override string ToString()
        {
            string temp = String.Format("[Book] '{0}' by {1}, {2:0.00}", title, author, price);
            
            return temp;
        }
    }
}
