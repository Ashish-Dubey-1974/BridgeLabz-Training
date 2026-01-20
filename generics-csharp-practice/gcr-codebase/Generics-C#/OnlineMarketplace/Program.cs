
class Program
{
    static void Main()
    {
        Book book = new Book { Price = 500 };
        Discount.ApplyDiscount(book, 10);
    }
}
