using System;
using System.Collections;

namespace BookBuddy
{
    public class BookShelf
    {
        private ArrayList books = new ArrayList();

        public void AddBook(string title, string author)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
                throw new InvalidBookFormatException("Invalid book format. Title or Author missing.");

            books.Add(title + " - " + author);
        }

        public void SortBooksAlphabetically()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty.");

                books.Sort();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void SearchByAuthor(string author)
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("No books to search.");

                bool found = false;
                foreach (string book in books)
                {
                    string[] parts = book.Split('-');
                    if (parts.Length != 2)
                        throw new InvalidBookFormatException("Stored book format is invalid.");

                    if (parts[1].Trim().Equals(author, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(book);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No books found for author: " + author);
            }
            catch (InvalidBookFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string[] ExportBooks()
        {
            string[] result = new string[books.Count];
            books.CopyTo(result);
            return result;
        }

        public void DisplayAll()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty.");

                foreach (string book in books)
                    Console.WriteLine(book);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}