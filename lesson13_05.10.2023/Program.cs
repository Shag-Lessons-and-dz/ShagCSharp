using System;

namespace lesson13_05._10._2023
{

    // public abstract class Figure
    // {
    //     private string name;
    //
    //     public Figure(string name)
    //     {
    //         this.name = name;
    //     }
    //
    //     public abstract double Area();
    //     
    //     public abstract double Area2 { get; }
    // }
    //
    // public class Circle : Figure
    // {
    //     private double x, y, r;
    //
    //     public Circle(double x, double y, double r) : base("Circle")
    //     {
    //         this.x = x;
    //         this.y = y;
    //         this.r = r;
    //     }
    //
    //     public override double Area()
    //     {
    //         return Math.PI * Math.Pow(r, 2);
    //     }
    //
    //     public override double Area2
    //     {
    //         get { return Area(); }
    //     }
    //
    //     public override string ToString()
    //     {
    //         string s = "x = " + String.Format("{0:f2}", x);
    //         s += ", " + "y = " + String.Format("{0:f2}", y);
    //         s += ", " + "r = " + String.Format("{0:f2}", r);
    //         return s;
    //     }
    // }

    // interface IInterface
    // {
    //     int GetIn();
    //     double Add(double a, double b);
    //     int Square(int t);
    //     double SquareRoot(double x);
    //     
    //     double Pi { get; }
    // }

    // class MyClass : IInterface
    // {
    //     public int GetIn()
    //     {
    //         return 100;
    //     }
    //
    //     public double Add(double a, double b)
    //     {
    //         return a + b;
    //     }
    //
    //     public int Square(int t)
    //     {
    //         return t * t;
    //     }
    //
    //     public double SquareRoot(double x)
    //     {
    //         return Math.Sqrt(x);
    //     }
    //
    //     public double Pi
    //     {
    //         get { return Math.PI; }
    //     }
    // }

    interface IInterface
    {
        double this[int index] { get; set; }
    }
    
    class ArrayDouble : IInterface
    {
        private double[] AD = { 1.7, 2.9, 3.3, -4.2, 1.9 };

        // Интерфейсный индексатор
        public double this[int index]
        {
            get {
                if (index < 0 || index >= AD.Length)
                {
                    throw new ArgumentOutOfRangeException("Error.");
                }

                return AD[index];
            }
            set
            {
                if (index < 0 || index >= AD.Length)
                {
                    throw new ArgumentOutOfRangeException("Error.");
                }

                AD[index] = value;
            }
        }

        public override string ToString()
        {
            string s = " => ";

            for (int i = 0; i < AD.Length; i++)
            {
                s += String.Format("{0:f1} ", AD[i]);
            }

            return s;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Circle cr = new Circle(2, 3, 3);
            // Console.WriteLine(cr.ToString());
            // Console.WriteLine(cr.Area2);
            // MyClass mc = new MyClass();
            //
            // IInterface mi = mc;
            // var d = mi.Add(3.8, 7.4);
            // Console.WriteLine("d = " + d);
            
            ArrayDouble AD = new ArrayDouble();
            double x = AD[2];

            Console.WriteLine("x = " + x);
            Console.WriteLine(AD.ToString());
            Console.ReadKey();
        }
    }
}