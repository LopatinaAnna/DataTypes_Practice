﻿using System;

namespace Structures
{
    class Rectangle : Figure
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            if (IsRectangle(a, b, c, d))
                Points = new[] { a, b, c, d };
            else
                throw new Exception("\nThis is not a rectangle.");
        }

        public double Width() 
            => Math.Round(Math.Sqrt(Distance(Points[0], Points[1])), 2); 
       
        public double Height() 
            => Math.Round(Math.Sqrt(Distance(Points[1], Points[2])), 2); 
       
        public override double Area()
            => Math.Round(Height() * Width(), 2); 
       
        private bool IsRectangle(Point a, Point b, Point c, Point d)
            => Distance(a, b) == Distance(c, d) && Distance(b, c) == Distance(d, a);
    }
}
