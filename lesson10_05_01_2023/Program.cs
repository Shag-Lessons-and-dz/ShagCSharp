using System;

namespace lesson10_05_01_2023
{
    public class Integer
    {
        private int value;
        public Integer(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            string s = "value = " + value.ToString();
            return s;
        }

        public static Integer operator -(Integer obj)
        {
            Integer objInt = new Integer(-obj.value);
            return objInt;
        }
        
        public static Integer operator ++(Integer obj)
        {
            return new Integer(obj.value + 1);
        }        
        
        public static Integer operator +(Integer obj, Integer obj1)
        {
            Integer obj2 = new Integer(obj.value + obj1.value);
            return obj2;
        }        
        
        public static Integer operator *(Integer obj, Integer obj1)
        {
            Integer obj2 = new Integer(obj.value * obj1.value);
            return obj2;
        }
        
        public static bool operator !(Integer obj)
        { 
            if (obj.value == 0)
                return true;
            else 
                return false;
        }
    }
    
    
    internal class Program
    {
        public static void Main()
        {
            Integer i1 = new Integer(10);
            Integer i2 = -i1;
            Console.WriteLine("i2: " + i2);
            i2++;
            Console.WriteLine("i2: " + i2);
            i2 = new Integer(-2);
            bool f = !i2;
            Console.WriteLine("f = " + f.ToString());
            Integer i3 = i1 * i2;
            Console.WriteLine("i1 * i2 = " + i3);
            
            Console.ReadKey();
        }
    }
}