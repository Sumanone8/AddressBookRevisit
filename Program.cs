using MyAddressBook;
using System;
using System.Collections.Generic;

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
            // addressBook.DisplayContacts();

            // Edit contact's name using the console
            Console.Write("Enter First Name of Contact to Edit: ");
            string editFirstName = Console.ReadLine();

            Console.Write("Enter Last Name of Contact to Edit: ");
            string editLastName = Console.ReadLine();

            addressBook.EditContactName(editFirstName, editLastName);

            // Display the edited contact
            addressBook.DisplayEditedContact(editFirstName, editLastName);

            Console.ReadLine();
        }


    }
}

