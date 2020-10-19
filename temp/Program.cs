using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Student ID YEAR (4 digits): ");
            int YYYY = int.Parse(Console.ReadLine());
            Console.Write("Enter your Faculty (2 digits): ");
            int FF = int.Parse(Console.ReadLine());
            Console.Write("Enter your code of specialty (2 digits): ");
            int SS = int.Parse(Console.ReadLine());
            Console.Write("Enter your number withing specialty (4 digits): ");
            int NNNN = int.Parse(Console.ReadLine());

            int stidf = int.Parse($"{YYYY} {FF} {SS} {NNNN}");

            string StudNumber = GetStudNumber(stidf);

            static string GetStudNumber(int FF, int SS, int stidf)
            {
                if (FF > 09 || FF < 01)
                {
                    Console.WriteLine("ERROR");
                }

                else if (SS > 05 || SS < 01)
                {
                    return "ERROR";
                }

            }
            Console.WriteLine($"Your Student number: {stidf}");
            Console.ReadKey();
        }
    }
}
