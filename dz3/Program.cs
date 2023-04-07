using System;
using System.Linq;

namespace dz3
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] AD = new double[n];
            Random random = new Random();
            Console.Write("AD => ");
            for (int i = 0; i < AD.Length; i++)
            {
                AD[i] = random.NextDouble() * 10.0 - 5.0;
                Console.Write(" "+ AD[i].ToString("F3")+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("min = " + AD.Min().ToString("F3"));
            Console.WriteLine("max = " + AD.Max().ToString("F3"));

            Console.ReadKey();
        }
    }
}