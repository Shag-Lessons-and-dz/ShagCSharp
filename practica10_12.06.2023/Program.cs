using System;
using System.Linq;

namespace practica10_12._06._2023
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            Console.WriteLine("Масив чисел: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            int count = numbers.Count(x => x % 7 == 0 && x > 20);
            Console.WriteLine("Кількість елементів, кратних 7 і більших за 20: " + count);
            
            int sum = numbers.Where(x => x % 2 == 0 && x > 3).Sum();
            Console.WriteLine("Сума парних елементів, які більші за 3: " + sum);

            Console.ReadLine();
        }
    }
}