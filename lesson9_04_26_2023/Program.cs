using System;

namespace lesson9_04_26_2023
{

    /*class CharArray
    {
        private char[] A;

        public CharArray()
        {
            A = new char[26];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = (char)('A' + i);
            }
        }

        public char this[int index]
        {
            get
            {
                if (index >= 0 && index < A.Length)
                {
                    return A[index];
                }

                return 'A';
            }

            set
            {
                if (index >= 0 && index < A.Length)
                {
                    A[index] = value;
                }
            }
        }

        public void Print()
        {
            foreach (var c in A)
            {
                Console.Write(c + ' ');
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < A.Length; i++)
            {
                s += A[i] + " "; 
            }

            return s;
        }
    }*/

   /* class CharIndex
    {
        private int[] A;

        public CharIndex()
        {
            A = new int[26];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = (int)('A' + i);
            }
        }

        public int this[char symbol]
        {
            get
            {
                if (symbol >= 'A' && symbol <= 'Z')
                {
                    return A[(int)symbol - 'A'];
                }

                return 0;
            }

            set
            {
                if (symbol >= 'A' && symbol <= 'Z')
                {
                    A[(int)symbol - 'A'] = value;
                }
            }
        }
    }*/

   /*class TwoDimIndexer
   {
       private double[,] A;

       public TwoDimIndexer()
       {
           A = new double[3, 4];

           for (int i = 0; i < A.GetLength(0); i++)
           {
               for (int j = 0; j < A.GetLength(1); j++)
               {
                   A[i, j] = i * j + j * j;
               }
           }
       }

       public double this[int row, int column]
       {
           get { return A[row, column]; }
           set { A[row, column] = value; }
       }
   }*/
   // Оголошення

    internal class Program
    {
        public static void Main()
        {
            /*CharArray charArray = new CharArray();

            char c;

            c = charArray[3];
            Console.WriteLine("c = " + c);
            
            Console.WriteLine(charArray.ToString());*/
            
            Console.ReadKey();
        }
    }
}