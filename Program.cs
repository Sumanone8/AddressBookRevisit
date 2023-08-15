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

            // Read contact details from the user
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            Console.Write("Enter State: ");
            string state = Console.ReadLine();

            Console.Write("Enter Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            // Create and add a new contact if input is valid
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(city) &&
                !string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(zip) &&
                !string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(email))
            {
                Contact newContact = new Contact
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    PhoneNumber = phoneNumber,
                    Email = email
                };

                addressBook.AddContact(newContact);

                // Display the added contact
                addressBook.DisplayContacts();
            }
            else
            {
                Console.WriteLine("Invalid input. Contact not added.");
            }

            Console.ReadLine();
        }
    }
}

