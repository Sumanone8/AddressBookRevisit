using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAddressBook
{
    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void EditContactName(string firstName, string lastName)
        {
            Contact existingContact = contacts.Find(contact =>
                contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (existingContact != null)
            {
                Console.WriteLine("Editing contact name:");
                Console.WriteLine($"Current Name: {existingContact.FirstName} {existingContact.LastName}");

                // Update contact's first name using console input
                Console.Write("Enter Updated First Name: ");
                existingContact.FirstName = Console.ReadLine();

                // Update contact's last name using console input
                Console.Write("Enter Updated Last Name: ");
                existingContact.LastName = Console.ReadLine();

                Console.WriteLine("Contact name updated.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DisplayEditedContact(string firstName, string lastName)
        {
            Contact editedContact = contacts.Find(contact =>
                contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (editedContact != null)
            {
                Console.WriteLine("Edited Contact:");
                Console.WriteLine($"Name: {editedContact.FirstName} {editedContact.LastName}");
                Console.WriteLine($"Address: {editedContact.Address}");
                Console.WriteLine($"City: {editedContact.City}");
                Console.WriteLine($"State: {editedContact.State}");
                Console.WriteLine($"Zip: {editedContact.Zip}");
                Console.WriteLine($"Phone Number: {editedContact.PhoneNumber}");
                Console.WriteLine($"Email: {editedContact.Email}");
            }
            else
            {
                Console.WriteLine("Edited contact not found.");
            }
        }

    }
}
