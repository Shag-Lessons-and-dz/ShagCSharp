using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        class Point
        {
            public int x, y; 

            public Point(int x, int y)
            {
                this.x = x;
              
                this.y = y;
            }
            public static Point operator +(Point obj1, Point obj2)
            {
                return new Point(obj1.x + obj2.x, obj1.y + obj2.y); ;
            }

            public static Point operator -(Point obj1, Point obj2)
            { 
                return new Point(obj1.x - obj2.x, obj1.y - obj2.y);
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(3,5);
            Point p2 = new Point(6,10);
            Point p3 = p2 - p1;
            Console.WriteLine(p3);

            Console.ReadKey();
        }
    }
}