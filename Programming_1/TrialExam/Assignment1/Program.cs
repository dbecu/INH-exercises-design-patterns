using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string input = Console.ReadLine();

            //a palindrome is when you have a word, and if you flip the word, it stays the same
            //eg. dad, wow, hellolleh, kayak
            //so the first character == last character, then second character == second last character, etc <-- so this is the algorithm im gonna use

            //a string is an array of chars, so i can access letters of a word same way as an element of an array

            char start = input[0];                  //gets first char of string input
            char end = input[input.Length - 1];     //gets last char of string input

            //algorithm:

            int halfLength = input.Length / 2;      //i will be comparing the value the input length / 2 times
            string message = input + " is a palindrome";    //message will change is algorith says so

            for (int i = 0; i < halfLength; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    message = input + " is not a palindrome"; //since boolean expression says input isn't palindrome, i change message
                    i = halfLength; //will end for loop
                }

            }

            Console.WriteLine(message);
            Console.ReadKey();


        }
    }
}
