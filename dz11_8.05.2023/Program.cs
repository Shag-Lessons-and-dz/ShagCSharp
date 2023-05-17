using System;

namespace dz11_8._05._2023
{
    
    class Human
    {
        private string surname;
        private string name;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Human(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
        }

        public virtual void Print()
        {
            Console.WriteLine("Human: {0} {1}", surname, name);
        }
    }

    class Worker : Human
    {
        private DateTime employment;
        private string position;

        public DateTime Employment
        {
            get { return employment; }
            set { employment = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Worker(string surname, string name, DateTime employment, string position)
            : base(surname, name)
        {
            this.employment = employment;
            this.position = position;
        }

        public override void Print()
        {
            Console.WriteLine("Worker: {0} {1}", Surname, Name);
            Console.WriteLine("Employment: {0}", employment.ToShortDateString());
            Console.WriteLine("Position: {0}", position);
        }
    }

    class Manager : Worker
    {
        private int numPeople;

        public int NumPeople
        {
            get { return numPeople; }
            set { numPeople = value; }
        }

        public Manager(string surname, string name, DateTime employment, string position, int numPeople)
            : base(surname, name, employment, position)
        {
            this.numPeople = numPeople;
        }

        public override void Print()
        {
            Console.WriteLine("Manager: {0} {1}", Surname, Name);
            Console.WriteLine("Employment: {0}", Employment.ToShortDateString());
            Console.WriteLine("Position: {0}", Position);
            Console.WriteLine("Number of People: {0}", numPeople);
        }
    }

    class Demo
    {
        public void PrintData(Human human)
        {
            human.Print();
        }
    }

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime employment = new DateTime(2021, 1, 1);

            Human human = new Human("Doe", "John");
            Worker worker = new Worker("Smith", "Alice", employment, "Engineer");
            Manager manager = new Manager("Lee", "Hiroshi", employment, "Manager", 10);

            Demo demo = new Demo();

            demo.PrintData(human);
            Console.WriteLine();
            demo.PrintData(worker);
            Console.WriteLine();
            demo.PrintData(manager);

            Console.ReadLine();
        }
    }
}