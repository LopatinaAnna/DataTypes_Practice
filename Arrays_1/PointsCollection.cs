using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays_1
{
    public class PointsCollection : IEnumerable<Point>
    {
        private Point[] points;
        private int length;

        public int Length => length;

        public int Capacity => points.Length;

        public PointsCollection()
        {
            points = new Point[16];
            length = 0;
        }

        public PointsCollection(int capacity)
        {
            points = new Point[capacity];
            length = 0;
        }

        public Point this[int index]
        {
            get => points[index];
            set => points[index] = value;
        }

        public void Add(Point point)
        {
            if (length == points.Length)
            {
                int capacity = points.Length < 16 ? 16 : points.Length * 2;

                Array.Resize(ref points, capacity);
            }

            points[length++] = point;
        }

        public void Insert(Point point, int index)
        {
            if (length == points.Length)
            {
                int capacity = points.Length < 16 ? 16 : points.Length * 2;

                Array.Resize(ref points, capacity);
            }

            for (int i = length; i > index; i--)
            {
                points[i] = points[i - 1];
            }

            points[index] = point;

            length++;
        }

        public void Remove(Point point)
        {
            for (int i = 0; i < length; i++)
            {
                if(points[i].Equals(point))
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < length - 1; i++)
            {
                points[i] = points[i + 1];
            }

            length--;
        }

        public IEnumerator<Point> GetEnumerator()
        {
            for (int i = 0; i < length; i++)
            {
                yield return points[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
