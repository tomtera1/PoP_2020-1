using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_POP_2020
{
    internal class Person
    {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name can't be empty!");
                }
                else if (value.Length > 30)
                {
                    throw new FormatException("Last name can't be longer than 30 symbols!");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name can't be empty!");
                }
                else if (value.Length > 30)
                {
                    throw new FormatException("Last name can't be longer than 30 symbols!");
                }
                lastName = value;
            }
        }

    }
}
