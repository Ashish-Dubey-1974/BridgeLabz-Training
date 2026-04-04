
class MovieNode
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public MovieNode Next, Prev;

    public MovieNode(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
    }
}

class MovieDoublyList
{
    private MovieNode head;

    public void Add(MovieNode node)
    {
        if (head == null) { head = node; return; }
        MovieNode temp = head;
        while (temp.Next != null) temp = temp.Next;
        temp.Next = node;
        node.Prev = temp;
    }
}
