using System;

namespace Structures
{
    class Rectangle : Figure
    {
        public Rectangle(Point[] points)
        {
            if (IsRectangle(points))
                Points = points;
            else
                throw new Exception("\nThis is not a rectangle.");
        }

        public double Width() 
            => Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2); 
       
        public double Height() 
            => Math.Round(Math.Sqrt(Distance(Points[1], Points[2])), 2); 
       
        public override double Area()
            => Math.Round(Height() * Width(), 2); 
       
        private bool IsRectangle(Point[] points)
            => Distance(points[0], points[1]) == Distance(points[2], points[3]) && 
            Distance(points[1], points[2]) == Distance(points[3], points[0]);
    }
}
