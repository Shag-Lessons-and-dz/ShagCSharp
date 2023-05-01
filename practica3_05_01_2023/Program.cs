using System;
using System.Linq;

namespace practica3_05_01_2023
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }
        
    }

    class ArrayPoints
    {
        public Point[] points;

        public ArrayPoints(Point[] points)
        {
            this.points = points;
        }

        public static ArrayPoints operator +(ArrayPoints a, ArrayPoints b)
        {
            int length = Math.Min(a.points.Length, b.points.Length);
            Point[] result = new Point[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = a.points[i] + b.points[i];
            }

            return new ArrayPoints(result);
        }

        public static ArrayPoints operator -(ArrayPoints a, ArrayPoints b)
        {
            int length = Math.Min(a.points.Length, b.points.Length);
            Point[] result = new Point[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = a.points[i] - b.points[i];
            }

            return new ArrayPoints(result);
        }

        public static bool operator ==(ArrayPoints a, ArrayPoints b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if (a is null || b is null)
            {
                return false;
            }

            if (a.points.Length != b.points.Length)
            {
                return false;
            }

            for (int i = 0; i < a.points.Length; i++)
            {
                if (a.points[i] != b.points[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(ArrayPoints a, ArrayPoints b)
        {
            return !(a == b);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point a = new Point(1, 2);
            Point b = new Point(3, 4);
            Point c = a + b;
            Point d = b - a;

            Console.WriteLine($"c = ({c.X}, {c.Y})"); 
            Console.WriteLine($"d = ({d.X}, {d.Y})"); 

            Point[] points1 = { new Point(1, 2), new Point(3, 4), new Point(5, 6) };
            Point[] points2 = { new Point(7, 8), new Point(9, 10), new Point(11, 12) };
            ArrayPoints array1 = new ArrayPoints(points1);
            ArrayPoints array2 = new ArrayPoints(points2);
            ArrayPoints array3 = array1 + array2;
            ArrayPoints array4 = array2 - array1;

            Console.Write("array3 = [");
            for (int i = 0; i < array3.points.Length; i++)
            {
                Console.Write($"({array3.points[i].X}, {array3.points[i].Y})");
                if (i < array3.points.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.Write("array4 = [");
            for (int i = 0; i < array4.points.Length; i++)
            {
                Console.Write($"({array4.points[i].X}, {array4.points[i].Y})");
                if (i < array4.points.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            bool isEqual = array1 == array2;
            bool isNotEqual = array1 != array2;

            Console.WriteLine($"isEqual = {isEqual}");
            Console.WriteLine($"isNotEqual = {isNotEqual}"); 

            Console.ReadKey();
        }
    }
}