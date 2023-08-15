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

            // Add contacts using the code
            Contact contact1 = new Contact
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
            addressBook.AddContact(contact1);

            Contact contact2 = new Contact
            {
                FirstName = "Jane",
                LastName = "Smith",
                Address = "456 Elm St",
                City = "Another City",
                State = "Another State",
                Zip = "54321",
                PhoneNumber = "555-5678",
                Email = "jane@example.com"
            };
            addressBook.AddContact(contact2);

            // Display initial contacts
            addressBook.DisplayContacts();

            // Delete a contact using the console
            Console.Write("Enter First Name of Contact to Delete: ");
            string deleteFirstName = Console.ReadLine();

            Console.Write("Enter Last Name of Contact to Delete: ");
            string deleteLastName = Console.ReadLine();

            addressBook.DeleteContact(deleteFirstName, deleteLastName);

            // Display updated contacts after deletion
            addressBook.DisplayContacts();

            Console.ReadLine();
        }

    }
}
