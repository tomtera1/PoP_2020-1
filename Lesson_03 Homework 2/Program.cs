using System;
using Microsoft.VisualBasic;

namespace Lesson_03_Homework_2
{
    class Program
    {
private static void Main(string[] args)
        {
            Task4_Future();
        }
        private static void Task4_Future()
        {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("STUDENT FORM VALIDATION");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                // NAMES
                Console.Write("Please, enter your First Name: ");
                string name = Console.ReadLine();

                Console.Write("\nPlease, enter your Last Name: ");
                string lname = Console.ReadLine();

                //BIRTH DATE
                Console.Write("Please, enter your date of birth: ");
                long DOB = long.Parse(Console.ReadLine());

                //STUDENT ID    
                Console.Write("Enter your Student ID (YYYYFFSSNNNN): ");
                long stid = long.Parse(Console.ReadLine());

            //write
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Student Full Name: {FirstName(name)} {LastName(lname)}");
            Console.WriteLine($"DOB: {DateOfBirth(DOB)}");
            Console.WriteLine($"Student ID: {StudentNumber(stid)}");
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();

            static string FirstName(string name)
            {

                if (name.Length <= 100 || name.Length >= 1)
                {
                    return name;
                }
                else
                {
                    return "Error, Please, check Length (limit 100 char.)";
                }
            }
            static string LastName(string lname)
            {

                if (lname.Length <= 100 || lname.Length >= 1)
                {
                    return lname;
                }
                else
                {
                    return "Error, Please, check Length (limit 100 char.)";
                }
            }
            static string DateOfBirth(long DOB)
            {
                DateTime d = DateTime.Now;
                long a = (int.Parse(d.ToString("yyy")) - DOB);
                if (a<=100&&a>0)
                {
                    return Convert.ToString(DOB);
                }
                else
                {
                    return "Check your DOB (Limit 100 y.o.)";
                }
            }
            static string StudentNumber(long stid)
            {
                long a = (stid / 1000000) % 10;
                long b = (stid / 10000) % 10;
                if (a >= 1 && a < -9 && b >= 1 && b <= 5)
                {
                    return Convert.ToString(stid);
                }
                else
                {
                    return "Check your student id";

                }
            }



                }







            }
        }

