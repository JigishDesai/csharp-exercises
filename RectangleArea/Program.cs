using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the area of a rectangular object.");
            Console.WriteLine("Enter the width of the rectangle:");
            float width = float.Parse(Console.ReadLine());
            // string userWidth = Console.ReadLine();
            //float width = float.Parse(userWidth);
            Console.WriteLine("Enter the height of the rectangle:");
            //string userHeight = Console.ReadLine();
            float height = float.Parse(Console.ReadLine());
            float area = height * width;
            Console.WriteLine("The area is " + area.ToString());
            Console.ReadLine();

        }
    }
}
