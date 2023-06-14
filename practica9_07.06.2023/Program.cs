using System;
using System.Collections.Generic;
using System.IO;

namespace practica9_07._06._2023
{
    
    public class ProcessFile
    {
        public static void SaveQueueToFileBin(string filename, Queue<double> q)
        {
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
                {
                    foreach (double number in q)
                    {
                        writer.Write(number);
                    }
                }

                Console.WriteLine("Очередь успешно сохранена в файле: " + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении очереди в файле: " + ex.Message);
            }
        }

        public static Queue<double> ReadQueueFromFile(string filename)
        {
            Queue<double> q = new Queue<double>();

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        double number = reader.ReadDouble();
                        q.Enqueue(number);
                    }
                }

                Console.WriteLine("Очередь успешно считана из файла: " + filename);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении очереди из файла: " + ex.Message);
            }

            return q;
        }
    }
    
    internal abstract class Program
    {
        public static void Main()
        {
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(3.14);
            queue.Enqueue(2.718);
            queue.Enqueue(1.618);
            queue.Enqueue(1.62);
            
            string filename = "queue.bin";
            
            ProcessFile.SaveQueueToFileBin(filename, queue);
            
            Queue<double> newQueue = ProcessFile.ReadQueueFromFile(filename);
            
            foreach (double number in newQueue)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}