using System;

namespace dz1
{
    internal class Program
    {
        public static void Main()
        {
            // Завдання 1
            Console.WriteLine("Завдання 1\n");

            Console.Write("Введіть значення x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введіть значення y: ");
            double y = double.Parse(Console.ReadLine());

            double z = (Math.Sin(x) + (2 + y) / (1 + Math.Pow(x, 2))) / Math.Sqrt(Math.Abs(y) + 2);
            Console.WriteLine("x = {0:F4}, y = {1:F4}, z = {2:F6}\n", x, y, z);

            // Завдання 2
            Console.WriteLine("Завдання 2\n");

            Console.Write("Введіть координати вершини A (x,y): ");
            string[] aCoords = Console.ReadLine().Split(',');
            double ax = double.Parse(aCoords[0]);
            double ay = double.Parse(aCoords[1]);

            Console.Write("Введіть координати вершини B (x,y): ");
            string[] bCoords = Console.ReadLine().Split(',');
            double bx = double.Parse(bCoords[0]);
            double by = double.Parse(bCoords[1]);

            Console.Write("Введіть координати вершини C (x,y): ");
            string[] cCoords = Console.ReadLine().Split(',');
            double cx = double.Parse(cCoords[0]);
            double cy = double.Parse(cCoords[1]);

            double a = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double b = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double c = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));

            double p = a + b + c;
            double s = Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));

            Console.WriteLine("Периметр трикутника: {0:F3}", p);
            Console.WriteLine("Площа трикутника: {0:F3}", s);

            Console.ReadKey();
        }
    }
}