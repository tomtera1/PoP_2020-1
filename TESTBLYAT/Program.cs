using System;

namespace TESTBLYAT
{
    class Program
    {
        static void Main(string[] args)
        {
            AAA();
        }

        private static void AAA()
        {
            int[] Scores = new int[4];
            Scores[0] = 60;
            Scores[1] = 100;
            Scores[2] = 66;
            Scores[3] = 75;
            int i = 0;
            int sum = 0;
            float AverageScore = 0.0F;
            for (i = 0; i < Scores.Length; i++)
            {
                sum += Scores[i];
            }

            AverageScore = (float)sum / Scores.Length;

            Console.WriteLine($"Sosi huy {AverageScore}");
        }



    }
}        
    

