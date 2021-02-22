using System.Collections;
using System.Collections.Generic;

namespace Arrays_1
{
    public class PointsCollection : IEnumerable<Point>
    {
        private Point[] points;

        public PointsCollection(int length)
        {
            points = new Point[length];
        }

        public void Add(Point point)
        {

        }

        public void Insert(Point point, int index)
        {

        }

        public void Remove(Point point)
        {

        }

        public void RemoveAt(int index)
        {

        }

        public IEnumerator<Point> GetEnumerator()
        {
            for (int i = 0; i < points.Length; i++)
            {
                yield return points[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return points.GetEnumerator();
        }
    }
}
