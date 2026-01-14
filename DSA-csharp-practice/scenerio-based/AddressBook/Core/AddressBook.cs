
using System.Collections.Generic;
using System.Linq;
using AddressBook.Models;

namespace AddressBook.Core
{
    public class AddressBook
    {
        public string Name { get; set; }
        private List<ContactPerson> contacts = new List<ContactPerson>();

        public void AddContact(ContactPerson person)
        {
            if (!contacts.Any(c => c.Equals(person)))
                contacts.Add(person);
        }

        public void EditContact(string firstName, ContactPerson updated)
        {
            var person = contacts.FirstOrDefault(c => c.FirstName == firstName);
            if (person != null)
            {
                contacts.Remove(person);
                contacts.Add(updated);
            }
        }

        public void DeleteContact(string firstName)
        {
            contacts.RemoveAll(c => c.FirstName == firstName);
        }

        public List<ContactPerson> GetAll() => contacts;
    }
}
