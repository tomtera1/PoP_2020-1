using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT_POP
{
    public class Address
    {
        public static string address;
        public static string street;
        public static string city;
        public static string country;

        public Address(string Address, string Street, string City, string Country)
        {
            address = Address;
            street = Street;
            city = City;
            country = Country;
        }
    }
}
