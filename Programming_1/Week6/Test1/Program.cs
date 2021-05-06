using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(calc(float.Parse(Console.ReadLine())));
        }


        static float calc(float temp)
        {
            float returnValue = 0.21f * temp;
            return returnValue;
        }
    }
}
