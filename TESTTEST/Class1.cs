using System;
using System.Collections.Generic;
using System.Text;

namespace TESTTEST
{
    class Class1
    {
        public string FirstN = "Barak";
        public string LastN = "Putin";
        public string fullN;
        public static string FullName;
        public int AvgScores;


        void Person(string FirstName, string LastName, string FullName, int ScoreAverage)
        {

            FirstName = FirstN;
            LastName = LastN;
            FullName = fullN;
            ScoreAverage = AvgScores;
            FullName = $"{FirstN} {LastN}";

        }
    }
}
