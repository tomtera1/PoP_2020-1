using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_POP_2020
{
    class Address
    {
        public string city;
        public string country;
        public string nameofstreet;
        public string housenumber;
        public Address(string nameofstreet, string housenumber, string city, string country)
        {
            Nameofstreet = nameofstreet;
            Housenumber = housenumber;
            City = city;
            Country = country;
        }
        public string Nameofstreet
        {
            get => nameofstreet;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Street name can't be empty!");
                }
                if (value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Street name can't be longer than 30 symbols!");
                }

                nameofstreet = value;
            }
        }
        public string Housenumber
        {
            get => housenumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("House number can't be empty!");
                }
                if (value.Length > 5)
                {
                    throw new ArgumentOutOfRangeException("House number can't be longer than 5 symbols!");
                }
                housenumber = value;
            }
        }
        public string Street(string nameofstreet, string numberofstreet)
        {
            string fullstreet = $"{nameofstreet} Street {numberofstreet}";
            return fullstreet;
        }
        public string City
        {
            get => city;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("City can't be empty!");
                }
                else if (value.Length > 30)
                {
                    throw new FormatException("City name can't be longer than 30 symbols!");
                }
                city = value;
            }
        }
        public string Country
        {
            get => country;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Country can't be empty!");
                }
                else if (value.Length > 30)
                {
                    throw new FormatException("Country name can't be longer than 30 symbols!");
                }
                country = value;
            }
        }
        public override string ToString()
        {
            return $"{Street(nameofstreet, housenumber)}, {city}, {country}";
        }

    }
}
