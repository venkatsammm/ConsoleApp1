using System;

namespace OOPMiniProject
{
    // Base class
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Brand { get; set; }

        public Product(string name, double price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Price        : ${Price}");
            Console.WriteLine($"Brand        : {Brand}");
        }
    }

    // Derived class
    public class Book : Product
    {
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Genre { get; set; }

        public Book(string name, double price, string brand, string author, int pages, string genre)
            : base(name, price, brand)
        {
            Author = author;
            Pages = pages;
            Genre = genre;
        }

        // Method overriding
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author       : {Author}");
            Console.WriteLine($"Pages        : {Pages}");
            Console.WriteLine($"Genre        : {Genre}");
        }
    }

    // Program entry point
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book(
                "The C# Chronicles",
                39.99,
                "CodeVerse",
                "Venkat V",
                450,
                "Programming"
            );

            Console.WriteLine("📚 Book Details:\n");
            myBook.DisplayInfo();
        }
    }
}
