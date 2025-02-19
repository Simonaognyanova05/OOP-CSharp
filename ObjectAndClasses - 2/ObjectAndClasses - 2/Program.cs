using ObjectAndClasses___2;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Search Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Display All Contacts");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact(contacts);
                    break;
                case "2":
                    SearchContact(contacts);
                    break;
                case "3":
                    DeleteContact(contacts);
                    break;
                case "4":
                    DisplayAllContacts(contacts);
                    break;
                case "5":
                    isRunning = false;
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddContact(List<Contact> contacts)
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber, Email = email });
        Console.WriteLine("Contact added successfully.");
    }

    static void SearchContact(List<Contact> contacts)
    {
        Console.Write("Enter Name or Phone Number to search: ");
        string query = Console.ReadLine();

        var results = contacts.FindAll(contact =>
            contact.Name.Contains(query) ||
            contact.PhoneNumber.Contains(query));

        if (results.Count > 0)
        {
            Console.WriteLine("Search results:");
            foreach (var contact in results)
            {
                Console.WriteLine(contact);
            }
        }
        else
        {
            Console.WriteLine("No contacts found.");
        }
    }

    static void DeleteContact(List<Contact> contacts)
    {
        Console.Write("Enter Phone Number to delete: ");
        string phoneNumber = Console.ReadLine();

        var contactToRemove = contacts.Find(contact => contact.PhoneNumber == phoneNumber);

        if (contactToRemove != null)
        {
            contacts.Remove(contactToRemove);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void DisplayAllContacts(List<Contact> contacts)
    {
        if (contacts.Count > 0)
        {
            Console.WriteLine("All contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
        else
        {
            Console.WriteLine("No contacts available.");
        }
    }
}
