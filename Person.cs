using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }

        public Phone Phone { get; set; }

        public Person (string firstName, string lastName, Address address, Phone phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            return (FirstName + "|" +
                    LastName + "|" +
                    Address + "|" +
                    Phone);
        }








    }
}
