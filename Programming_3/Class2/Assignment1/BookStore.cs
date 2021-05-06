using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class BookStore
    {
        public List<BookStoreItem> sookStoreItems;

        public BookStore()
        {
            sookStoreItems = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem item)
        {
            sookStoreItems.Add(item);
        }


        public void PrintCompleteStock()
        {
            foreach(BookStoreItem item in sookStoreItems)
            {
                Console.WriteLine(item);    //item here == item.toString();
            }
        }
    }
}
