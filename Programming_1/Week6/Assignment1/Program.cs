using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            float input = float.Parse(Console.ReadLine());

            Console.WriteLine("Price: {0}, VAT: {1}, Total: {2}", 
                input.ToString("0.00"), calculate(input).ToString("0.00"), (input + calculate(input)).ToString("0.00"));

            Console.ReadKey();
        }

        public static float calculate(float input)
        {
            return input * 0.21f;
        }
    }
}
