using System;

namespace lesson11_05._03._2023
{
    public class Outer
    {
        // Вложенный класс
        public class Inner
        {
            public int a;
        }

        Inner objInner = new Inner();
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Создать объект вложенного класса
            Outer.Inner objInner = new Outer.Inner();
            objInner.a = 100;


            Console.ReadKey();
        }

    }
}