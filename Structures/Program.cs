using System;
using static Structures.Validation;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new Point[4] 
            { 
                new Point(2, 4), 
                new Point(4, 4), 
                new Point(4, 2), 
                new Point(2, 2) 
            };
            
            if (points.Length == 4)
            {
                if(IsSquare(points))
                {
                    var square = new Square(points);

                    Console.WriteLine("\nThis is a square:");
                    Console.WriteLine($"Width: {square.Width()}");
                    Console.WriteLine($"Area: {square.Area()}");
                }
                else
                {
                    Console.WriteLine("\nThis is not a square.");
                }

                if (IsRectangle(points))
                {
                    var rectangle = new Rectangle(points);

                    Console.WriteLine("\nThis is a rectangle:");
                    Console.WriteLine($"Width: {rectangle.Width()}");
                    Console.WriteLine($"Height: {rectangle.Height()}");
                    Console.WriteLine($"Area: {rectangle.Area()}");
                }
                else
                {
                    Console.WriteLine("\nThis is not a rectangle.");
                }
            }

            if (points.Length == 3)
            {
                if (IsTriangle(points))
                {
                    var triangle = new Triangle(points);

                    Console.WriteLine("\nThis is a triangle:");
                    Console.WriteLine($"Area: {triangle.Area()}");
                }
                else
                {
                    Console.WriteLine("\nThis is not a triangle");
                }
            }
        }
    }
}
