using System;

namespace Lesson_03
{
    class Program
    {
        private static void Main(string[] args)
        {
            Task_03();
        }

        private static void Task_03()
        {
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine("SPORT FOR YOU");
            Console.WriteLine("~~~~~~~~~~~~~");

            Console.Write("Enter your height in cantimeters: ");
            int height = int.Parse(Console.ReadLine());

            if (height > 190)
            {
                Console.WriteLine("BASKETBALL");

            }
            else if (height > 175)
            {
                Console.WriteLine("ATHLETICS");
            }
            else
            {
                Console.WriteLine("HORSE RIDING");
            }
            Console.ReadKey();
            
        }

        private static void Task_02()
        {
            Console.WriteLine("~~~~~~~~~~~~~~");
            Console.WriteLine("10 NUMBERS");
            Console.WriteLine("~~~~~~~~~~~~~~");

            int countOfNumbers = 0;
            int sumOfNumbers = 0;

            for (int counter = 1; counter <= 10; counter++)
            {
                Console.Write($"Enter number {counter}: ");
                int number = int.Parse(Console.ReadLine());

                if(number <= 20 && number >= 10)
                {
                    countOfNumbers++;
                    sumOfNumbers = sumOfNumbers + number;
                }
            }

            Console.WriteLine($"There are {countOfNumbers} between 10 and 20");
            Console.WriteLine($"Sum of numbers between 10 and 20 is {sumOfNumbers}");
            Console.ReadKey();


        }

        private static void Task_01()
        {
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine("TRIANGLES");
            Console.WriteLine("~~~~~~~~~~");

            Console.Write("Side A: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.Write("Side B: ");
            int sideB = int.Parse(Console.ReadLine());

            Console.Write("Side C: ");
            int sideC = int.Parse(Console.ReadLine());

            if (sideA == sideB || sideB == sideC || sideA == sideC)
            {
                Console.WriteLine("There are 2 equal sides.");

                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("There are 3 equal sides.");
                    Console.WriteLine("A, B, C are equal.");
                }
                else
                {
                    if (sideA == sideB)
                    {
                        Console.WriteLine("A is equal to B");
                    }
                    else if (sideB == sideC)
                    {
                        Console.WriteLine("B is equal to C");
                    }
                    else
                    {
                        Console.WriteLine("A is equal to C");
                    }
                }



                
            }
            else
            {
                Console.WriteLine("There's no equal sides");
            }
            Console.ReadKey();


        }


       



    }
}
