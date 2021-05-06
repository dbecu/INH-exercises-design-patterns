using System;

namespace Assignment1
{
    class Enumerations
    {

        //DayOfWeek is basically an object from a class, without needing an actual class.
        //And the terms in the 'class' are the "privates" defined at the beginning, with (by default)
        //ints assigned to them, starting with 0.

        public enum DayOfWeek
        {
            //These are all object DayOfWeek from class DayOfWeek
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        static void notMain(string[] args)
        {
            bool result1 = IsWeekend(DayOfWeek.Monday);
            //bool result2 = IsWeekend(2);      won't work. Gotta be type DayOfWeek.


            //Since DayOfWeek is an enum, it can also be considered as a number. Hence the reason this worls
            for (DayOfWeek day = DayOfWeek.Sunday; day <= DayOfWeek.Saturday; day++)
            {
                Console.WriteLine(day);
                Console.WriteLine( );
            }
        }


        public static bool IsWeekend(DayOfWeek day)
        {
            return ((day == DayOfWeek.Saturday) || (day == DayOfWeek.Sunday));
        }

        
    }
}
