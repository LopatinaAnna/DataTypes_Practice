using System;

namespace Structures
{
    class Triangle : Figure
    {
        public Triangle(Point[] points)
        {
            if (IsTriangle(points))
                Points = points;
            else
                throw new Exception("\nThis is not a triangle.");
        }

        public override double Area()
            => Math.Abs((Points[0].X - Points[2].X) * (Points[1].Y - Points[2].Y) - 
            (Points[1].X - Points[2].X) * (Points[0].Y - Points[2].Y)) / 2;

        private bool IsTriangle(Point[] points) 
            => Distance(points[0], points[1]) > 0 && 
            Distance(points[1], points[2]) > 0 && 
            Distance(points[2], points[0]) > 0;
    }
}
