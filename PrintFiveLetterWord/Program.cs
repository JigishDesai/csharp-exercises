//Lists and Strings: Write a static method to print out each word in a list that has exactly 5 letters.

using System;
using System.Collections.Generic;
using System.Linq;


namespace PrintFiveLetterWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = {"desk", "America", "Hello", "World", "this", "is", "Item1", "Item2", "Jigish", "Divya", "Priya", "Rupal", "Parul", "Bharti"};
            foreach (string word in wordList)
            {
                int wordLength = word.Length;
                if (wordLength == 5)
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();
        }
    }
}
