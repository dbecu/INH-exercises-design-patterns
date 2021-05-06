using System;

namespace Assignment0
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

        }

        void Start()
        {
            int value = ReadInt("Enter a value: ");
            Console.WriteLine("You entered {0}.", value);

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", age);

            string name = ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}.", name);

            ReadString("What is your name? ", out string message);
            Console.WriteLine(message);

            Console.ReadKey();
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }

        int ReadInt(string question, int min, int max)
        {
            int num;

            do
            {
                num = ReadInt(question);

            } while (!(num >= min && num <= max));

            return num;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        void ReadString(string question1, out string message)
        {
            Random rand = new Random();

            string name = ReadString(question1);

            int randomValue = rand.Next(1, 4);
            switch (randomValue)
            {
                case 1:
                    message = String.Format("Nice meeting you {0}!", name);
                    break;
                case 2:
                    message = String.Format("Get outta heeeereee...!");
                    break;
                case 3:
                    message = String.Format("What's up {0}??!!", name);
                    break;
                default:
                    message = "How did you get here...?";
                    break;
            }


            
        }
    }
}
