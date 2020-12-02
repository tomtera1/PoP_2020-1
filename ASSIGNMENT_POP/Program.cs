using System;


namespace ASSIGNMENT_POP
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDisplayInfo();
        }
        private static void PersonDisplayInfo()
        {
            //getting the name
            Console.Write("Enter the Name of the student: ");
            Person.FirstN = Console.ReadLine();
            Console.Write("Enter the Last Name of the student: ");
            Person.LastN = Console.ReadLine();
            Console.Write("Enter the Building number where the guy lives: ");
            Address.address = Console.ReadLine();
            Console.Write("Enter the Street where the guy lives: ");
            Address.street = Console.ReadLine();
            Console.Write("Enter the City where the guy lives: ");
            Address.city = Console.ReadLine();
            Console.Write("Enter the country where the guy lives: ");
            Address.country = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Great! We'll get the rest of information" );
            Console.WriteLine("From FBI, so You can stop getting older sitting here");
            Console.WriteLine("and entering everything. I know, i'm sweet. Don't mention it:3");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("LET'S DISPLAY EVERYTHING NOW");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Press any key to continue one more time: ");
            Console.ReadKey();
            Console.Clear();



            Person.FullName = $"{Person.FirstN} {Person.LastN}";
            Person.fullAddress = $"{Address.address}, {Address.street}, {Address.city}, {Address.country}";
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("FULL INFORMATION OF GIVEN STUDENT");
            Console.WriteLine("=======================================================");
            Console.WriteLine($"Student {Person.FullName} average score is {Student.Average}");
            Console.WriteLine($"Student {Person.FullName} lives in {Student.city} ");
            Console.WriteLine($"Student {Person.FullName} address is {Person.fullAddress} ");

            Console.ReadKey();
        }
    }
}
