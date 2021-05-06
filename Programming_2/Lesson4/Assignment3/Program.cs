using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment3
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
            Console.WriteLine("1: 2018 Trump tweets; 2: 2019 Trump tweets");
            Console.Write("Enter your choice: ");
            string filename;
            if (int.Parse(Console.ReadLine()) == 1)
                filename = "tweets-donaldtrump-2018.txt";
            else
                filename = "tweets-donaldtrump-2019.txt";

            Console.Write("Enter searched word: ");
            string searchWord = Console.ReadLine();


            int amountOfWordOccurence = SearchWordInFile(filename, searchWord);

            Console.WriteLine($"Amount of times {searchWord} appeared: {amountOfWordOccurence}");
        }

        bool WordInLine(string line, string word)
        {
            return line.ToLower().Contains(word.ToLower());
        }

        int SearchWordInFile(string filename, string word)
        {
            int counter = 0;

            StreamReader reader = new StreamReader(filename);

            while(!reader.EndOfStream)
            {
                string currentLine = reader.ReadLine();
                if (WordInLine(currentLine, word))
                {
                    DisplayWordInLine(currentLine, word);

                    Console.WriteLine();
                    counter++;
                }
            }

            return counter;
        }

        void DisplayWordInLine(string line, string word)        //debug keep repeating!!
        {            
            int start = line.ToLower().IndexOf(word.ToLower());
            string remainingString = line;

            if (start > 0)
            {
                string beforeRedWord;
                string redWord;

                while (remainingString.ToLower().Contains(word.ToLower()))
                {
                    start = remainingString.ToLower().IndexOf(word.ToLower());

                    beforeRedWord = remainingString.Substring(0, start);
                    redWord = remainingString.Substring(start, word.Length);
                    remainingString = remainingString.Substring(start + word.Length, remainingString.Length - (start + word.Length));

                    Console.Write(beforeRedWord);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(redWord);

                    Console.ResetColor();
                }

                Console.Write(remainingString);

                Console.WriteLine();

            }


        }

    }
}
