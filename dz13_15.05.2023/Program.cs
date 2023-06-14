using System;
using System.Collections;
using System.Collections.Generic;

namespace dz13_15._05._2023
{
    
    public class Point : IComparable<Point>
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double LengthOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public void Print()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y}), Distance from origin: {LengthOrigin()}");
        }

        public int CompareTo(Point other)
        {
            if (other == null)
                return 1;

            return LengthOrigin().CompareTo(other.LengthOrigin());
        }
    }

    public class ArrayPoint : IEnumerable<Point>
    {
        private List<Point> points;

        public ArrayPoint()
        {
            points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public void SortByLengthOrigin()
        {
            points.Sort();
        }

        public void Print()
        {
            foreach (Point point in points)
            {
                point.Print();
            }
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayPoint arrayPoint = new ArrayPoint();
            arrayPoint.AddPoint(new Point(3, 4));
            arrayPoint.AddPoint(new Point(1, 2));
            arrayPoint.AddPoint(new Point(5, 5));

            Console.WriteLine("Before sorting:");
            arrayPoint.Print();

            Console.WriteLine("After sorting:");
            arrayPoint.SortByLengthOrigin();
            arrayPoint.Print();

            Console.ReadKey();
        }
    }
}