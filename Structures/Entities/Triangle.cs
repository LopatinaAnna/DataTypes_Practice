using System;

namespace Structures
{
    class Triangle : Figure
    {
        public Triangle(Point a, Point b, Point c)
        {
            if (IsTriangle(a, b, c))
                Points = new[] { a, b, c };
            else
                throw new Exception("\nThis is not a triangle.");
        }

        public override double Area()
            => Math.Abs((Points[0].X - Points[2].X) * (Points[1].Y - Points[2].Y) - 
            (Points[1].X - Points[2].X) * (Points[0].Y - Points[2].Y)) / 2;

        private bool IsTriangle(Point a, Point b, Point c) 
            => Distance(a, b) > 0 && Distance(b, c) > 0 && Distance(c, a) > 0;
    }
}
