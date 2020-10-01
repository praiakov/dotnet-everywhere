using BasicContactsCRUD.Models;
using BasicContactsCRUD.Setup;
using System;
using System.Linq;

namespace BasicContactsCRUD.Repository
{
    public static class ContactRepository
    {
        public static void CreateContact()
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Email: ");
            var email = Console.ReadLine();

            var contact = new Contact
            {
                Name = name,
                Email = email
            };

            session.Store(contact);

            Console.WriteLine($"New Contact ID {contact.Id}");

            session.SaveChanges();
        }

        public static void RetrieveContact()
        {
            Console.WriteLine("Enter the contact id: ");
            var id = Console.ReadLine();

            using var session = DocumentStoreHolder.Store.OpenSession();
            var contact = session.Load<Contact>(id);

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Email: {contact.Email}");
        }

        public static void UpdateContact()
        {
            Console.WriteLine("Enter the contact id: ");
            var id = Console.ReadLine();

            using var session = DocumentStoreHolder.Store.OpenSession();
            var contact = session.Load<Contact>(id);

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.WriteLine($"Actual name: {contact.Name}");
            Console.WriteLine("New name: ");
            contact.Name = Console.ReadLine();

            Console.WriteLine($"Actual email: {contact.Email}");
            Console.WriteLine("New email address: ");
            contact.Email = Console.ReadLine();

            session.SaveChanges();
        }

        public static void DeleteContact()
        {
            Console.WriteLine("Enter the contact id: ");
            var id = Console.ReadLine();

            using var session = DocumentStoreHolder.Store.OpenSession();
            var contact = session.Load<Contact>(id);

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            session.Delete(contact);
            session.SaveChanges();
        }

        public static void QueryAllContacts()
        {
            using var session = DocumentStoreHolder.Store.OpenSession();
            var contacts = session.Query<Contact>().ToList();

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id} - {contact.Name} - {contact.Email}");
            }

            Console.WriteLine($"{contacts.Count} contacts found.");
        }
    }
}
