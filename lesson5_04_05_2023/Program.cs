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
            /*ulong[,,] A;
            
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
            }*/
            
            // Ступінчаті масиви (Stepped arrays)

            // 1. Оголошення посилання на двовимірний ступінчатий масив
            /*int[][] A;

            // 2. Виділення пам'яті для масиву посилань
            A = new int[5][]; // 5 рядків

            // 3. Виділення пам'яті для кожного рядка
            A[0] = new int[3];// A[0] = [ 2, 3, 8 ]
            A[1] = new int[7];// A[1] = [ 2, 3, 4, 8, 2, 3, 9 ]
            A[2] = new int[5];
            A[3] = new int[10];
            A[4] = new int[9];

          // 4. Заповнення масиву значеннями
            for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < A[i].Length; j++)
                A[i][j] = i + j;
            

            // 5. Виведення масиву
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                    Console.Write(A[i][j] + " ");
                Console.WriteLine();
            }*/
            
            // 1. Оголошення масиву з 5 двовимірних масивів
            float[][,] A;

            A = new float[5][,];// 5 двовимірних масивів

            // виділення пам'яті для кожного масиву
            for (int i = 0; i < A.Length; i++)
                A[i] = new float[3, 4];

            // 2. Заповнення масиву довільними значеннями
            for (int i = 0; i < A.Length; i++)
            for (int j = 0; j < A[i].GetLength(0); j++)
            for (int k = 0; k < A[i].GetLength(1); k++)
                A[i][j, k] = i + j + k;


            // 3. Вивід
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].GetLength(0); j++)
                {
                    for (int k = 0; k < A[i].GetLength(1); k++)
                        Console.Write(A[i][j, k] + "\t");
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------");
            }
            
            Console.ReadKey();
        }
    }
}