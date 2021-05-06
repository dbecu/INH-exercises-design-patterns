using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            BookStore bookStore = new BookStore();
            bookStore.Add(new Book("Dracula", "Bram Stoker", 15.00));
            bookStore.Add(new Book("Joe speedboot", "Tommy Wieringa", 12.50));
            bookStore.Add(new Magazine("Time", 3.90, "Friday"));
            bookStore.Add(new Magazine("Donald Duck", 2.50, "Thursday"));
            bookStore.Add(new Book("The hobbit", "J.R.R Tolkier", 12.50));



            bookStore.PrintCompleteStock();
        }
    }
}
