using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace dz18_31._05._2023
{
    [Serializable]
    public class Worker
    {
        private string name;
        private int age;
        private string position;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public Worker(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Position: {position}");
        }
    }


    public class ArrayWorkers
{
    private List<Worker> AW;

    public ArrayWorkers()
    {
        AW = new List<Worker>();
    }

    public void Add(Worker W)
    {
        AW.Add(W);
    }

    public void Del(int index)
    {
        if (index < 0 || index >= AW.Count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        AW.RemoveAt(index);
    }

    public void Print(string format)
    {
        switch (format)
        {
            case "txt":
                PrintToFileTxt(Console.Out);
                break;
            case "bin":
                PrintToFileBin(Console.OpenStandardOutput());
                break;
            default:
                Console.WriteLine("Invalid format specified.");
                break;
        }
    }

    public void SaveToFileTxt(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var worker in AW)
            {
                writer.WriteLine($"Name: {worker.Name}");
                writer.WriteLine($"Age: {worker.Age}");
                writer.WriteLine($"Position: {worker.Position}");
                writer.WriteLine();
            }
        }
    }

    public void ReadFromFileTxt(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            string name = null;
            int age = 0;
            string position = null;

            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Name: "))
                {
                    name = line.Substring(6);
                }
                else if (line.StartsWith("Age: "))
                {
                    int.TryParse(line.Substring(5), out age);
                }
                else if (line.StartsWith("Position: "))
                {
                    position = line.Substring(10);
                }
                else if (string.IsNullOrWhiteSpace(line))
                {
                    if (name != null && age > 0 && position != null)
                    {
                        Worker worker = new Worker(name, age, position);
                        Add(worker);
                    }

                    name = null;
                    age = 0;
                    position = null;
                }
            }
        }
    }


    public void SaveToFileBin(string filename)
    {
        using (FileStream stream = new FileStream(filename, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, AW);
        }
    }

    public void ReadFromFileBin(string filename)
    {
        using (FileStream stream = new FileStream(filename, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            AW = (List<Worker>)formatter.Deserialize(stream);
        }
    }

    private void PrintToFileTxt(TextWriter writer)
    {
        foreach (var worker in AW)
        {
            writer.WriteLine($"Name: {worker.Name}");
            writer.WriteLine($"Age: {worker.Age}");
            writer.WriteLine($"Position: {worker.Position}");
            writer.WriteLine();
        }
    }

    private void PrintToFileBin(Stream stream)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(stream, AW);
    }
}

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            ArrayWorkers workers = new ArrayWorkers();

            Worker worker1 = new Worker("John Smith", 30, "Manager");
            Worker worker2 = new Worker("Jane Doe", 25, "Developer");
            Worker worker3 = new Worker("Mike Johnson", 35, "Designer");

            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);

            workers.SaveToFileTxt("workers.txt");
            workers.SaveToFileBin("workers.bin");

            ArrayWorkers workersFromTxt = new ArrayWorkers();
            workersFromTxt.ReadFromFileTxt("workers.txt");
            Console.WriteLine("Workers from TXT:");
            workersFromTxt.Print("txt");

            ArrayWorkers workersFromBin = new ArrayWorkers();
            workersFromBin.ReadFromFileBin("workers.bin");
            Console.WriteLine("Workers from BIN:");
            workersFromBin.Print("txt");

            Console.ReadKey();
        }
    }
}