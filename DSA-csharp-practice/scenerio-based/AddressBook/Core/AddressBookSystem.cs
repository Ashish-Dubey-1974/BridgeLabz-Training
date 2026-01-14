
using System;
using System.Collections.Generic;
using AddressBook.Core;
using AddressBook.Models;

namespace AddressBook
{
    public class AddressBookSystem
    {
        private Dictionary<string, AddressBook.Core.AddressBook> books =
            new Dictionary<string, AddressBook.Core.AddressBook>();

        public void Start()
        {
            Console.WriteLine("Creating Default Address Book...");
            books["Default"] = new AddressBook.Core.AddressBook { Name = "Default" };

            ContactPerson person = new ContactPerson
            {
                FirstName = "John",
                LastName = "Doe",
                City = "Delhi",
                State = "Delhi",
                Zip = "110001",
                PhoneNumber = "9999999999",
                Email = "john@example.com"
            };

            books["Default"].AddContact(person);

            Console.WriteLine("Contact Added Successfully!");
            foreach (var p in books["Default"].GetAll())
                Console.WriteLine(p);
        }
    }
}
