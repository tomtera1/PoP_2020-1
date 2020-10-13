using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Lesson_2__Homework_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            NameDisp();
        }


        private static void NameDisp()
        {
            Console.WriteLine("Hey\nTommy");
            Console.ReadKey();
            


        }


        private static void SumOfTwo()
        {
            Console.WriteLine("SUM OF TWO NUMBERS");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write($"The Sum of Your Two Numbers is {c}");
            Console.ReadKey();

        }

        private static void ResultOfOperations()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("THE RESULTS OF GIVEN OPERATIONS ARE:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            int a = -1 + 4 * 6;
            Console.WriteLine($"-1 + 4 * 6 = {a}");

            int b = (35 + 5) % 7;
            Console.WriteLine($"(35 + 5) % 7 = {b}");

            int c = 14 + -4 * 6 / 11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {c}");

            int d = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {d}");

            Console.ReadKey();
        }

        private static void ThreeNumMult()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("THREE NUMBERS MULTIPLICATION");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Enter the First Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the Third Number: ");
            int c = int.Parse(Console.ReadLine());

            int d = a * b * c;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write($"THE RESULT IS: {d}");

            Console.ReadKey();

        }

        private static void MultTable()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("MULTIPLICATION TABLE OF A NUMBER");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Please, Enter the Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------");
            Console.WriteLine($" {a} * 1 = {a * 1}");
            Console.WriteLine($" {a} * 2 = {a * 2}");
            Console.WriteLine($" {a} * 3 = {a * 3}");
            Console.WriteLine($" {a} * 4 = {a * 4}");
            Console.WriteLine($" {a} * 5 = {a * 5}");
            Console.WriteLine($" {a} * 6 = {a * 6}");
            Console.WriteLine($" {a} * 7 = {a * 7}");
            Console.WriteLine($" {a} * 8 = {a * 8}");
            Console.WriteLine($" {a} * 9 = {a * 9}");
            Console.WriteLine($" {a} * 10 = {a * 10}");
            Console.WriteLine("-------------");
            Console.ReadKey();
        }

        private static void Average()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("AVERAGE OF FOUR NUMBERS");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Enter The First Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter The Second Number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter The Third Number: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter The Fourth Number: ");
            int d = int.Parse(Console.ReadLine());

            int e = (a + b + c + d) / 4;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"AVERAGE OF GIVEN NUMBERS IS: {e}");

            Console.ReadKey();
        }

        private static void Range100200()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("CHECK IF THE NUMBER IS WITHIN RANGE OF 100-200");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Please, enter your number: ");
            int a = int.Parse(Console.ReadLine());


            Console.WriteLine("-------------------------------");
            if (a >= 100 && a <= 200)
                    Console.WriteLine("TRUE. THE GIVEN NUMBER IS IN RANGE.");

                else Console.WriteLine("FALSE. THE GIVEN NUMBER IS NOT IN RANGE");


            Console.ReadKey();
        }

        private static void DateNow()

        {
            string DDDA = "dd MMM yyyy";
            var CurrentYear = DateTime.Now.ToString(DDDA);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"CURRENT DATE IS: {CurrentYear}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ReadKey();

        }

        private static void YearOfBirth()

        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("YEAR OF BIRTH FINDER");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Please, enter your age: ");
            int a = int.Parse(Console.ReadLine());

            string YEAR = "yyyy";
            var CURYEAR = DateTime.Now.ToString(YEAR);
            int x = int.Parse(CURYEAR);

            int z = x - a;

            Console.WriteLine("----------------------------");
            Console.WriteLine($"YOUR YEAR OF BIRTH IS {z}");

            Console.ReadKey();
        }

        private static void ThreeNumbersTwoForm()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("THREE NUMBERS INTO TWO FORMULAS");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("Enter First Number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            int z = int.Parse(Console.ReadLine());


            Console.WriteLine("-----------------------------");
            Console.WriteLine($"FORMULA (x+y)*z = {(x + y) * z}");
            Console.WriteLine($"FORMULA x*y + y*z = {x * y + y * z}");

            Console.ReadKey();
        }
  
    }
}
