using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }

        public static int ReadInt(string question, int min, int max)
        {
            int num;

            do
            {
                num = ReadInt(question);

            } while (!(num >= min && num <= max));

            return num;
        }

        public static string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

    }
}
