using System;
using System.Collections;

namespace practica8_31._05._23
{
    class ConverterCollections
    {
        public static Stack ConvertQueueToStack(Queue q)
        {
            Stack s = new Stack();
            Queue q2 = new Queue();

            while (q.Count > 0)
            {
                var item = q.Dequeue();
                
                s.Push(item);
                
                q2.Enqueue(item);
            }
            
            foreach (object t in q2)
                q.Enqueue(t);
            
            return s;
        }
        
        public static Queue ConvertStackToQueue(Stack s)
        {
            var q = new Queue();
            
            while (s.Count > 0)
            {
                var item = s.Pop();
                
                q.Enqueue(item);
            }

            return q;
        }
        
        public void PrintStack(Stack s)
        {
            ArrayList al = new ArrayList();

            Console.Write("Stack => ");
            while (s.Count > 0)
            {
                var item = s.Pop();
                Console.Write(item + " ");
                al.Insert(0, item);
            }

            foreach (object t in al)
                s.Push(t);
        }
        
        public void PrintQueue(Queue q)
        {
            Console.Write("Queue => ");
            foreach (object item in q)
                Console.Write(item + " ");
        }
    }

    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            ConverterCollections converter = new ConverterCollections();
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            converter.PrintStack(stack);
            Console.WriteLine();
            
            var queue = ConverterCollections.ConvertStackToQueue(stack);
            
            converter.PrintQueue(queue);
            Console.WriteLine();
            
            stack = ConverterCollections.ConvertQueueToStack(queue);
            converter.PrintStack(stack);

            Console.ReadKey();
        }
    }
}
