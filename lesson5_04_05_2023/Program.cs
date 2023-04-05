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
            
            
            Console.ReadKey();
        }
    }
}