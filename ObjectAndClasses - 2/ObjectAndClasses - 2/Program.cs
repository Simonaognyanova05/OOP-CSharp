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
                    Add(contacts);
                    break;
                case "2":
                    SearchContact(contacts);
                    break;
                case "3":
                    DeleteContact(contacts);
                    break;
                case "4":
                    //DisplayAllContacts(contacts);
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

    static void Add(List<Contact> contacts)
    {
        string name = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string email = Console.ReadLine();  

        contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber, Email = email });
        Console.WriteLine("Contact was added successfully!");
    }
    
    static void SearchContact(List<Contact> contacts)
    {
        string searched = Console.ReadLine();

        var result = contacts.FindAll(x => x.Name.Contains(searched) || x.PhoneNumber.Contains(searched)
        || x.Email.Contains(searched));

        if(result.Count > 0)
        {
            foreach(var contact in result)
            {
                Console.WriteLine(contact);
            }
        }
        else
        {
            Console.WriteLine("This contact not exists!");
        }
    }

    static void DeleteContact(List<Contact> contacts)
    {
        string forDelete = Console.ReadLine();
        var result = contacts.Find(x =>  x.PhoneNumber.Contains(forDelete));

        if(result != null)
        {
            contacts.Remove(result);
            Console.WriteLine("Contact was deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not exists!");
        }
    }
}
