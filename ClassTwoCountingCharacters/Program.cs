using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace ClassTwoCountingCharacters
{
    class Program
    {
        private static void Main(string[] args)
        {
            //string stringToCount = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            System.Console.Write("Enter the string whose characters you wish to count:");
            string stringToCount = System.Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in stringToCount.ToLower())
            {
                int count = 1;
                if (c >= 'a' && c <='z')
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount.Add(c, count);
                    }
             }
           
            
            foreach (KeyValuePair<char, int> character in charCount)
                System.Console.WriteLine(character.Key + ": " + character.Value);
            System.Console.ReadLine();

        }
    }
}
