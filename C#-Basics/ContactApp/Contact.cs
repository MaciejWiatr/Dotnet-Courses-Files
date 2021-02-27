using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ContactApp
{
    class Contact
    {
        public string Name {get;set;}
        public int Number {get;set;}

        public Contact(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public void SayHi()
        {
            Console.WriteLine($"Cześć, mam na imię {Name} a mój numer to {Number}");
        }
    }

    class ContactService
    {
        private static List<Contact> contacts = new List<Contact>();
        
        public static void PrintContacts(List<Contact> contactList)
        {
            foreach(Contact c in contactList)
            {
                c.SayHi();
            }
        } 
        public static void Add(string name, int number)
        {
            contacts.Add(new Contact(name,number));
        }
        public static Contact GetByNumber(int number)
        {
            return contacts.FirstOrDefault(c=>c.Number == number);
        }
        public static List<Contact> GetByName(string name)
        {
            return contacts.Where(c=>c.Name == name).ToList();
        }
        public static List<Contact> GetAll()
        {
            return contacts;
        }
        public static void PrintAll()
        {
            PrintContacts(contacts);
        }
    }
}
