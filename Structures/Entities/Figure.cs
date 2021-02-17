using System;

namespace Structures
{
    public abstract class Figure
    {
        public Point[] Points { get; set; }

        public abstract double Area();

        protected double Distance(Point a, Point b)
            => Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2);
    }
}
