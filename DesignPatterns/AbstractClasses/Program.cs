using System;

namespace AbstractClasses
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

            bookStore.Add(new Book("Dracula", 15, 5, "Bram Stoker"));
            bookStore.Add(new Book("Joe speedboat", 12.50f, 3, "Tommy Wieringa"));
            bookStore.Add(new Magazine("Time", 3.90f, 10, DayOfWeek.Friday));
            bookStore.Add(new Magazine("Donald Duck", 2.50f, 15, DayOfWeek.Thursday));
            bookStore.Add(new CD("The Cure", 3.90f, 5, "Seventeen Seconds"));

            bookStore.PrintAllItems();
        }
    }
}
