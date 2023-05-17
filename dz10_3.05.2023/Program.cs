using System;

namespace dz10_3._05._2023
{
    
    class Human
    {
        protected string surname;
        protected string name;
        protected DateTime birthDate;

        public int Year
        {
            get { return birthDate.Year; }
            set { birthDate = new DateTime(value, birthDate.Month, birthDate.Day); }
        }

        public int Month
        {
            get { return birthDate.Month; }
            set { birthDate = new DateTime(birthDate.Year, value, birthDate.Day); }
        }

        public int Day
        {
            get { return birthDate.Day; }
            set { birthDate = new DateTime(birthDate.Year, birthDate.Month, value); }
        }

        public Human(string surname, string name, DateTime birthDate)
        {
            this.surname = surname;
            this.name = name;
            this.birthDate = birthDate;
        }

        public virtual void Info()
        {
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Birth Date: " + birthDate.ToShortDateString());
        }
    }

    class Citizen : Human
    {
        protected string passportNumber;
        protected string address;

        public Citizen(string surname, string name, DateTime birthDate, string passportNumber, string address)
            : base(surname, name, birthDate)
        {
            this.passportNumber = passportNumber;
            this.address = address;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Passport Number: " + passportNumber);
            Console.WriteLine("Address: " + address);
        }
    }

    class ForeignCitizen : Citizen
    {
        protected string foreignPassportNumber;

        public ForeignCitizen(string surname, string name, DateTime birthDate, string passportNumber, string address, string foreignPassportNumber)
            : base(surname, name, birthDate, passportNumber, address)
        {
            this.foreignPassportNumber = foreignPassportNumber;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine("Foreign Passport Number: " + foreignPassportNumber);
        }
    }

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime birthDate = new DateTime(1990, 5, 17);

            Human human = new Human("Doe", "John", birthDate);
            human.Info();

            Console.WriteLine();

            Citizen citizen = new Citizen("Smith", "Alice", birthDate, "AB123456", "123 Main St");
            citizen.Info();

            Console.WriteLine();

            ForeignCitizen foreignCitizen = new ForeignCitizen("Lee", "Hiroshi", birthDate, "CD789012", "456 Elm St", "XYZ987654");
            foreignCitizen.Info();

            Console.ReadLine();
        }
    }
}