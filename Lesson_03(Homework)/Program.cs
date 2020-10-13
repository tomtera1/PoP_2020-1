using System;

namespace Lesson_03_Homework_
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_04();
        }

        private static void Task_04()
        {
            Console.WriteLine("JUST  SOME WEEK INFO:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            DateTime now = DateTime.Now;
            int hhour = now.Hour;
            DateTime today = DateTime.Now;
            int WeekDay = (int)today.DayOfWeek;

            string PartOfDay = GetPartOfDay(hhour);
            string DayName = GetDayName(WeekDay);
            string ToWeekend = GetToWeekend(WeekDay);



            Console.WriteLine($"Good {PartOfDay}, it's lovely {DayName}. {ToWeekend}");

            Console.ReadKey();
        }
        private static string GetPartOfDay(int hhour)
        {
            if (hhour < 5 || hhour > 22)
            {
                return "Night";
            }
            else if (hhour < 11)
            {
                return "Morning";
            }
            else if (hhour < 16)
            {
                return "Day";
            }
            else
            {
                return "Evening";
            }
        }

        private static string GetToWeekend(int WeekDay)
        {
            switch (WeekDay)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return $"The Weekend Is Coming in {6 - WeekDay} Days!!!";
                case 6:
                case 7:
                    return "The Weekend Is Here!!! WOHOOO!!!";

                default:
                    return "I don't know this time of the week:(";
            }

        }

        private static string GetDayName(int WeekDay)
        {
            switch (WeekDay)
            {
                case 1: return "Monday";
                case 2: return "Tuesday";
                case 3: return "Wednesday";
                case 4: return "Thursday";
                case 5: return "Friday";
                case 6: return "Saturday";
                case 7: return "Sunday";
                default: return "ERROR";
            }




        }
    }
}
