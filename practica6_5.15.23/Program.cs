using System;

namespace practica6_5._15._23
{
    abstract class Vehicle
    {
        public abstract int CostPass { get; }
        public abstract int GetCostGoods();
        public abstract void Print();
    }

    class Car : Vehicle
    {
        private int costPass;
        private int costGoods;

        public Car(int costPass, int costGoods)
        {
            this.costPass = costPass;
            this.costGoods = costGoods;
        }

        public override int CostPass
        {
            get { return costPass; }
        }

        public override int GetCostGoods()
        {
            return costGoods;
        }

        public override void Print()
        {
            Console.WriteLine("Car");
            Console.WriteLine($"Cost of passengers: {costPass}");
            Console.WriteLine($"Cost of goods: {costGoods}");
        }
    }

    class Bike : Vehicle
    {
        private int costPass;
        private int costGoods;

        public Bike(int costPass, int costGoods)
        {
            this.costPass = costPass;
            this.costGoods = costGoods;
        }

        public override int CostPass
        {
            get { return costPass; }
        }

        public override int GetCostGoods()
        {
            return costGoods;
        }

        public override void Print()
        {
            Console.WriteLine("Bike");
            Console.WriteLine($"Cost of passengers: {costPass}");
            Console.WriteLine($"Cost of goods: {costGoods}");
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[2];

            Car car = new Car(50, 100);
            Bike bike = new Bike(20, 50);

            vehicles[0] = car;
            vehicles[1] = bike;

            double totalCostPass = 0;
            double totalCostGoods = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                totalCostPass += vehicle.CostPass;
                totalCostGoods += vehicle.GetCostGoods();
            }

            double avgCostPass = totalCostPass / vehicles.Length;
            double avgCostGoods = totalCostGoods / vehicles.Length;

            car.Print();
            bike.Print();
            
            Console.WriteLine($"Average cost of passengers: {avgCostPass}");
            Console.WriteLine($"Average cost of goods: {avgCostGoods}");

            Console.ReadKey();
        }
    }
}