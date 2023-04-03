using System;

namespace lesson4
{
    internal class Program
    {
        class Student
        {
            private string name = "";
            private int code = 0;
            private string group = "";
            private double rank = 0;
            
            public void Input()
            {
                Console.Write("name = ");
                name = Console.ReadLine();
            
                Console.Write("Code = ");
                code = Convert.ToInt32(Console.ReadLine());
            
                Console.Write("group = ");
                group = Console.ReadLine();
            
                Console.Write("rank = ");
                rank = Double.Parse(Console.ReadLine());
            }

            public void Output()
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("name = " + name);
                Console.WriteLine("code = " + code);
                Console.WriteLine("group = " + group);
                Console.WriteLine("rank = " + rank);
            }

            public string GetName()
            {
                return name;
            }

            public int GetCode()
            {
                return code;
            }

            public string GetGroup()
            {
                return group;
            }

            public double GetRank()
            {
                return rank;
            }

            public void SetName(string _name)
            {
                name = _name;
            }
            
            public void SetCode(int _code)
            {
                code = _code;
            }
            
            public void SetGroup(string _group)
            {
                group = _group;
            }
            
            public void SetRank(double _rank)
            {
                rank = _rank;
            }
        }

        public static void Main()
        {
            /*uint n;
            Console.Write("n = ");
            n = Convert.ToUInt32(Console.ReadLine());
            Student[] students;
            students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
            
            Console.WriteLine("Enter students: ");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Input();
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("Entered data: ");
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Output();
                Console.WriteLine("--------------------------");
            }*/

            long[] l = new long[10];
            /*Random random = new Random();
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = random.Next(10, 20);
            }

            foreach (var t in l)
            {
                Console.WriteLine(t);
            }

            long sum = 0l;
            for (int i = 0; i < l.Length; i++)
            {
                sum += l[i] * l[i];
            }

            Console.WriteLine("sum = " + sum);*/

            for (int i = 0; i < l.Length; i++)
            {
                l[i] = i * i;
            }

            long[] l2;
            l2 = new long[l.Length];
            
            l.CopyTo(l2, 0);
            for (int i = 0; i < l2.Length; i++)
            {
                Console.Write(l2[i] + "  ");
            }
            Console.WriteLine();
            
            Console.ReadKey();
        }
    }
}