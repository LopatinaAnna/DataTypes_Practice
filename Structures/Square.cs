using System;

namespace Structures
{
    public class Square
    {
        public Point[] Points { get; }

        public Square(Point a, Point b, Point c, Point d)
        {
            if (IsSquare(a, b, c, d))
                Points = new[] { a, b, c, d };
            else
                throw new Exception("This is not a square.");
        }

        public double GetHeight()
        {
            return Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2);
        }

        public double GetWidth()
        {
            return GetHeight();
        }

        public double GetArea()
        {
            return Math.Round(Math.Pow(GetHeight(), 2), 2);
        }

        private bool IsSquare(Point a, Point b, Point c, Point d)
            => Distance(a, b) == Distance(b, c) &&
            Distance(b, c) == Distance(c, d) &&
            Distance(c, d) == Distance(d, a);

        private double Distance(Point a, Point b) 
            => Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2);
    }
}
