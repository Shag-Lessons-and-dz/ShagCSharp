using System;

namespace lesson7_04_12_2023
{
    
    // Клас, який демонструє способи

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

    }

// Деякий клас

    class Integer

    {

        public int value;

    }
    
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            /*

            // Тема: Передача аргументів у функцію.

            // Існує 3 способи передачі аргументу в метод:

            - за значенням;

            - як ref-посилання;

            - як out-посилання.

            */

            DemoPassingParameters demoObj = new DemoPassingParameters();

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

            Console.ReadKey();
        }
    }
}