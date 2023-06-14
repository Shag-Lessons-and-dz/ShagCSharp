using System;

namespace dz14_17._05._2023
{
    
    public class MyException1 : ApplicationException
    {
        public MyException1(string message) : base(message)
        {
        }
    }

    public class MyException2 : ApplicationException
    {
        public MyException2(string message) : base(message)
        {
        }
    }

    public class MyException3 : ApplicationException
    {
        public MyException3(string message) : base(message)
        {
        }
    }

    public class ArrayFloat
    {
        private float[] AF;

        public ArrayFloat(int size)
        {
            AF = new float[size];

            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                AF[i] = random.Next(1, 11);
            }
        }

        public float this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new MyException1("Negative index");
                }

                if (index >= AF.Length)
                {
                    throw new MyException2("Index out of range");
                }

                return AF[index];
            }
            set
            {
                if (index < 0)
                {
                    throw new MyException1("Negative index");
                }

                if (index >= AF.Length)
                {
                    throw new MyException2("Index out of range");
                }

                AF[index] = value;
            }
        }

        public void Set(float value, int index)
        {
            if (index < 0 || index >= AF.Length)
            {
                throw new MyException3("Invalid index");
            }

            AF[index] = value;
        }
    }
    
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            ArrayFloat arrayFloat = new ArrayFloat(5);

            try
            {
                Console.WriteLine(arrayFloat[-1]);
            }
            catch (MyException1 ex)
            {
                Console.WriteLine("Exception MyException1: " + ex.Message);
            }

            try
            {
                Console.WriteLine(arrayFloat[10]);
            }
            catch (MyException2 ex)
            {
                Console.WriteLine("Exception MyException2: " + ex.Message);
            }

            try
            {
                arrayFloat.Set(100, 2);
            }
            catch (MyException3 ex)
            {
                Console.WriteLine("Exception MyException3: " + ex.Message);
            }
        }
    }
}