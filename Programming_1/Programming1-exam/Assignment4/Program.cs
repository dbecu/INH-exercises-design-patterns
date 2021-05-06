using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int num1 = rand.Next(1, 50);
                int num2 = rand.Next(1, 5);

                Console.WriteLine("{0} /{1} = {2} ({3})", 
                    num1.ToString().PadLeft(2), 
                    num2.ToString().PadLeft(2),
                    IntegerDivision(num1, num2, out int quotient).ToString().PadLeft(2), 
                    quotient.ToString());

            }

            Console.WriteLine();
            Console.WriteLine("End of program");
            Console.ReadKey();


        }

        static int IntegerDivision(int number1, int number2, out int rest)
        {

            int quotient = 0;

            while(number1 - number2 >= 0)
            {
                number1 -= number2;
                quotient++;
            }

            rest = number1;

            return quotient;



        }
    }
}
