using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Magazine : BookStoreItem
    {
        private string releaseDay;

        public string ReleaseDay
        {
            get; set;
        }

        public Magazine(string title, double price, string releaseDay, int copies)
            : base(title, price, copies)
        {
            this.releaseDay = releaseDay;
        }

        public override string ToString()
        {
            string temp =
                String.Format("[Magazine] {0} - release day:{1}, {2:0.00} ({3}x)", Title, releaseDay, Price, Count);

            return temp;
        }

    }
}
