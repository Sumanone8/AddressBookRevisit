using MyAddressBook;
using System;

namespace MyAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");

            AddressBook addressBook = new AddressBook();

            // Create and add a new contact
            Contact newContact = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Main St",
                City = "Sample City",
                State = "Sample State",
                Zip = "12345",
                PhoneNumber = "555-1234",
                Email = "john@example.com"
            };

            addressBook.AddContact(newContact);

            // Display the added contact
            addressBook.DisplayContacts();

            Console.ReadLine();
        }
    }
}
