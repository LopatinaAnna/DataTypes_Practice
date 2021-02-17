using System;

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

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Point x: ");
            //    points[i].X = double.Parse(Console.ReadLine());
            //    Console.Write("Point y: ");
            //    points[i].Y = double.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //}

            try
            {
                var square = new Square(points[0], points[1], points[2], points[3]);

                Console.WriteLine("\nThis is a square:");
                Console.WriteLine($"Width: {square.Width()}");
                Console.WriteLine($"Area: {square.Area()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var rectangle = new Rectangle(points[0], points[1], points[2], points[3]);

                Console.WriteLine("\nThis is a rectangle:");
                Console.WriteLine($"Width: {rectangle.Width()}");
                Console.WriteLine($"Height: {rectangle.Height()}");
                Console.WriteLine($"Area: {rectangle.Area()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
