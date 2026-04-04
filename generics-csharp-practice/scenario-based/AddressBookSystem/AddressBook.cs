namespace AddressBookSystem
{
    internal class AddressBook
    {
        private readonly IList<Contact> Contacts;
        private string AddressBookName;

        public AddressBook(string addressBookName)
        {
            AddressBookName = addressBookName;
            Contacts = new List<Contact>();
        }

        public IList<Contact> GetContacts()
        {
            return Contacts;
        }

        public string GetAddressBookName()
        {
            return AddressBookName;
        }

        public void SetAddressBookName(string name)
        {
            AddressBookName = name;
        }

        public override string ToString()
        {
            return $"Total Contacts : {Contacts.Count}";
        }
    }
}
