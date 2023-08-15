using AddressBookRevisit;
using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");

            List<Contact> contacts = new List<Contact>();

            // Create a new contact
            Contact newContact = new Contact
            {
                FirstName = "Suman",
                LastName = "jha",
                Address = "123-xyz",
                City = "bhliwara",
                State = "Rjasthan",
                Zip = "311001",
                PhoneNumber = "0123456789",
                Email = "suman@email.com",
            };

            // Add the new contact to the list
            contacts.Add(newContact);

            // Display the added contact
            Console.WriteLine("\nContact added:");
            Console.WriteLine($"Name: {newContact.FirstName} {newContact.LastName}");
            Console.WriteLine($"Address: {newContact.Address}");
            Console.WriteLine($"City: {newContact.City}");
            Console.WriteLine($"State: {newContact.State}");
            Console.WriteLine($"Zip: {newContact.Zip}");
            Console.WriteLine($"Phone Number: {newContact.PhoneNumber}");
            Console.WriteLine($"Email: {newContact.Email}");

            Console.ReadLine();
        }
    }
}
