namespace AddressBookSystem
{
    internal class Program
    {
        public static IList<AddressBook> AddressBooks;

        static Program()
        {
            AddressBooks = new List<AddressBook>();

            // default address book
            AddressBooks.Add(new AddressBook("default"));
        }

        static void Main(string[] args)
        {
            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
