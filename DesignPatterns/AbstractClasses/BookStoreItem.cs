using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem(string title, float price, int numberOfItems)
        {
            Title = title;
            Price = price;
            NumberOfItems = numberOfItems;
        }

        public override string ToString()
        {
            return String.Format($"[BookStoreItem] {Title}, {Price.ToString("0.00")} {NumberOfItems}x");
        }
    }
}
