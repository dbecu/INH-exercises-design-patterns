using System;
using System.Collections.Generic;
using System.IO;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dutch word: key
            //English word:value

            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            
            TranslateWords(ReadWords("dictionary.csv"));


        }

        static Dictionary<string, string> ReadWords(string filename)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] twoWords;

            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);       //opening

                while (!reader.EndOfStream)
                {
                    twoWords = reader.ReadLine().Split(';');
                    dictionary.Add(twoWords[0], twoWords[1]);
                }

                reader.Close();     //closing, has to!
            }
            return dictionary;
        }

        static void TranslateWords(Dictionary<string, string> words)
        {
            string inputDutchWord;

            do
            {
                Console.Write("Enter a word: ");
                inputDutchWord = Console.ReadLine();

                if (words.ContainsKey(inputDutchWord))
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    words.TryGetValue(inputDutchWord, out string englishWord);
                    Console.WriteLine($"{inputDutchWord} => {englishWord}");

                    Console.ResetColor();
                }
                else if (inputDutchWord.Equals("listall"))
                {
                    ListAllWords(words);
                }
                else
                {
                    Console.WriteLine($"Word '{inputDutchWord}' not found");
                }
            }
            while (!inputDutchWord.Equals("stop"));
        }

        static void ListAllWords(Dictionary<string, string> words)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach(string key in words.Keys)
            {
                words.TryGetValue(key, out string value);
                Console.WriteLine($"{key} => {value}");
            }

            Console.ResetColor();
        }


    }
}
