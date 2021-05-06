using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 1;
            int secondNum = 1;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("{0}, {1}, ", firstNum, secondNum);

                firstNum = firstNum + secondNum;
                secondNum = firstNum + secondNum;
            }


            Console.ReadKey();
        }
    }
}
