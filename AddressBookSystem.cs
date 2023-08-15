using System;
using System.Collections.Generic;

namespace MyAddressBook
{
    class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;
        private AddressBook selectedAddressBook;
        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
            selectedAddressBook = null;
        }
        public void AddAddressBook(string name)
        {
            if (!addressBooks.ContainsKey(name))
            {
                addressBooks[name] = new AddressBook();
                Console.WriteLine($"Address Book '{name}' added.");
            }
            else
            {
                Console.WriteLine("Address Book with this name already exists.");
            }
        }

        public bool ContainsAddressBook(string name)
        {
            return addressBooks.ContainsKey(name);
        }
        public void SelectAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                selectedAddressBook = addressBooks[name];
                Console.WriteLine($"Address Book '{name}' selected.");
            }
            else
            {
                Console.WriteLine("Address Book not found.");
            }
        }
        public void ManageAddressBook()
        {
            if (selectedAddressBook != null)
            {
                selectedAddressBook.ManageContacts();
            }
            else
            {
                Console.WriteLine("No Address Book selected.");
            }
        }
        public void DisplayAllContacts()
        {
            foreach (var addressBook in addressBooks.Values)
            {
                addressBook.DisplayContacts();
            }
        }
    }
}
