using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class CD : BookStoreItem
    {
        public string Artist { get; set; }

        public CD(string title, float price, int numberOfItems, string artist)
            : base(title, price, numberOfItems)
        {
            Artist = artist;
        }

        public override string ToString()
        {
            return String.Format($"[CD] {Title} - {Artist}, {Price.ToString("0.00")} ({NumberOfItems}x)");
        }
    }
}
