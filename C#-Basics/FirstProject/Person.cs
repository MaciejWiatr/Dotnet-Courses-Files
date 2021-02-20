using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Person
    {
        public string FirstName;
        public string LastName;
        private DateTime dateOfBirth;
        private string contactNumber;
        public static int Count = 0;

        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }
            set
            {
                if(value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number");
                }
                else
                {
                    contactNumber = value;
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    Console.WriteLine("Invalid date of birth");
                }
                else
                {
                    dateOfBirth = value;
                }
            }
        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
            Count +=1;
        }
        public Person(string firstname, string lastname, DateTime dateOfBirth):this(firstname,lastname)
        {
            DateOfBirth = dateOfBirth;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hello im {FirstName}, {DateOfBirth}");
        }
    }
}
