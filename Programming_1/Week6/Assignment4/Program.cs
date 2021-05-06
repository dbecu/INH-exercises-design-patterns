using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text> ");
            searchText(Console.ReadLine());

        }

        public static void searchText(string text)
        {

            int fullStop = 0;
            int comma = 0;
            int semiColon = 0;

            for(int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '.':
                        fullStop++;
                        break;
                    case ',':
                        comma++;
                        break;
                    case ';':
                        semiColon++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Result: {0} full stop(s), {1} comma(s), {2} semicolon(s)", fullStop, comma, semiColon);
        }
    }
}
