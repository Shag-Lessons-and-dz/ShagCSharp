using System;

namespace dz15_22._05._2023
{
    
    public class Calculator
    {
        public delegate double Operations(double num1, double num2);

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return num1 / num2;
        }

        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply");
            int choice = Convert.ToInt32(Console.ReadLine());

            Calculator.Operations operation = null;

            switch (choice)
            {
                case 1:
                    operation = calculator.Add;
                    break;
                case 2:
                    operation = calculator.Sub;
                    break;
                case 3:
                    operation = Calculator.Div;
                    break;
                case 4:
                    operation = Calculator.Mult;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            double result = operation(num1, num2);
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}