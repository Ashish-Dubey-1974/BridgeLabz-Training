namespace AddressBookSystem
{
    internal class AddressBookUtility : IAddressBook
    {
        private IList<AddressBook> AddressBooks;

        public AddressBookUtility()
        {
            AddressBooks = Program.AddressBooks;
        }

        public void AddContact()
        {
            Console.Write("Enter address book name (press enter for default): ");
            string bookName = Console.ReadLine();

            if (string.IsNullOrEmpty(bookName))
                bookName = "default";

            AddressBook addressBook = FindAddressBookByName(bookName);

            if (addressBook == null)
            {
                Console.WriteLine("Address book not found.");
                return;
            }

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            if (IsDuplicate(firstName, addressBook))
            {
                Console.WriteLine("Duplicate contact found.");
                return;
            }

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip: ");
            string zip = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            addressBook.GetContacts().Add(
                new Contact(firstName, lastName, city, state, zip, phone, email)
            );

            Console.WriteLine("Contact added successfully.");
        }

        private AddressBook FindAddressBookByName(string name)
        {
            foreach (var book in AddressBooks)
            {
                if (book.GetAddressBookName().Equals(name))
                    return book;
            }
            return null;
        }

        private bool IsDuplicate(string firstName, AddressBook book)
        {
            foreach (var c in book.GetContacts())
            {
                if (c.GetFirstName().Equals(firstName))
                    return true;
            }
            return false;
        }

        public void DisplayAllContacts()
        {
            foreach (var book in AddressBooks)
            {
                Console.WriteLine($"\nAddress Book: {book.GetAddressBookName()}");

                foreach (var contact in book.GetContacts())
                {
                    Console.WriteLine(contact);
                }
            }
        }

        public void DeleteContact()
        {
            Console.Write("Enter first name to delete: ");
            string name = Console.ReadLine();

            foreach (var book in AddressBooks)
            {
                var contact = book.GetContacts()
                                  .FirstOrDefault(c => c.GetFirstName() == name);

                if (contact != null)
                {
                    book.GetContacts().Remove(contact);
                    Console.WriteLine("Contact deleted.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void EditExistingContact()
        {
            Console.Write("Enter first name to edit: ");
            string name = Console.ReadLine();

            foreach (var book in AddressBooks)
            {
                foreach (var c in book.GetContacts())
                {
                    if (c.GetFirstName().Equals(name))
                    {
                        Console.Write("New City: ");
                        c.SetCity(Console.ReadLine());
                        Console.WriteLine("Contact updated.");
                        return;
                    }
                }
            }

            Console.WriteLine("Contact not found.");
        }

        public void CreateAddressBook()
        {
            Console.Write("Enter new address book name: ");
            string name = Console.ReadLine();

            AddressBooks.Add(new AddressBook(name));
            Console.WriteLine("Address book created.");
        }

        public void ListAllAddressBooks()
        {
            foreach (var book in AddressBooks)
            {
                Console.WriteLine(book.GetAddressBookName());
            }
        }

        public void AddMultipleContacts()
        {
            Console.WriteLine("Use Add Contact multiple times.");
        }

        public void ListAllContactsInCityOrState() { }
        public void SearchContactInCityOrState() { }
        public void CountContactsByCityOrState() { }

        public void SortContactsAlphabeticallyByFirstName()
        {
            foreach (var book in AddressBooks)
            {
                var sorted = book.GetContacts()
                                 .OrderBy(c => c.GetFirstName())
                                 .ToList();

                book.GetContacts().Clear();
                foreach (var c in sorted)
                    book.GetContacts().Add(c);
            }

            Console.WriteLine("Contacts sorted.");
        }
    }
}
