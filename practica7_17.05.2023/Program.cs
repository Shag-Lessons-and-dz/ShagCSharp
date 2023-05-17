using System;
using System.Collections;
using System.Collections.Generic;

namespace practica7_17._05._2023
{
    
    public class Circle : IComparable<Circle>
    {
        private double x;
        private double y;
        private double r;

        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public double R
        {
            get { return r; }
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public int CompareTo(Circle other)
        {
            if (other == null)
                return 1;

            // Сортування у порядку спадання відстаней
            return -Length().CompareTo(other.Length());
        }
    }

    public class ArrayCircle : IEnumerable<Circle>
    {
        private Circle[] cr;

        public ArrayCircle(params Circle[] circles)
        {
            cr = circles;
        }

        public void Sort()
        {
            Array.Sort(cr);
        }

        public IEnumerator<Circle> GetEnumerator()
        {
            foreach (Circle circle in cr)
            {
                yield return circle;
            }
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
            Circle circle1 = new Circle(1, 2, 5);
            Circle circle2 = new Circle(3, 4, 3);
            Circle circle3 = new Circle(-1, -1, 2);

            ArrayCircle arrayCircle = new ArrayCircle(circle1, circle2, circle3);
            arrayCircle.Sort();

            foreach (Circle circle in arrayCircle)
            {
                Console.WriteLine($"Circle: ({circle.X}, {circle.Y}), Radius: {circle.R}, Length: {circle.Length()}");
            }
        }
    }
}