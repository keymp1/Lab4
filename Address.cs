using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Address
    {

        public string Number { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public Address(string number, string street, string city, string state, string zipcode)
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            Zipcode = zipcode;
        }
    }
}
