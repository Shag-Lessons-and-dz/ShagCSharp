using System;

namespace lesson6_4_10_2023
{
    class Team
    {
        private string name;  // назва команди
        private int games;    // к-сть ігор
        private int win;      // к-сть перемог
        private int draw;     // к-сть нічиїх
        private int lose;     // к-сть програшів



        // Конструктор з 5 параметрами
        public Team(string name, int games, int win, int draw, int lose)
        {
            this.name = name;
            this.games = games;
            this.win = win;
            this.draw = draw;
            this.lose = lose;
        }



        // Конструктор з 1 параметром
        public Team(string name) : this(name, 0, 0, 0, 0)
        { }

        // Метод тестування
        public void Print()
        {
            Console.Write(name + " => ");
            Console.Write("W-{0}  ", win);
            Console.Write("D-{0}  ", draw);
            Console.Write($"L-{lose}  ");
            Console.Write("G-" + games + "  ");
            Console.Write($"P-{CalcPoints()}");        
            Console.WriteLine();
        }

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        // Метод CalcPoints
        public int CalcPoints()
        {
            return win * 3 + draw;
        }

        // Статичний метод 
        /*
        public static int CalcPointsStatic(Team obj)
        {


 

        } 
        */



        // Властивості - це елементи класу, які реалізують 
        // зручний та наочний вигляд доступу до елементів або 
        // проведення якихось обчислень.
        // Виглядають як методи, тільки без дужок.



        public string Name
        {
            get { return name; }
            set { name = value; }  // тут value - контекстно-залежне слово
        }




    }



    class Program
    {
        static void Main(string[] args)
        {
            Team tm = new Team("Barselona", 8, 5, 2, 1);
            tm.Print();





            Console.ReadKey();
        }
    }
}