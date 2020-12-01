using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_POP_2020
{
    internal class Student : Person
    {
        public string studentNumber;
        public int age;
        public Address address;
        public int[] scores;
        public Student(string firstName, string lastName, string studentNumber, int age, Address address, int[] scores) : base(firstName, lastName)
        {
            StudentNumber = studentNumber;
            Age = age;
            Address = address;
            Scores = scores;
        }
        public string StudentNumber
        {
            get => studentNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Student number can't be empty!");
                }
                if (value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Student number can't be longer than 10 symbols!");
                }

                studentNumber = value;
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value > 100 || value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 1 and 100!");
                }
                age = value;
            }
        }
        public int[] Scores
        {
            get => scores;
            set
            {
                if (value.Length > 10 || value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Amount of scores must be between 1 and 10!");
                }
                foreach (var v in value)
                {
                    if (v > 100 || v < 0)
                    {
                        throw new ArgumentOutOfRangeException("Score must be between 0 and 100!");
                    }
                }
                scores = value;
            }
        }
        public string AllScores(int[] scores)
        {
            StringBuilder allscores = new StringBuilder();
            foreach (var s in scores)
            {
                allscores.Append(s + " ");
            }
            return allscores.ToString();
        }
        public string FullName(string firstName, string lastName)
        {
            StringBuilder fullName = new StringBuilder();
            var p = new Person(firstName, lastName);
            fullName.Append(p.FirstName + " " + p.LastName);
            return fullName.ToString();
        }
        public Address Address
        {
            get => address;
            set
            {
                address = value;
            }
        }
        public string FullAddress(Address address)
        {
            return address.ToString();
        }
        public double AverageScore(int[] scores)
        {
            int sum = 0;
            int amount = scores.Length;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            double average = sum / amount;
            return average;
        }

        public override string ToString()
        {
            return $"Student {FullName(firstName, lastName)} \nStudent Number: {studentNumber} \nAge: {age} \nScores:{AllScores(scores)} \tAverage score: {AverageScore(scores)}\nStudent address: {FullAddress(address)}";
        }

    }
}
