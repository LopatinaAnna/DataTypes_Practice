using System;

namespace Structures
{
    class Triangle : Figure
    {
        public Triangle(Point[] points)
        {
            Points = points;
        }

        public override double Area()
            => Math.Abs((Points[0].X - Points[2].X) * (Points[1].Y - Points[2].Y) -
            (Points[1].X - Points[2].X) * (Points[0].Y - Points[2].Y)) / 2;
    }
}
