using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            string strPrice = Console.ReadLine();
            double price = int.Parse(strPrice);
            double vatPrice = price * 0.21;
            double priceAndVAT = price + vatPrice;

            Console.WriteLine("Price: {0}, VAT: {1}, Total: {2}", price, vatPrice, priceAndVAT);
        }
    }
}
