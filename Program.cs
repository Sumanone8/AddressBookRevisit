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

            // Use a loop to add multiple contacts
            while (true)
            {
                Console.WriteLine("Add a New Contact:");

                Contact newContact = new Contact();

                Console.Write("Enter First Name: ");
                newContact.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                newContact.LastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                newContact.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                newContact.City = Console.ReadLine();

                Console.Write("Enter State: ");
                newContact.State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                newContact.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                newContact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                newContact.Email = Console.ReadLine();

                addressBook.AddContact(newContact);

                Console.Write("Do you want to add another contact? (y/n): ");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() != "y")
                {
                    break;
                }
            }

            // Display all contacts
            addressBook.DisplayContacts();

            Console.ReadLine();
        }


    }
}
