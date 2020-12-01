using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 namespace Assignment1
{
    internal class Student : Person
    {
        static Student(string FirstN, string LastN, string StNumber, int Age, string fullName);
        public string StNumber = "20160001";
        public int Age = 33;
        string fullName = $"{FirstN} {LastN}";
        public Student (string FirstN, string lastN, string stNumber, int age, string fullName): base (FirstN, LastN);
        
      


        public string Address1 => $"{address} {Street}";
    }
}
