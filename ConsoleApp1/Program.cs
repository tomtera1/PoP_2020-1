using System;

namespace Lesson_02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task01();
        }

        private static void Task03()
        {
            //Initialization
            string sentence = "Display the pattern like pyramid using the alphabet";

            // Program logic
            string[] words = sentence.Split(" ");
            Stack<string> stack = new Stack<string>();

            foreach (string word in words)
            {
                stack.Push(word);
            }

            //  Output
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + "");
            }

            Console.ReadKey();
        }

        private static void Task02()
        {
            // Initialization and input
            string sentence = "Write a C# Sharp Program to display following pattern using alphabet.";

            // Program logic
            string[] words = sentence.Split(" ");

            string longest = "";
            foreach (string word in words)
            {
                if (longest.Length < CleanWord(word).Length)
                {
                    longest = word;
                }
            }

            //Output
            Console.WriteLine($"The longest word is '{longest}'");

            Console.ReadKey();
        }

        private static string CleanWord(string word)
        {
            return word.Replace(".", "").Replace(",", "");
        }

        private static void Task01()
        {
            // Initialization

            string[] names = { "Ivan", "Peter", "John", "Jane", "Maria" };

            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 22);
            bdays[1] = new DateTime(2001, 01, 22);
            bdays[2] = new DateTime(2002, 01, 22);
            bdays[3] = new DateTime(2003, 01, 22);
            bdays[4] = new DateTime(2004, 01, 22);

            //User Input
            Console.Write("Please enter index (0-4): ");
            int index = int.Parse(Console.ReadLine());

            //Program logic
            string periodOfMonth = GetPeriodOfMonth(bdays, index);
            string monthName = GetNameOfMonth(bdays[index].Month);

            //output
            Console.WriteLine($"{names[index]}'s was born in the {periodOfMonth} in {monthName} ");
        }

        private static string GetPeriodOfMonth(DateTime[] bdays, int index)
        {
            int day = bdays[index].Day;
            string periodOfMonth = "beginning";

            if (day > 10)
            {
                periodOfMonth = "middle";
            }
            if (day > 20)
            {
                periodOfMonth = "end";
            }

            return periodOfMonth;
        }

        private static string GetNameOfMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "Feburary";
            if (month == 3) return "March";
            if (month == 4) return "April";
            if (month == 5) return "May";
            if (month == 6) return "June";
            if (month == 7) return "July";
            if (month == 8) return "August";
            if (month == 9) return "September";
            if (month == 10) return "October";
            if (month == 11) return "November";
            if (month == 12) return "December";

            return "Unknown";
        }
    }
}
