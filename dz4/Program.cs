using System;
using System.Linq;

namespace dz4
{
    internal class Program
    {
        public class Book
        {
            private string Title = "";
            private string Name = "";
            private double Price = 0;
            private int Year = 0;

            public void Input()
            {
                Console.Write("Title: ");
                Title = Console.ReadLine();
                
                Console.Write("Name: ");
                Name = Console.ReadLine();
                
                Console.Write("Price: ");
                Price = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Year: ");
                Year = Convert.ToInt32(Console.ReadLine());
            }

            public void Output()
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Year: " + Year);
            }

            public void SetTitle(string _Title)
            {
                Title = _Title;
            }
            public string GetTitle()
            {
                return Title;
            }            
            
            public void SetName(string _Name)
            {
                Name = _Name;
            }            
            public string GetName()
            {
                return Name;
            }
            
            public void SetPrice(double _Price)
            {
                Price = _Price;
            }  
            public double GetPrice()
            {
                return Price;
            }
            
            public void SetYear(int _Year)
            {
                Year = _Year;
            }  
            public int GetYear()
            {
                return Year;
            }
        }
        
        public static void Main()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[n];

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book();
            }
            
            for (int i = 0; i < books.Length; i++)
            {
                books[i].Input();
            }

            for (int i = 0; i < books.Length; i++)
            {
                books[i].Output();
            }

            books.Last().SetTitle("Довга Хода");
            books.Last().SetName("Стівен Кінг, Річард Бакмен");
            books.Last().SetPrice(304);
            books.Last().SetYear(2023);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Title: " + books.Last().GetTitle());
            Console.WriteLine("Name: " + books.Last().GetName());
            Console.WriteLine("Price: " + books.Last().GetPrice());
            Console.WriteLine("Year: " + books.Last().GetYear());

            Console.ReadKey();
        }
    }
}