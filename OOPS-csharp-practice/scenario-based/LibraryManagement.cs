using System;

class LibraryManagement
{
    static string[] titles = {
        "C Programming",
        "Learning C#",
        "Java Basics",
        "Python Guide",
        "Data Structures"
    };

    static string[] authors = {
        "Dennis Ritchie",
        "Microsoft",
        "James Gosling",
        "Guido van Rossum",
        "Mark Allen"
    };

    static bool[] isAvailable = new bool[titles.Length];
    static LibraryManagement()
    {
        for(int i=0;i<isAvailable.Length;i++)isAvailable[i] = true;

    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n============Application Started=================>");
            Console.WriteLine("\n📚 Library Management System");
            Console.WriteLine("1. Display All Books");
            Console.WriteLine("2. Search Book by Title");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayBooks();
                    break;

                case 2:
                    SearchBook();
                    break;

                case 3:
                    CheckoutBook();
                    break;

                case 4:
                    ReturnBook();
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the Library System!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 5);
    }

    // Display all books
    static void DisplayBooks()
    {
        Console.WriteLine("\nAvailable Books:\n");

        for (int i = 0; i < titles.Length; i++)
        {
            string status = isAvailable[i] ? "Available" : "Checked Out";
            Console.WriteLine($"{i + 1}. {titles[i]} by {authors[i]} - {status}");
        }
    }

    // Search book by partial title
    static void SearchBook()
    {
        Console.Write("\nEnter part of book title to search: ");
        string search = Console.ReadLine().ToLower();
        bool found = false;

        for (int i = 0; i < titles.Length; i++)
        {
            if (titles[i].ToLower().Contains(search))
            {
                string status = isAvailable[i] ? "Available" : "Checked Out";
                Console.WriteLine($"{i + 1}. {titles[i]} by {authors[i]} - {status}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No books found with that title.");
        }
    }

    // Checkout book
    static void CheckoutBook()
    {
        Console.Write("\nEnter book number to checkout: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < titles.Length)
        {
            if (isAvailable[index])
            {
                isAvailable[index] = false;
                Console.WriteLine($"'{titles[index]}' has been checked out successfully.");
            }
            else
            {
                Console.WriteLine("Book is already checked out.");
            }
        }
        else
        {
            Console.WriteLine("Invalid book number.");
        }
    }

    // Return book
    static void ReturnBook()
    {
        Console.Write("\nEnter book number to return: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < titles.Length)
        {
            if (!isAvailable[index])
            {
                isAvailable[index] = true;
                Console.WriteLine($"'{titles[index]}' has been returned successfully.");
            }
            else
            {
                Console.WriteLine("Book is already available.");
            }
        }
        else
        {
            Console.WriteLine("Invalid book number.");
        }
    }
}
