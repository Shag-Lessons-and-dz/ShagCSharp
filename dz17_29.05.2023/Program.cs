using System;

namespace dz17_29._05._2023
{
    
    public struct Book
{
    private string title;
    private string author;
    private int year;
    private double price;

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

    public Book(string title, string author, int year, double price)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.price = price;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Price: {price}");
    }

    public static bool operator ==(Book book1, Book book2)
    {
        return book1.price == book2.price;
    }

    public static bool operator !=(Book book1, Book book2)
    {
        return book1.price != book2.price;
    }
}

public class QueueBook
{
    private Book[] books;
    private int size;
    private int capacity;

    public QueueBook()
    {
        capacity = 10;
        books = new Book[capacity];
        size = 0;
    }

    public QueueBook(Book[] initialBooks)
    {
        capacity = initialBooks.Length;
        books = new Book[capacity];
        size = 0;

        foreach (var book in initialBooks)
        {
            AddBook(book);
        }
    }

    public void AddBook(Book book)
    {
        if (size == capacity)
        {
            capacity *= 2;
            Array.Resize(ref books, capacity);
        }

        books[size] = book;
        size++;
    }

    public void AddBookAtPos(Book book, uint position)
    {
        if (position >= size)
        {
            throw new IndexOutOfRangeException("Position is out of range.");
        }

        if (size == capacity)
        {
            capacity *= 2;
            Array.Resize(ref books, capacity);
        }

        for (int i = size - 1; i >= position; i--)
        {
            books[i + 1] = books[i];
        }

        books[position] = book;
        size++;
    }

    public void PrintBooks()
    {
        if (size == 0)
        {
            Console.WriteLine("The queue is empty.");
            return;
        }

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Book {i + 1}:");
            books[i].Print();
            Console.WriteLine();
        }
    }

    public Book PopBook()
    {
        if (size == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        Book book = books[0];

        for (int i = 1; i < size; i++)
        {
            books[i - 1] = books[i];
        }

        size--;

        return book;
    }

    public Book PopBookAtPos(uint position)
    {
        if (position >= size)
        {
            throw new IndexOutOfRangeException("Position is out of range.");
        }

        Book book = books[position];

        for (int i = (int)position + 1; i < size; i++)
        {
            books[i - 1] = books[i];
        }

        size--;

        return book;
    }
}
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book[] initialBooks = new Book[]
            {
                new Book("Book 1", "Author 1", 2000, 19.99),
                new Book("Book 2", "Author 2", 2005, 29.99),
                new Book("Book 3", "Author 3", 2010, 14.99)
            };

            QueueBook queue = new QueueBook(initialBooks);

            Book newBook = new Book("New Book", "New Author", 2021, 9.99);
            queue.AddBook(newBook);

            Book anotherBook = new Book("Another Book", "Another Author", 2015, 24.99);
            queue.AddBookAtPos(anotherBook, 2);

            queue.PrintBooks();

            Book poppedBook = queue.PopBook();
            Console.WriteLine("Popped Book:");
            poppedBook.Print();
            Console.WriteLine();

            Book poppedBookAtPos = queue.PopBookAtPos(1);
            Console.WriteLine("Popped Book at Position 1:");
            poppedBookAtPos.Print();
            Console.WriteLine();

            queue.PrintBooks();
            Console.ReadKey();
        }
    }
}