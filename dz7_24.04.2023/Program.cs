namespace dz7_24._04._2023
{
    using System;

    class Toris
    {
        private string subject;
        private int number;
        private string name;
        private double difficulty;
        private int points;

        public Toris(string subject, int number, string name, double difficulty, int points)
        {
            this.subject = subject;
            this.number = number;
            this.name = name;
            this.Difficulty =
                difficulty; // використовуємо властивість Difficulty, щоб зробити перевірку на коректність значення
            this.Points = points; // використовуємо властивість Points, щоб зробити перевірку на коректність значення
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Difficulty
        {
            get { return difficulty; }
            set
            {
                if (value < 0.01 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Difficulty must be between 0.01 and 1");
                }

                difficulty = value;
            }
        }

        public int Points
        {
            get { return points; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Points must be between 1 and 100");
                }

                points = value;
            }
        }

        public double Rating
        {
            get { return difficulty * points; }
        }

        public void Print()
        {
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Difficulty: {difficulty}");
            Console.WriteLine($"Points: {points}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Toris toris = new Toris("Math", 1, "Algebra", 0.5, 50);

            toris.Subject = "Physics";
            toris.Number = 2;
            toris.Name = "Thermodynamics";
            toris.Difficulty = 0.8;
            toris.Points = 80;

            Console.WriteLine($"Subject: {toris.Subject}");
            Console.WriteLine($"Number: {toris.Number}");
            Console.WriteLine($"Name: {toris.Name}");
            Console.WriteLine($"Difficulty: {toris.Difficulty}");
            Console.WriteLine($"Points: {toris.Points}");
            Console.WriteLine($"Rating: {toris.Rating}");

            toris.Print();
        }
    }
}