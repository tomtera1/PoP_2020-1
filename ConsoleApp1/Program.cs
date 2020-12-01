using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GGG();
        }
        
        private static void GGG()
        {
             int[] Scores = new int[4] { 60, 100, 66, 75 };
            int i = 0;
            int sum = 0;
            int averageScore = 0;
            for (i = 0; i < Scores.Length; i++)
            {
                sum += Scores[i];
            }
            averageScore = (int)sum / Scores.Length;
            Console.WriteLine($"AVG {averageScore}");

        }
        
            



    
    }
}
