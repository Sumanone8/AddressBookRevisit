using System;

namespace MyAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program!");

            AddressBookSystem addressBookSystem = new AddressBookSystem();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add New Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a unique Name for the Address Book: ");
                        string addressBookName = Console.ReadLine();
                        addressBookSystem.AddAddressBook(addressBookName);
                        break;
                    case 2:
                        Console.Write("Enter the Name of the Address Book: ");
                        string selectedAddressBook = Console.ReadLine();
                        if (addressBookSystem.ContainsAddressBook(selectedAddressBook))
                        {
                            addressBookSystem.SelectAddressBook(selectedAddressBook);
                            addressBookSystem.ManageAddressBook();

                        }
                        else
                        {
                            Console.WriteLine("Address Book not found.");
                        }
                        break;
                    case 3:
                        addressBookSystem.DisplayAllContacts();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
