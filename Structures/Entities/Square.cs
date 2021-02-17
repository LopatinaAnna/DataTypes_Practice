using System;

namespace Structures
{
    public class Square : Figure
    {
        public Square(Point a, Point b, Point c, Point d)
        {
            if (IsSquare(a, b, c, d))
                Points = new[] { a, b, c, d };
            else
                throw new Exception("\nThis is not a square.");
        }

        public double Width() 
            => Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2); 

        public override double Area() 
            => Math.Round(Width() * Width(), 2); 
            
        private bool IsSquare(Point a, Point b, Point c, Point d)
            => Distance(a, b) == Distance(b, c) &&
            Distance(b, c) == Distance(c, d) &&
            Distance(c, d) == Distance(d, a);
    }
}
