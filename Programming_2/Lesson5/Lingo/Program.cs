using System;
using System.Collections.Generic;
using System.IO;

namespace Lingo
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
            List<string> words = ReadWords();
            string lingoWord = ChooseWord(words);
            LingoGame lingoGame = new LingoGame();
            lingoGame.Init(lingoWord);
            PlayLingo(lingoGame);
        }
        List<string> ReadWords()
        {
            List<string> listOfWord = new List<string>();

            string filename = "words.txt";
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);       //opening

                while (!reader.EndOfStream)
                    listOfWord.Add(reader.ReadLine());

                reader.Close();     //closing, has to!
            }
            return listOfWord;
            // or read words from a file...
        }
        string ChooseWord(List<string> words)
        {
            Random rand = new Random();

            string word = words[rand.Next(0, words.Count - 1)];
            return word;
        }


        void PlayLingo(LingoGame lingoGame)
        {
            int attemptsLeft = 5;
            int wordLength = lingoGame.lingoWord.Length;
            string playerWord;

            while (attemptsLeft > 0 && !lingoGame.GuessedWord())
            {
                Console.Write($"Enter a ({wordLength}-letter) word, attempt {6 - attemptsLeft}: ");
                playerWord = ReadPlayerWord(wordLength);
                lingoGame.CheckWord(playerWord);
                DisplayResults(lingoGame);

                Console.WriteLine();

                attemptsLeft--;
            }

            if (lingoGame.GuessedWord() && attemptsLeft >= 0)
                Console.WriteLine("Congrats, you won! You guessed the word!!");
            else
                Console.WriteLine($"lol loser, the word was {lingoGame.lingoWord.ToLower()}");
        }

        string ReadPlayerWord(int length)
        {
            string word;
            do
            {
                word = Console.ReadLine();
            }
            while (word.Length != length);

            return word.ToUpper();
        }

        void DisplayResults(LingoGame lingoGame)
        {
            for (int i = 0; i < lingoGame.playerWord.Length; i++)
            {
                if (lingoGame.letterResults[i] == LetterState.Correct)
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                else if (lingoGame.letterResults[i] == LetterState.WrongPosition)
                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                Console.Write(lingoGame.playerWord[i]);
                Console.ResetColor();
            }
        }

        
    }


    enum LetterState
    {
        Correct, Incorrect, WrongPosition
    }

    class LingoGame
    {
        public string lingoWord;
        public string playerWord;
        public LetterState[] letterResults;

        public void Init(string lingoWord)
        {
            this.lingoWord = lingoWord.ToUpper();
        }

        public bool GuessedWord() 
        {
            return lingoWord == playerWord;
        }

        public void CheckWord(string playerWord)
        {
            this.playerWord = playerWord;
            this.letterResults = new LetterState[lingoWord.Length];

            List<char> refLetters = new List<char>();
            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (playerWord.Contains(lingoWord[i]))
                {
                    refLetters.Add(lingoWord[i]);
                }
            }

            for (int i = 0; i < lingoWord.Length; i++)
            {
                if (lingoWord[i] == playerWord[i])
                {
                    letterResults[i] = LetterState.Correct;
                }
                else
                {
                    if (refLetters.Contains(playerWord[i]))
                    {
                        letterResults[i] = LetterState.WrongPosition;
                        refLetters.Remove(playerWord[i]);
                    }
                    else
                    {
                        letterResults[i] = LetterState.Incorrect;
                    }
                }

            }
        }


    }
}
