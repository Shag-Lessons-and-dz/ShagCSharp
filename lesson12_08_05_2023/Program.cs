using System;

namespace lesson12_08_05_2023
{
    class A
    {
        public void Show()
        {
            Console.WriteLine("A.Show()");
        }

        public void ShowA()
        {
            Console.WriteLine("A.ShowA()");
        }
    }

    class B : A
    {
        public new void Show()
        {
            Console.WriteLine("B.Show()");
        }

        public void ShowB()
        {
            Console.WriteLine("B.ShowB()");
        }
    } 
    
    class C : B
    {
        public new void Show()
        {
            Console.WriteLine("C.Show()");
        }

        public void ShowC()
        {
            Console.WriteLine("C.ShowCc()");
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            
        }
    }
}