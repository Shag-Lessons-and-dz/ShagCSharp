using System.Text;
using static System.Console;

namespace lesson2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*// Задача.

// 1. Оголошення змінних

            char symbol;

            int numSpaces = 0; // результат

            WriteLine("Please, enter the characters:");

// 2. Цикл вводу символів і обчислення результату

            do

            {

// ввести один символ

// int Read() - зчитує один символ з стандартного

// потоку вводу getchar(), getch(), gets(),

// getline()

                symbol = (char)Read();

// перевірка, чи символ є пробілом

                if (symbol == ' ')

                    numSpaces++;

            }

            while (symbol != '.');

// 3. Вивести результат

            WriteLine("numSpaces = " + numSpaces);

            ReadKey();*/
            
            /*// Задача.

// 1. Оголошення змінних

            int size; // Розмір масиву

            float[] A; // оголошення масиву

            float average; // середнє арифметичне - результат

// 2. Ввести розмір масиву

            Write("size = ");

            size = Int32.Parse(ReadLine());

// 3. Перевірка

            if (size <= 0)

            {

                WriteLine("Incorrect size.");

                ReadKey();

                return;

            }

// 4. Виділити пам'ять для масиву

            A = new float[size];

// 5. Ввести елементи масиву в циклі

// A.Length == size - к-сть елементів

            for (int i = 0; i < A.Length; i++)

            {

                Write("A[{0}] = ", i);

                A[i] = float.Parse(ReadLine());

            }

// Single - це є структура, яка є синонімом типу float

// 6. Обчислити середнє арифметичне

            average = 0.0f;

            for (int i = 0; i < A.Length; i++)

                average += A[i];

            average /= A.Length;

// 7. Вивести результат

            WriteLine("average = {0:f3}", average);

            ReadKey();*/
            
            /*// Задача.

// int A[100];

// int* A = new int[size];

//

// 1. Оголошення змінних

            int size; // розмір масиву

            System.Int32[] A; // вихідний масив

            int count; // кількість парних чисел - результат

            Random rnd; // випадкове число

// 2. Ввести розмір масиву

            Write("size = ");

            size = Convert.ToInt32(ReadLine());

// 3. Перевірка

            if (size <= 0)

            {

                WriteLine("Incorrect size.");

                ReadKey();

                return;

            }

// 4. Виділити пам'ять для масиву

            A = new Int32[size];

// 5. Ініціалізувати лічильник випадкових чисел

            rnd = new Random(); // rnd - тип-посилання

// 6. Сформувати масив

            for (int i = 0; i < A.Length; i++)

                A[i] = rnd.Next() % 10 + 1; // числа від 1 до 10

//A[i] = rnd.Next()

// 7. Вивести масив

            Write("A => ");

            for (int i = 0; i < A.Length; i++)

                Write("{0} ", A[i]);

// 8. Обчислити кількість парних елементів

            count = 0;

            for (int i = 0; i < A.Length; i++)

                if (A[i] % 2 == 0)

                    count++;

// 9. Вивести результат

            Write("count = " + count.ToString());

            ReadKey();*/

            /*string s1 = "Hello!";
            Console.WriteLine("s1 = " + s1);

            char[] ArrayChar = { 'H', 'e', 'l', 'l', 'o', '!' };
            string s2 = new string(ArrayChar);

            string s3 = new string(ArrayChar, 1, 2);

            string s4;
            s4 = "Hello!";
            WriteLine("s4 = " + s4);

            string s5 = new string('+', 10);
            WriteLine("s5 = " + s5);

            string s6;
            s6 = @"C:\Users\Chara\Desktop\Urovnenie .docx";
            WriteLine("s6 = {0}", s6);*/

           /* string s1 = "Hello, world!";
            char c = s1[5];
            WriteLine("c = {0}", c);

            int len = s1.Length;
            WriteLine("leb = {0}", len);

            /*char[] ArrayChar = new char[8];
            string s2 = "0123456789";
            s2.CopyTo(4, ArrayChar, 0, 8);
            WriteLine("s2 = " + s2);
            WriteLine("arrychar = " + ArrayChar.ToString());*/

            /*string s2 = "abcd";
            string s3 = "abcde";
            bool f = s2.Equals(s3);
            WriteLine("f = {0}", f);

            int res = s2.CompareTo(s3);
            WriteLine("res = " + res);

            string s4 = "abcdef";
            string s5 = "abcd";
            bool fStarW = s4.StartsWith(s5);
            WriteLine("f_starW = " + fStarW);
            
            string s6 = "abcdef";
            string s7 = "111def";
            bool fEndW = s6.EndsWith(s7);
            WriteLine("f_endW = " + fEndW);

            char[] chars = new char[8];
            string s8 = "www.bestprog.net";
            s8.CopyTo(4, chars, 0, 8);
            WriteLine(chars);

            string s9 = "abcdef abcdef";
            string s10 = "bcd";
            int index1 = s9.IndexOfAny(s10.ToCharArray());
            WriteLine("index1 = " + index1);
            int index2 = s9.LastIndexOfAny(s10.ToCharArray());
            WriteLine("index2 = " + index2);

            string s11 = "0123456789";
            string s12 = s11.Substring(3, 4);
            WriteLine("s12 = " + s12);*/

            /*string s;
            int d = 43;
            double x = 2.856;
            
            s = String.Format("Integer: {0,15:c}", d);
            WriteLine(s);

            s = String.Format("Double: {0,20:f5}", x);
            WriteLine(s);

            s = String.Format("Exponential: {0:E}", d);
            WriteLine(s);*/

            StringBuilder s1 = new StringBuilder();
            StringBuilder s2 = new StringBuilder(10);
            StringBuilder s3 = new StringBuilder("Hello, world!");

            s3.Append("!!");
            WriteLine(s3);
            
            ReadKey();
        }
    }
}