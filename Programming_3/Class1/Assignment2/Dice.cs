using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Dice
    {
        public int value;
        static Random rnd;

        public Dice(Random random)
        {
            //random = new Random();
            rnd = random;

        }
        public void Throw()
        {
            value = rnd.Next(1, 7);
        }

        public void DisplayValue()
        {
            Console.Write("{0} ", value);
        }

        //public string DisplayValue()
        //{
        //    string values = "";
        //    values += value + " ";

        //    return values;
        //}
    }
}
