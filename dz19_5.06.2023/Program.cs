using System;
using System.Collections.Generic;

namespace dz19_5._06._2023
{
    
    public class Queue<T>
    {
        private List<T> Q;
        private int maxCount;
        private int currentCount;

        public Queue(int maxCount)
        {
            this.maxCount = maxCount;
            Q = new List<T>(maxCount);
            currentCount = 0;
        }

        public void Clear()
        {
            Q.Clear();
            currentCount = 0;
        }

        public bool IsEmpty()
        {
            return currentCount == 0;
        }

        public void Move()
        {
            if (!IsEmpty())
            {
                T item = Q[0];
                Q.RemoveAt(0);
                Q.Add(item);
            }
        }

        public void Add(T item)
        {
            if (currentCount < maxCount)
            {
                Q.Add(item);
                currentCount++;
            }
            else
            {
                Console.WriteLine("Queue is full. Cannot add more items.");
            }
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T item = Q[0];
                Q.RemoveAt(0);
                currentCount--;
                return item;
            }
            else
            {
                Console.WriteLine("Queue is empty. Cannot pop item.");
                return default(T);
            }
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg);
            foreach (T item in Q)
            {
                Console.WriteLine(item);
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(5);

            queue.Add("Елемент 1");
            queue.Add("Елемент 2");
            queue.Add("Елемент 3");

            queue.Print("Початковий стан черги:");

            string item = queue.Pop();
            Console.WriteLine("Витягнутий елемент: " + item);

            queue.Move();

            queue.Print("Стан черги після витягнення та переміщення:");

            queue.Clear();

            Console.WriteLine("Чи черга порожня? " + queue.IsEmpty());

            Console.ReadLine();
        }
    }
}