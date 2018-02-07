//Lists: Write a static method to find the sum of all the even numbers in a list. 
//Within Main, create a list with at least 10 integers and call your method on the list.

using System;

namespace SumEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;

            for (int i = 0; i <= 10; i += 2)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum of even numbers is " + sum);
            Console.ReadLine();    
        }
    }
}
