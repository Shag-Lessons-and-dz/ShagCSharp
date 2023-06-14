using System;

namespace dz12_10._05._2023
{
    
    public interface IHuman
    {
        string HumanName { get; set; }
        string HumanSurname { get; set; }
        int Age();
        void Info(string message);
    }

    public class Student : IHuman
    {
        public int Course { get; set; }
        public string HumanName { get; set; }
        public string HumanSurname { get; set; }
        public int age { get; set; }

        public Student(int course, string name, string surname, int _age)
        {
            Course = course;
            HumanName = name;
            HumanSurname = surname;
            age = _age;
        }

        public int Age()
        {
            return age;
        }
        
        public void Info(string message)
        {
            Console.WriteLine($"Student: {HumanSurname}, {HumanName} (Course: {Course}, Age: {age})");
            Console.WriteLine($"Info: {message}");
        }
    }

    public class Aspirant : IHuman
    {
        public string Theme { get; set; }
        public string HumanName { get; set; }
        public string HumanSurname { get; set; }
        public int age { get; set; }

        public Aspirant(string theme, string name, string surname, int _age)
        {
            Theme = theme;
            HumanName = name;
            HumanSurname = surname;
            age = _age;
        }

        public int Age()
        {
            return age;
        }

        public void Info(string message)
        {
            Console.WriteLine($"Aspirant: {HumanSurname}, {HumanName} (Theme: {Theme}, Age: {age})");
            Console.WriteLine($"Info: {message}");
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student(3, "John", "Doe", 20);
            Aspirant aspirant = new Aspirant("Research Topic", "Jane", "Smith", 25);

            student.Info("This is a student.");
            aspirant.Info("This is an aspirant.");
        }
    }
}