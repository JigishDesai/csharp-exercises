using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 1, 2, 3, 5, 8 };
            foreach (int num in numArray)
                Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
