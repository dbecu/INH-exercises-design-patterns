using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class BookStore
    {
        private List<BookStoreItem> bookStoreItems;

        public List<BookStoreItem> BookStoreItems
        {
            get; set;
        }

        public BookStore()
        {
            bookStoreItems = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem item)
        {
            bookStoreItems.Add(item);
        }


        public void PrintCompleteStock()
        {
            double totalPrice = 0;
            foreach (BookStoreItem item in bookStoreItems)
            {
                Console.WriteLine(item);    //item here == item.toString();
                totalPrice += item.TotalPrice;
            }

            Console.WriteLine($"\nTotal sales price: {totalPrice:0.00}");
        }
    }
}
