using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAddressBook
{
    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public bool AddContact(Contact contact)
        {
            if (contacts.Any(c => c.Equals(contact)))
            {
                Console.WriteLine("Contact with the same name already exists.");
                return false;
            }

            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
            return true;
        }

        public void DisplayContacts()
        {
            Console.WriteLine("Contacts in Address Book:");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Zip: {contact.Zip}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine();
            }
        }

        public void ManageContacts()
        {
            while (true)
            {
                Console.WriteLine("Manage Contacts:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Search Contact");
                Console.WriteLine("5. Back to Main Menu");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Adding a New Contact:");

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

                        AddContact(newContact);

                        break;

                    case 2:
                        EditContact();
                        break;
                    case 3:
                        DeleteContact();
                        break;
                    case 4:
                        SearchContact();
                        break;
                    case 5:
                        Console.WriteLine("Returning to main menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void EditContact()
        {
            Console.Write("Enter the first name of the contact to edit: ");
            string firstName = Console.ReadLine();

            Contact contactToEdit = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contactToEdit != null)
            {
                Console.WriteLine("Enter updated details:");

                Console.Write("Enter Address: ");
                contactToEdit.Address = Console.ReadLine();

                Console.Write("Enter City: ");
                contactToEdit.City = Console.ReadLine();

                Console.Write("Enter State: ");
                contactToEdit.State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                contactToEdit.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                contactToEdit.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                contactToEdit.Email = Console.ReadLine();

                Console.WriteLine("Contact details updated.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        private void DeleteContact()
        {
            Console.Write("Enter the first name of the contact to delete: ");
            string firstName = Console.ReadLine();

            Contact contactToDelete = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        private void SearchContact()
        {
            Console.Write("Enter the first name of the contact to search for: ");
            string firstName = Console.ReadLine();

            Contact contact = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                Console.WriteLine($"Contact found:");
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Address: {contact.Address}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine($"Zip: {contact.Zip}");
                Console.WriteLine($"Phone Number: {contact.PhoneNumber}");
                Console.WriteLine($"Email: {contact.Email}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}