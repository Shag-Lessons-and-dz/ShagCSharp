using System;
using static System.Console;

namespace firstLesson
{
    internal class Program
    {
        public Program()
        {
        }

        public static void Main(string[] args)
        {
            /*double a, x;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            // a = Double.Parse(Console.ReadLine());
            x = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / (3.56));
            
            
            WriteLine("x = {0:f5}", x);
            WriteLine("Hello world");
            Write("Hi\n");

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
            }*/

           /* int year, month, day;
            Write("year = ");
            year = Int32.Parse(ReadLine());
            
            Write("month = ");
            month = Int32.Parse(ReadLine());
            
            Write("day = ");
            day = Int32.Parse(ReadLine());

            switch (month)
            {
                case 4: 
                case 6: 
                case 9: 
                case 11:
                    day = 30;
                    break;
                case 2:
                    bool f;
                    if (year%400==0)
                    {
                        f = true;
                    }else if (year%100==0)
                    {
                        f = false;
                    }
                    else if (year%4==0)
                    {
                        f = true;
                    }
                    else
                    {
                        f = false;
                    }

                    if (f)
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 31;
                    break;
            }
            
            WriteLine("days = {0}", day);*/

           double z, x, y;
           Write("x = ");
           x = Double.Parse(ReadLine());
           
           Write("y = ");
           y = Double.Parse(ReadLine());

           z = Math.Cos((3.2 + Math.Sqrt(1 + Math.Abs(x))) / 2.85) + Math.Exp(y);
           
           WriteLine("z = {0:f3}", z);
           ReadKey();
        }
    }
}