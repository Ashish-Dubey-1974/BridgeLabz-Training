
using System;

class Program
{
    static void Main(string[] args)
    {
        Library lib = new();

        lib.AddBook("Fiction", new Book("1984", "George Orwell"));
        lib.AddBook("Fiction", new Book("Animal Farm", "George Orwell"));
        lib.AddBook("Science", new Book("A Brief History of Time", "Stephen Hawking"));

        lib.DisplayCatalog();

        lib.BorrowBook("Fiction");

        Console.WriteLine();
        lib.DisplayCatalog();
    }
}
