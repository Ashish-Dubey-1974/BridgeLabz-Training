
using System;
using System.Collections.Generic;

public class Library
{
    private Dictionary<string, LinkedList<Book>> catalog = new();
    private HashSet<Book> uniqueBooks = new();

    public void AddBook(string genre, Book book)
    {
        if (uniqueBooks.Contains(book))
        {
            Console.WriteLine($"Duplicate book ignored: {book}");
            return;
        }

        if (!catalog.ContainsKey(genre))
            catalog[genre] = new LinkedList<Book>();

        catalog[genre].AddLast(book);
        uniqueBooks.Add(book);
    }

    public void BorrowBook(string genre)
    {
        if (catalog.ContainsKey(genre) && catalog[genre].Count > 0)
        {
            var book = catalog[genre].First.Value;
            catalog[genre].RemoveFirst();
            uniqueBooks.Remove(book);
            Console.WriteLine($"Borrowed: {book}");
        }
        else
        {
            Console.WriteLine($"No books available in genre: {genre}");
        }
    }

    public void DisplayCatalog()
    {
        foreach (var genre in catalog.Keys)
        {
            Console.WriteLine($"Genre: {genre}");
            foreach (var book in catalog[genre])
            {
                Console.WriteLine($"  {book}");
            }
        }
    }
}
