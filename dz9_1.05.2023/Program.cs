using System;

namespace dz9_1._05._2023
{
    
    class Point
    {
        private double x;
        private double y;

        // Конструктор з двома параметрами
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Конструктор без параметрів
        public Point() : this(0.0, 0.0)
        {
        }

        // Метод для виведення інформації про точку
        public void PrintPoint()
        {
            Console.WriteLine("Point coordinates: ({0}, {1})", x, y);
        }

        // Операція перевантаження бінарного оператора +
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        // Операція перевантаження бінарного оператора -
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        // Операція перевантаження унарного оператора -
        public static Point operator -(Point p)
        {
            return new Point(-p.x, -p.y);
        }

        // Операція перевантаження оператора true
        public static bool operator true(Point p)
        {
            return p.x == 0.0 && p.y == 0.0;
        }

        // Операція перевантаження оператора false
        public static bool operator false(Point p)
        {
            return !(p.x == 0.0 && p.y == 0.0);
        }

        // Операція перевантаження оператора ==
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }

        // Операція перевантаження оператора !=
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point p1 = new Point(1.0, 2.0);
            Point p2 = new Point(3.0, 4.0);
            
            p1.PrintPoint(); // Point coordinates: (1, 2)
            p2.PrintPoint(); // Point coordinates: (3, 4)
            
            Point p3 = p1 + p2;
            p3.PrintPoint(); // Point coordinates: (4, 6)
            
            Point p4 = p1 - p2;
            p4.PrintPoint(); // Point coordinates: (-2, -2)
            
            Point p5 = -p1;
            p5.PrintPoint();

            Console.ReadKey();

        }
    }
}