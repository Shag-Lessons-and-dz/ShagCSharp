using System;
using System.Text;

namespace lesson5_04_05_2023
{
    internal class Program
    {
        public static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder("abcdefghi");
            int capacity, maxcapacity;
            capacity = stringBuilder.Capacity;
            maxcapacity = stringBuilder.MaxCapacity;
            Console.WriteLine("sb8 = " + stringBuilder);
            Console.WriteLine("capacity = " + capacity);
            Console.WriteLine("maxcapacity = " + maxcapacity);
            
            // Багатовимірні масиви - це двохвимірні,
            // тривимірні і т.д. масиви.
            

            // 1. Оголошення тривимірного масиву
            ulong[,,] A;
            
            // 2. Виділення пам'яті
            A = new ulong[3, 4, 5];
            

            // 3. Заповнити значеннями
            for (int i = 0; i < A.GetLength(0); i++)
            for (int j = 0; j < A.GetLength(1); j++)
            for (int k = 0; k < A.GetLength(2); k++)
                A[i, j, k] = (ulong)(i + j + k);
            
            // 4. Вивести на екран
            Console.WriteLine("A:");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                // Вивід таблиці
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(2); k++)
                        Console.Write(A[i, j, k] + "  ");
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------");
            }
            
            Console.ReadKey();
        }
    }
}