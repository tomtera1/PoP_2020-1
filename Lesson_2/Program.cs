using System;
using System.Drawing;
using System.Transactions;

namespace Lesson_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task4_Future();
        }

        private static void MeAfterTen()
        {
            Console.Write("How old are you? ");
            string ageAsString = Console.ReadLine();

            try
            {
                int ageAsInt = int.Parse(ageAsString);

                int ageAfterTen = ageAsInt + 10;

                Console.WriteLine($"In ten years you will be {ageAfterTen} years old.");
            }
            catch
            {
                Console.WriteLine($"Error!");
            }
            Console.ReadKey();
        }

        private static void SimpleFormulasTask_2()
        {
            Console.WriteLine("RECTANGLE");
            Console.WriteLine("_____________________________");

            Console.Write("Please, enter side A: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Please, enter side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine("Area =" + sideA * sideB);

            Console.WriteLine("Perimeter = " + 2 * (sideA + sideB));

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("TRIANGLE");
            Console.WriteLine("_____________________________");

            Console.Write("Please, enter side A: ");
            sideA = int.Parse(Console.ReadLine());

            Console.Write("Please, enter side B: ");
            sideB = int.Parse(Console.ReadLine());

            Console.Write("Please, enter side C: ");
            int sideC = int.Parse(Console.ReadLine());

            Console.Write("Please, enter height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Area= " + (sideA * height) / 2.0);

            Console.WriteLine("Perimeter= " + (sideA + sideB + sideC));

            Console.ReadKey();
        }

        private static void Task_3_Dates()
        {
            DateTime date = DateTime.Now;

            Console.Write("Current date: ");
            Console.WriteLine(date.ToShortDateString());

            Console.Write("Current time: ");
            Console.WriteLine(date.ToShortTimeString());

            Console.Write("Please enter a period: ");
            int period = int.Parse(Console.ReadLine());
            Console.Write($"Date after {period} years: ");
            Console.WriteLine(date.AddYears(period).ToShortDateString());
            Console.ReadKey();
        }

        private static void Task4_Future()
        {
            Console.Write("Enter Your Current age: ");
            int currage = int.Parse(Console.ReadLine());

            Console.Write("Enter The Future Age: ");
            int futage = int.Parse(Console.ReadLine());

            Console.Write("What's Your Day of Birth? ");
            int bday = int.Parse(Console.ReadLine());

            Console.Write("What's Your Month of Birth? ");
            int bmonth = int.Parse(Console.ReadLine());
            Console.WriteLine("~~~~~~~~~~~~~~");
            int agediff = (futage - currage);

            string format = "yyyy";
            var CurrentYear = DateTime.Now.ToString(format);
            int CurYear = int.Parse(CurrentYear);

            int agecalc = (CurYear + agediff);
            
            Console.Write($"You Will Be Celebrating your {futage} in {bday}th of {bmonth}, {agecalc}.");

            Console.ReadKey();


        }
    }
}
