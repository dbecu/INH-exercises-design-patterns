using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book(string title, float price, int numberOfItems, string author)
            : base (title, price, numberOfItems)
        {
            Author = author;
        }

        public override string ToString()
        {
            return String.Format($"[Book] {Author} - {Title}, {Price.ToString("0.00")} ({NumberOfItems}x)");
        }
    }
}
