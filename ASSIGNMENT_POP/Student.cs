using System;
using System.Collections.Generic;
using System.Text;

namespace ASSIGNMENT_POP
{
    internal class Student : Person
    {
        public static string StudentNo = "1967001";
        public static string Address;
        public static int Age;
        public static int[] Scores = new int[4] { 60, 100, 66, 75 };

        public static double AverageScore(int[] Scores)
        {
            int sum = 0;
            int HowMany = Scores.Length;
            for (int i = 0; i < Scores.Length; i++)
            {
                sum += Scores[i];
            }
            double averageScore = sum / HowMany;
            return averageScore;
        }
        public static double Average = AverageScore(Scores);

        public Student(string FirstName, string LastName, string StudentNumber, string address, int age, int[] Scores, int AverageScore) : base(FirstName, LastName, FullName, fullAddress)
        {
            StudentNumber = StudentNo;
            Address = address;
            Age = age;
            StudentNumber = StudentNo;
           
        }

    }
}
