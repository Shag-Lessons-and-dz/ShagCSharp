using System;

namespace lesson8_04_21_2023
{

    class Product
    {
        private string code;
        private string number;
        private string name;
        private double minPrice;
        private double maxPrice;

        public Product(string code, string number, string name, double minPrice, double maxPrice)
        {
            this.code = code;
            this.number = number;
            this.name = name;
            this.minPrice = minPrice;
            this.maxPrice = maxPrice;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }        
        
        public string Number
        {
            get { return number; }
            set { number = value; }
        }        
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public double MinPrice
        {
            get { return minPrice; }
            set
            {
                if (value < 0)
                {
                    minPrice = 0;
                }
                else
                {
                    minPrice = value;
                }
                
            }
        }        
        public double MaxPrice
        {
            get { return maxPrice; }
            set
            {
                if (value < 0)
                {
                    maxPrice = 0.0;
                }
                else
                {
                    maxPrice = value;
                }
                
            }
        }

        public double ChangePrice
        {
            get { return Math.Abs(maxPrice - minPrice); }
        }

        public override string ToString()
        {
            string s = "code = " + code;
            s += ",  number = " + number;
            s += ",  name = " + name;
            s += String.Format(",  min price = {0:f2}", minPrice);
            s += String.Format(",  max price = {0:f2}", maxPrice);
            return s;
        }

        public static double Pi
        {
            get { return 3.1415; }
        }
    }
    
    class Point
    {
        //private double x, y;

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }
       
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Product pr = new Product("ab-23", "270-A", "Table", 100.50, 130.75);
            
            Console.WriteLine("pr = " + pr.ToString());

            pr.Code = "abcde";
            Console.WriteLine("pr = " + pr.ToString());

            string code = pr.Code;
            Console.WriteLine("code = " + code);

            double change = pr.ChangePrice;
            Console.WriteLine($"change = {change:f2}");

            double area = Product.Pi + 3.0 * 3.0;
             Console.WriteLine("area = {0:f3}", area);

           Point pt = new Point(2.8, 3.5);
           Console.WriteLine("pt.x = "+ pt.X);
           Console.WriteLine("pt.y = "+ pt.Y);
           
            Console.ReadKey();
        }
    }
}