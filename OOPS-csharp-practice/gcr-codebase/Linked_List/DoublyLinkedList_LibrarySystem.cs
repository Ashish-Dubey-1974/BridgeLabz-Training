
class BookNode
{
    public int BookId;
    public string Title;
    public string Author;
    public bool Available;
    public BookNode Next, Prev;

    public BookNode(int id, string title, string author, bool available)
    {
        BookId = id;
        Title = title;
        Author = author;
        Available = available;
    }
}
