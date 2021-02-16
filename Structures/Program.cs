using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Point x: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Point y: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine();

                points[i] = new Point(x, y);
            }

            try
            {
                var square = new Square(points[0], points[1], points[2], points[3]);

                Console.WriteLine("This is a square.");
                Console.WriteLine($"Width: {square.GetWidth()}");
                Console.WriteLine($"Height: {square.GetHeight()}");
                Console.WriteLine($"Area: {square.GetArea()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
