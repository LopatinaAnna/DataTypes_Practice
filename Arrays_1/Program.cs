﻿using System;

namespace Arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new PointsCollection(5)
            {
                new Point(0, 1),
                new Point(1, 2), 
                new Point(2, 3),
                new Point(3, 4),
                new Point(4, 5)
            };
            Print(points, "Create new collection");

            points.Add(new Point(5, 6));
            Print(points, "Add new value and resize collection");

            points.Insert(new Point(6, 7), 0);
            Print(points, "Insert new value (6, 7) at the beginning");

            points.Insert(new Point(7, 8), 2);
            Print(points, "Insert new value (7, 8) in the middle");

            points.Insert(new Point(8, 9), 8);
            Print(points, "Insert new value (8, 9) at the end");

            points.Remove(new Point(0, 1));
            Print(points, "Remove value (0, 1)");

            points.RemoveAt(0);
            Print(points, "Remove at index 0");
        }

        static void Print(PointsCollection points, string message)
        {
            Console.WriteLine($"{message}, length: {points.Length}, capacity: {points.Capacity}");
            foreach (var item in points)
            {
                Console.WriteLine($"({item.x},{item.y})");
            }
        }
    }
}
