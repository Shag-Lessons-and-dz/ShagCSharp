using System;
using System.Text;

namespace lesson3
{
    internal class Program
    {
        public static void Main()
        {
            /*string s1 = "Hello world!";
            char c = s1[0];
            Console.WriteLine(c);

            string s2 = "1234";
            string s3 = "567";
            
            s2 = String.Concat(s2, s3);
            Console.WriteLine(s2);

            s2 = "abcd" + "efg";
            Console.WriteLine(s2);

            s2 = "Добрий день!";
            s3 = s2.ToUpper();
            Console.WriteLine(s3);

            string s4 = "abcdefghi abcd def abc";
            string s5 = s4.Replace("abc", "AAAAA");
            Console.WriteLine(s5);

            string s6 = "0123456789";
            s4 = s6.Insert(2, "AAAAA");
            Console.WriteLine(s4);

            s6 = "0123456789";
            s4 = s6.Remove(3, 4);
            Console.WriteLine(s4);
            s6 = s6.Insert(0, "+");
            Console.WriteLine(s6);

            string s7 = "It sddsadad";
            bool f_is1 = s7.Contains("It");
            Console.WriteLine("f_is1 = " + f_is1);

            string s8 = "abc,def;dsfsdf sdfs. sdf";
            char[] chars = {' ', ',', '.', ';' };
            string[] AS;
            AS = s8.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < AS.Length; i++)
            {
                Console.WriteLine(AS[i]);
            }

            string[] AS2 = { "abc", "def", "ghij", "op" };
            s8 = String.Join("+", AS2);
            Console.WriteLine(s8);*/

            /*string s;
            int x = 225;
            double y = 12.33785;
            
            s = String.Format("Integer: {0,15:c}", x);
            Console.WriteLine(s);
            
            s = String.Format("Hexadecimal: {0:x}", x);
            Console.WriteLine(s);
            
            s = String.Format("Real: {0,2:f3}", y);
            Console.WriteLine(s);

            s = String.Format("Exponental: {0:E}", y);
            Console.WriteLine(s);*/

            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder(10);
            StringBuilder stringBuilder3 = new StringBuilder("Hello, world!");

            stringBuilder2 = new StringBuilder("abcd");

            stringBuilder2[0] = '+';
            Console.WriteLine(stringBuilder2);

            stringBuilder3.Append("!!");
            Console.WriteLine(stringBuilder3);

            StringBuilder stringBuilder4 = new StringBuilder("asdasdasd");
            stringBuilder = stringBuilder4.Insert(0, 2.88);
            Console.WriteLine(stringBuilder);

            stringBuilder4 = new StringBuilder("0123456789");
            stringBuilder4.Remove(3, 4);
            Console.WriteLine(stringBuilder4);

            StringBuilder stringBuilder5 = new StringBuilder("asfafs asfasf asfasf");
            stringBuilder5.Replace("asfasf", "AAAAA");
            Console.WriteLine(stringBuilder5);

            StringBuilder stringBuilder6 = new StringBuilder("abcd");
            char[] AC = new char[10];
            stringBuilder6.CopyTo(0, AC, 0, stringBuilder6.Length);
            Console.WriteLine(AC);

            StringBuilder stringBuilder7 = new StringBuilder("abcd");
            String str;
            str = stringBuilder7.ToString();
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}