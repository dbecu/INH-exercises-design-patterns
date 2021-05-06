using System;

namespace Tami
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();


            int number = p.add(1, 2);
            p.sub(number, 8);

        }

        // (a + b) - c

        // a + b

        int add(int a, int b)
        {
            return a + b;
        }

        void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }


    }
}
