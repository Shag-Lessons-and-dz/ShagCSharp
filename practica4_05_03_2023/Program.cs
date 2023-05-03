using System;

namespace practica4_05_03_2023
{
    public class Book
    {
        private string title;
        private string author;
        private double price;
        private int year;
        
        public Book(string title, string author, double price, int year)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.year = year;
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
    
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        
        public void Print()
        {
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}\nYear: {3}", title, author, price, year);
        }
    }
    
    public class BookGener : Book
    {
        private string genre;
        
        public BookGener(string title, string author, double price, int year, string genre) : base(title, author, price, year)
        {
            this.genre = genre;
        }
        
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Genre: {0}", genre);
        }
    }
    
    public class ВоокGenrePubl : BookGener
    {
        private string publisher;

        public ВоокGenrePubl(string title, string author, double price, int year, string genre, string publisher)
            : base(title, author, price, year, genre)
        {
            this.publisher = publisher;
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Publisher: {publisher}");
        }
    }

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 14.99, 1925);
            book.Print();

            Console.WriteLine();
            
            BookGener genreBook = new BookGener(book.Title, book.Author, book.Price, book.Year, "Fiction");
            genreBook.Print();

            Console.WriteLine();
            
            ВоокGenrePubl publBook = new ВоокGenrePubl(book.Title, book.Author, book.Price, book.Year, genreBook.Genre, "Secker & Warburg");
            publBook.Print();

            Console.ReadKey();
        }
    }
}