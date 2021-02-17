using System;

namespace Structures
{
    class Rectangle : Figure
    {
        public Rectangle(Point[] points)
        {
            Points = points;
        }

        public double Width()
            => Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2);

        public double Height()
            => Math.Round(Math.Sqrt(Distance(Points[1], Points[2])), 2);

        public override double Area()
            => Math.Round(Height() * Width(), 2);
    }
}
