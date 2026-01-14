
using System;

namespace AddressBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBookSystem system = new AddressBookSystem();
            system.Start();
        }
    }
}
