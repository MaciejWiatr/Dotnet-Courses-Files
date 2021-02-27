using System;
using FirstProject.Enums;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject
{
    class Program
    {
        static void DisplayList(List<Person> list)
        {
            Console.WriteLine("~List~");
            foreach(Person per in list){
                per.SayHi();
            };
        }
        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person( "Maciej", "Wicher", new DateTime(1999,2,2)),
                new Person( "Maciej", "Winder", new DateTime(1905,2,2)),
                new Person( "Maciej", "Winda", new DateTime(2001,2,2)),
                new Person( "Maciej", "Wuchar", new DateTime(2000,2,2)),
                new Person( "Maciej", "Puchar", new DateTime(2005,2,2)),
                new Person( "Bob", "Kuchar", new DateTime(2003,2,2)),
            };
            return employees;
        }
        static void Main(string[] args)
        {
            List<Person> employees = GetEmployees();
            List<Person> youngEmployees = employees.Where(e => e.DateOfBirth > new DateTime(2000,1,1)).ToList();
            Person bob = youngEmployees.FirstOrDefault(e => e.FirstName == "Bob");
            DisplayList(youngEmployees);
            Console.WriteLine(bob);
        }
    }

}
