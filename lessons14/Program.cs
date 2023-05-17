using System;
using static System.Console;
using System.Collections;
namespace lessons14
{
    class Book :IComparable
    {
        private string title;
        private string author;
        private int year;
        private double price;

        public Book(string title, string author, int year, double price)
        {
            this.author = author;
            this.title = title;
            this.year = year;
            this.price = price;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public override string ToString()
        {
            string s = "Title: " + title;
            s += ",Author: " + author;
            s += ",Year: " + year;
            s += ",Price: " + String.Format("{0:f2}", price);
            return s;

        }
        public int CompareTo(object obj)
        {
            if (obj is Book) 
            {
                int year2 = ((Book)obj).Year;
                if (year < year2)
                    return -1;
                else
                if (year == year2)
                    return 0;
                else
                    return 1;
            }
            throw new ArgumentException();
        }
    }
    class ArrayBooks : IEnumerable
    {
        private Book[] ab;
        public ArrayBooks()
        {
            ab = new Book[0];
        }
        public void Add(Book book)
        {
            Book[] ab2 = new Book[ab.Length + 1];
            ab.CopyTo(ab2, 0);
            ab2[ab.Length] = book;
            ab = ab2;
        }
        public void Print(string msg)
        {
            WriteLine(msg);
            foreach (Book book in ab)
                WriteLine(book);
            WriteLine("-----------------------------");
        }
        public IEnumerator GetEnumerator()
        {
            return ab.GetEnumerator();
        }
        public void Sort1()
        {
            for (int i = 0; i < ab.Length - 1; i++)
                for (int j = i; j >= 0; j--)
                    if (ab[j].Price > ab[j + 1].Price)
                    {
                        (ab[j], ab[j + 1]) = (ab[j + 1], ab[j]);
                    }
        }
        public void Sort2()
        {
            Array.Sort(ab);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayBooks ab = new ArrayBooks();

            ab.Add(new Book("t-1", "a-1", 2000, 23.55));
            ab.Add(new Book("t-2", "a-2", 2001, 15.80));
            ab.Add(new Book("t-3", "a-3", 2008, 29.00));
            ab.Add(new Book("t-4", "a-4", 2003, 17.00));
            ab.Add(new Book("t-5", "a-5", 2004, 18.50));
            ab.Print("AB");

            foreach (Book b in ab)
                WriteLine(b);
            WriteLine("------------------------");

            ab.Sort2();
            ab.Print("ab");
        }
    }
}