using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the MPG of a vehicle");
            Console.WriteLine("Enter the miles driven:");
            float miles = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of gallons used:");
            float gallons = float.Parse(Console.ReadLine());
            float mpg = miles / gallons;
            Console.WriteLine("The MPG of the vehicle is: " + mpg.ToString());
            Console.ReadLine();
        }
    }
}
