using System;

namespace BookBuddy
{
    class Program
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();

            while (true)
            {
                Console.WriteLine("\n--- BookBuddy Menu ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Sort Books");
                Console.WriteLine("4. Search by Author");
                Console.WriteLine("5. Export & Exit");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    if (choice == 1)
                    {
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        shelf.AddBook(title, author);
                        Console.WriteLine("Book added successfully.");
                    }
                    else if (choice == 2)
                    {
                        shelf.DisplayAll();
                    }
                    else if (choice == 3)
                    {
                        shelf.SortBooksAlphabetically();
                        Console.WriteLine("Books sorted.");
                    }
                    else if (choice == 4)
                    {
                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();
                        shelf.SearchByAuthor(author);
                    }
                    else
                    {
                        string[] exported = shelf.ExportBooks();
                        Console.WriteLine("\nExported Books:");
                        foreach (string b in exported)
                            Console.WriteLine(b);
                        break;
                    }
                }
                catch (InvalidBookFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}