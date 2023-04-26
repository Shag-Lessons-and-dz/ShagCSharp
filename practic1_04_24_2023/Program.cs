using System;

namespace practic1_04_24_2023
{

    class Auto
    {
        private string name;
        private string brand;
        private double time;
        private double price;

        public Auto(string name, string brand, double time, double price)
        {
            this.name = name;
            this.brand = brand;
            this.time = time;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        
        public double Time
        {
            get { return time; }
            set
            {
                if (value < 0)
                {
                    time = -value;
                }
                else
                {
                    time = value;
                }
            }
        }  
        
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    price = -value;
                }
                else
                {
                    price = value;
                }
            }
        }

        public double Cost
        {
            get { return time * price; }
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Time: " + time);
            Console.WriteLine("Price: " + price);
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            Auto auto = new Auto("Tucson", "Hyundai", 23.0, 12.0);
            auto.Print();
            auto.Name = "QX80";
            Console.WriteLine("name = " + auto.Name);

            auto.Brand = "Infiniti";
            Console.WriteLine("brand = " + auto.Brand);

            auto.Time = 24.0;
            Console.WriteLine("time = {0:f2}", auto.Time);

            auto.Price = 13.25;
            Console.WriteLine("price = {0:f2}", auto.Price);

            Console.WriteLine("cost = {0:f2}", auto.Cost);
            
            auto.Print();
        }
    }
}