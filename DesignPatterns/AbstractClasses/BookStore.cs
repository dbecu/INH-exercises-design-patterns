using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class BookStore
    {
        private List<BookStoreItem> listBookStoreItems;

        public BookStore()
        {
            listBookStoreItems = new List<BookStoreItem>();
        }
        public void Add(BookStoreItem item)
        {
            listBookStoreItems.Add(item);
        }

        public void PrintAllItems()
        {
            foreach(BookStoreItem item in listBookStoreItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
