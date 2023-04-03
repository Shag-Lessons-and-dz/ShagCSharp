using System;

namespace dz2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введіть рядок: ");
            string inputString = Console.ReadLine();

            int currentCount = 1;
            int maxCount = 1;

            if (inputString != null)
                for (int i = 1; i < inputString.Length; i++)
                {
                    if (inputString[i] == inputString[i - 1])
                    {
                        currentCount++;
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                        }
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }

            Console.WriteLine("Найбільша кількість символів, що йдуть підряд: " + maxCount);
        }
    }
}