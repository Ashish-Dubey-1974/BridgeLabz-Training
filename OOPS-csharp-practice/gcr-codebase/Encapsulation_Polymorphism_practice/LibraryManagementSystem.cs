
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

abstract class LibraryItem
{
    private int itemId;
    protected string title;
    protected string author;

    protected LibraryItem(int id, string title, string author)
    {
        itemId = id;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();
}

class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author) : base(id, title, author) { }
    public override int GetLoanDuration() => 14;
    public void ReserveItem() { }
    public bool CheckAvailability() => true;
}

class Magazine : LibraryItem
{
    public Magazine(int id, string title, string author) : base(id, title, author) { }
    public override int GetLoanDuration() => 7;
}

class DVD : LibraryItem
{
    public DVD(int id, string title, string author) : base(id, title, author) { }
    public override int GetLoanDuration() => 3;
}
