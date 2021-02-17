using System;

namespace Structures
{
    public class Square : Figure
    {
        public Square(Point[] points)
        {
            if (IsSquare(points))
                Points = points;
            else
                throw new Exception("\nThis is not a square.");
        }

        public double Width() 
            => Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2); 

        public override double Area() 
            => Math.Round(Width() * Width(), 2); 
            
        private bool IsSquare(Point[] points)
            => Distance(points[0], points[1]) == Distance(points[1], points[2]) &&
            Distance(points[1], points[2]) == Distance(points[2], points[3]) &&
            Distance(points[2], points[3]) == Distance(points[3], points[0]);
    }
}
