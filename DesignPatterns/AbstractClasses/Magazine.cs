using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek ReleaseDay { get; set; }

        public Magazine(string title, float price, int numberOfItems, DayOfWeek releaseDay)
            : base(title, price, numberOfItems)
        {
            ReleaseDay = releaseDay;
        }

        public override string ToString()
        {
            return String.Format($"[Magazine] {Title} - {ReleaseDay}, {Price.ToString("0.00")} ({NumberOfItems}x)");
        }
    }
}
