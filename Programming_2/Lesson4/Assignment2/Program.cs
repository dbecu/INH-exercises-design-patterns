using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment2
{
    public class HangmanGame
    {
        public string secretWord;
        public string guessedWord;

        public void Init(string secretWord)
        {
            this.guessedWord = "";
            this.secretWord = secretWord;
            for (int i = 0; i < secretWord.Length; i++)
                this.guessedWord += ".";
        }

        public bool GuessLetter(char letter)
        {
            bool doesContain = this.secretWord.Contains(letter);

            if (doesContain)
            {

                string newGuessedWord = "";

                for (int i = 0; i < this.secretWord.Length; i++)
                {
                    if (secretWord[i] == letter)
                        newGuessedWord += letter;
                    else
                        newGuessedWord += this.guessedWord[i];
                }

                this.guessedWord = newGuessedWord;
            }

            return doesContain;
        }

        public bool IsGuessed()
        {
            return this.guessedWord.Equals(this.secretWord);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            HangmanGame hangman = new HangmanGame();
            if (PlayHangman(hangman))
                Console.WriteLine("You guessed the word!");
            else
            {
                Console.WriteLine("lol loser");
                Console.WriteLine($"the word: {hangman.secretWord}");
            }



            //hangman.secretWord = SelectWord(ListOfWords());
            //hangman.Init(hangman.secretWord);

            //Console.WriteLine("The secret word is: " + hangman.secretWord);
            //Console.WriteLine("The guessed word is: " + hangman.guessedWord);
        }

        List<string> ListOfWords()
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
        }

        string SelectWord(List<string> words)
        {
            Random rand = new Random();

            return words[rand.Next(0, words.Count)];  //change to be flexible
        }

        bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();

            hangman.secretWord = SelectWord(ListOfWords());
            hangman.Init(hangman.secretWord);

            //Console.Write("The secret word is:  ");
            //foreach (char c in hangman.secretWord)
            //    Console.Write($"{c} ");

            DisplayWord(hangman.guessedWord);

            int index = 1;
            while(!hangman.IsGuessed() && index <= 8)
            {
                Console.WriteLine();

                DisplayLetters(enteredLetters);

                char guessedLetter = ReadLetter(enteredLetters);
                enteredLetters.Add(guessedLetter);

                hangman.GuessLetter(guessedLetter);

                DisplayWord(hangman.guessedWord);

                Console.WriteLine("You have {0} more tries", 8 - index);

                index++;
            }

            return hangman.IsGuessed();
        }

        void DisplayWord(string word)
        { 

            Console.WriteLine();
            //Console.Write("The guessed word is: ");
            foreach (char c in word)
                Console.Write($"{c} ");

            Console.WriteLine();

        }

        void DisplayStickman(int tries)
        {
            switch (tries)
            {
                case 0:
                    Console.WriteLine(":D");
                    break;
                case 1:
                    Console.WriteLine(":)");
                    break;
                case 2:
                    Console.WriteLine(":|");
                    break;
            }
        }

        void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters: ");
            foreach (char letter in letters)
                Console.Write(letter + " ");

            Console.WriteLine();
        }

        char ReadLetter(List<char> blacklistLetters)        //debug! gotta do something if same word is entered!!
        {
            
            char enteredLetter;

            do
            {
                Console.Write("Enter a letter: ");
                enteredLetter = Console.ReadLine()[0];
            } while (blacklistLetters.Contains(enteredLetter));

            return enteredLetter;
        }
    }
}
