using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the area of a circle");
            double pi = 3.14;
            Console.WriteLine("Enter the radius of the circle:");
            double r = double.Parse(Console.ReadLine());
            //if (r < 0)
            //{
            //    Console.WriteLine("The radius cannot be less than 0.");
            //}
            //else
            //{
            //    double area = pi * r * r;
            //    Console.WriteLine("The area of a circle with radius " + r.ToString() + " is " + area.ToString() + ".");
            //}
            while (r < 0)
            {
                Console.WriteLine("The radius cannot be less than 0.");
                Console.WriteLine("Reenter the radius:");
                r = double.Parse(Console.ReadLine());
            }
            double area = pi * r * r;
            Console.WriteLine("The area of a circle with radius " + r.ToString() + " is " + area.ToString() + ".");
            Console.ReadLine();
        }
    }
}
