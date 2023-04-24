using System;

namespace lesson7_04_12_2023
{
    
    /*// Клас, який демонструє способи

// передачі аргументів у метод.

    class DemoPassingParameters

    {

// Метод, який отримує тип-значення за значенням.

// Тут робиться копія аргументу.

        public void PassingValueType(int a)

        {

            a = 100; // спроба змінити значення

        }

// Метод, який отримує параметром тип Integer

        public void PassingObjectType(Integer obj)

        {

// спроба змінити значення за посиланням obj

            obj.value = 100;

        }

// Метод, який отримує параметром ref-посилання

        public void PassingValueTypeRef(ref int a) // таке як в C++ знак &

        {

            a = 100;

        }

// Метод, який отримує ref-посилання на об'єкт

        public void PassingObjectTypeRef(ref Integer[] obj)

        {

            obj = new Integer[5];

            for (int i = 0; i < obj.Length; i++)

            {

                obj[i] = new Integer();

                obj[i].value = i + i;

            }

        }
        
        // Метод, який отримує out-параметр типу-значення 
        public void PassingValueTypeOut(out int a)
        {
            a = 100;// обов'язково щось потрібно присвоїти a
        }

        public void PassingObjectTypeOut(out Integer obj)
        {
            obj = new Integer();
            obj.value = 100;
        }

    }

// Деякий клас

    class Integer

    {

        public int value;

    }*/

   /* class Values
    {
        public int a;
        public static int static_a;
        public readonly int b;

        public Values()
        {
            b = 150;
        }
        
    }*/

   class Point
   {
       private double x, y;

       public Point(double x, double y)
       {
           this.x = x;
           this.y = y;
       }

       public double X
       {
           get { return x; }
           set { x = value; }
       }

       public double Y
       {
           get { return y; }
           set { y = value; }
       }
       
   }

   class ArrayPoint
   {
       private Point[] AP;
       private Random rnd;

       public ArrayPoint(int size)
       {
           AP = new Point[size];
           rnd = new Random();
           
           for (int i = 0; i < AP.Length; i++)
           {
               double x, y;
               x = rnd.NextDouble() * 20 - 10;
               y = rnd.NextDouble() * 20 - 10;
               AP[i] = new Point(x, y);
               
           }
       }

       public void Print()
       {
           for (int i = 0; i < AP.Length; i++)
           {
               Console.Write($"( {AP[i].X:F1}; {AP[i].Y:F1} )");
           }
           Console.WriteLine();
       }

       public Point this[int index]
       {
           get
           {
               if (index < 0 || index >= AP.Length)
               {
                   throw new IndexOutOfRangeException();
               }

               return AP[index];
           }

           set
           {
               if (index >= 0 && index < AP.Length)
               {
                   AP[index].X = value.X;
                   AP[index].Y = value.Y;
               }
           }
       }
       
       
   }
   
    internal class Program 
    {
        
        /*static void DemoRef(ref int a)
        {
            a = 100;
        }

        static void DemoOut(out int a)
        {
            a = 100;
        }*/

        /*static double Summ(params double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }

            return sum;
        }*/

        /*static byte Max(byte a = 1, byte b = 2, byte c = 3)
        {
            byte max = a;
            if (max < b) max = b;
            if (max < c)
            {
                max = c;
            }

            return max;
        }*/

        /*static float SumFloat4(float a, float b, float c, float d)
        {
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            Console.WriteLine("c = "+c);
            Console.WriteLine("d = "+d);
            Console.WriteLine("-----------------------------------");
            return a + b + c + d;
        }*/
        
        
        
        public static void Main(string[] args)
        {
           /*

            // Тема: Передача аргументів у функцію.

            // Існує 3 способи передачі аргументу в метод:

            - за значенням;

            - як ref-посилання;

            - як out-посилання.

            */

            /*DemoPassingParameters demoObj = new DemoPassingParameters();

            // 1. Передача типу-значення у метод за значенням

            int t = 200;

            demoObj.PassingValueType(t); // у методі робиться спроба зміни аргументу t

            Console.WriteLine("t = " + t);

            // t = 200 - при передачі за значенням робиться копія змінної-аргументу.

            // При цьому способі оригінал не змінюється.

            // 2. Передача типу-посилання у метод за значенням

            Integer objInt = new Integer();

            objInt.value = 200;

            demoObj.PassingObjectType(objInt); // objInt.value = 100 - зміна даних об'єкту

            Console.WriteLine("objInt.value = " + objInt.value);

            // У цьому випадку копіюється тільки посилання objInt.

            // Виходить, що в методі PassingObjectType() ми працюємо

            // з копією посилання, тобто з копією адреси за якою розміщуються

            // дані (value). Що оригінал, що копія адреси все одно вказують

            // на ту саму область пам'яті, яку можна змінити як з

            // оригіналу, так і з копії. Тому дані за адресою (value) були змінені.

            // ---------------- ref --------------------------------

            // 3. Передача ref-аргументу в метод, аргумент - тип значення

            t = 200;

            demoObj.PassingValueTypeRef(ref t);

            Console.WriteLine("t = " + t); // t = 100

            // 4. Передача ref-аргументу в метод, аргумент - тип посилання

            // Для типу-посилання можна змінити саме посилання

            Integer[] AI = new Integer[3];

            for (int i = 0; i < AI.Length; i++)

            {

                AI[i] = new Integer();

                AI[i].value = i * i;

            }

            // Тут відбувається зміна самого масиву AI

            demoObj.PassingObjectTypeRef(ref AI);

            Console.Write("AI => ");

            for (int i=0; i<AI.Length; i++)
            {

                Console.Write(AI[i].value + " ");

            }
            Console.WriteLine();

            t = 200;
            demoObj.PassingValueTypeOut(out t);
            Console.WriteLine("t = " + t);

            Integer integer;
            demoObj.PassingObjectTypeOut(out integer);
            Console.WriteLine("integer.value = " + integer.value);
            */

            /*int t = 0;
            DemoRef(ref t);
            Console.WriteLine("t = "+t);
            
            int x;
            DemoOut(out x);
            Console.WriteLine("x = "+x);*/

            /*double summ;
            summ = Summ(1.6, 2.8, 3.1);
            Console.WriteLine("sum = "+summ);*/

            /*byte max = Max();
            Console.WriteLine("Max() = "+max);

            max = Max(5);
            Console.WriteLine("Max(5) = "+max);

            max = Max(3, 2);
            Console.WriteLine("Max(3, 2) = "+max);
            
            max = Max(4, 5, 1);
            Console.WriteLine("Max(4, 5, 1) = "+max);*/

            /*float sum = SumFloat4(1.1f, 2.5f, 3.8f, 4.1f);
            Console.WriteLine("sum = "+sum);

            sum = SumFloat4(b: 1.7f, c: 2.8f, d:-0.5f, a:1.4f);
            Console.WriteLine("sum = "+sum);*/

            /*Values values = new Values();
            values.a = 100;
            values.a = values.a + 5;*/

            ArrayPoint AP = new ArrayPoint(6);
            AP.Print();

            Point pt = AP[3];
            Console.WriteLine("pt.X = {0:F1}, pt.Y = {1:F1}", pt.X, pt.Y);

            AP[2] = new Point(100, 200);
            AP.Print();
            
            Console.ReadKey();
        }
    }
}