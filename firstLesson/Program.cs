using System;
using static System.Console;

namespace firstLesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*double a, x;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            // a = Double.Parse(Console.ReadLine());
            x = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / (3.56));
            
            
            WriteLine("x = {0:f5}", x);
            WriteLine("Hello world");
            Write("Hi\n");*/

            int number;
            int digit1, digit2;
            Write("number = ");
            number = Convert.ToInt32(ReadLine());

            if ((number < 10) || (number > 99))
            {
                WriteLine("ERROR");   
                return;
            }

            digit1 = number / 10;
            digit2 = number % 10;
                
            if (digit1 + digit2 > 9)
            {
                WriteLine("number = {0}", digit1 + digit2);
            }
            else
            {
                WriteLine("<=9");
            }
            
            ReadKey();
        }
    }
}