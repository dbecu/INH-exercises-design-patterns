using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            int input;

            do
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());      //parsed inputted value into an int and stores in variable name input

                string result = "";

                if (input > 0)          //this is meh :/ redundant
                {
                    for (int i = 1; i <= input; i++)
                    {

                        if (i <= input / 2)
                            result = result + '*';
                        else
                            result = result + '!';

                    }
                }

                Console.WriteLine(result);

            } while (input > 0);

            Console.WriteLine("End of programme");
            Console.ReadKey();




        }
    }
}
