using System;

namespace practica5_05_08_2023
{
    class Figure {
        protected string name;

        public Figure(string name) {
            this.name = name;
        }

        public virtual void Display() {
            Console.WriteLine("Figure: {0}", name);
        }
    }

    class Circle : Figure {
        private double x, y, r;

        public Circle(string name, double x, double y, double r) : base(name) {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public Circle() : this("Circle", 0, 0, 1) {}

        public double X {
            get { return x; }
            set { x = value; }
        }

        public double Y {
            get { return y; }
            set { y = value; }
        }

        public double R {
            get { return r; }
            set { r = value; }
        }

        public override void Display() {
            base.Display();
            Console.WriteLine("X: {0}, Y: {1}, R: {2}", x, y, r);
        }

        public double Area {
            get { return Math.PI * r * r; }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Figure fig = new Figure("Figure");
            Circle cir = new Circle("Circle", 1, 2, 3);

            fig.Display();
            cir.Display();

            fig = cir;
            fig.Display();

            Console.ReadKey();
        }
    }
}