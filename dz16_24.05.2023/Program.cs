using System;

namespace dz16_24._05._2023
{
    
    public delegate void ExamDelegate(string task);

    public class Student
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public void Exam(string task)
        {
            Console.WriteLine($"Student {Name} is solving the task: {task}");
        }
    }

    public class Teacher
    {
        public event ExamDelegate ExamEvent;

        public void ExamStudents()
        {
            if (ExamEvent != null)
            {
                ExamEvent.Invoke("Exam task");
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student[] students = new Student[3];

            students[0] = new Student { Name = "John Smith", BirthDate = new DateTime(2000, 5, 15) };
            students[1] = new Student { Name = "Alice Johnson", BirthDate = new DateTime(1999, 10, 3) };
            students[2] = new Student { Name = "David Brown", BirthDate = new DateTime(2001, 2, 25) };

            Teacher teacher = new Teacher();

            foreach (var student in students)
            {
                teacher.ExamEvent += student.Exam;
            }

            teacher.ExamStudents();
            
            teacher.ExamEvent -= students[0].Exam;

            Console.WriteLine("\nFirst student has finished the exam.\n");

            teacher.ExamStudents();
            Console.ReadKey();
        }
    }
}