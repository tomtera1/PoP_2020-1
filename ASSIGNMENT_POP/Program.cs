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
            Person.FullName = $"{Person.FirstN} {Person.LastN}";
            Person.fullAddress = $"{Address.address}, {Address.street}, {Address.city}, {Address.country}";
            
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
