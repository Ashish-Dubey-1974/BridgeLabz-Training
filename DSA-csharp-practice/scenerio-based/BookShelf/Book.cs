
using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Book other)
            return Title == other.Title && Author == other.Author;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Author);
    }
}
