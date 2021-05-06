using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Magazine : BookStoreItem
    {
        public string releaseDay;

        public Magazine(string title, double price, string releaseDay)
            : base(title, price) 
        {
            this.releaseDay = releaseDay;
        }

        public override string ToString()
        {
            string temp = 
                String.Format("[Magazine] {0} - release day:{1}, {2:0.00}", title, releaseDay, price);

            return temp;
        }

    }
}
