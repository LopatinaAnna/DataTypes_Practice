using System;
using System.Collections.Generic;
using System.Linq;

namespace Structures_2
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>();

            Console.Write("Points count: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("\nx: ");
                if (double.TryParse(Console.ReadLine(), out double x))
                {
                    if (x > 0 && x < 20)
                    {
                        Console.Write("y: ");
                        if (double.TryParse(Console.ReadLine(), out double y))
                        {
                            points.Add(new Point(x, y));
                        }
                    }
                }
            }

            Console.WriteLine("\nResult: ");
            foreach (var item in points.OrderBy(c => c.Y))
            {
                Console.WriteLine($"x: {item.X}, y: {item.Y}");
            }
        }
    }
}
