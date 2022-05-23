using System;

namespace Lesson09.Enum
{

    enum DayOfWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek dayofweek = DayOfWeek.Monday;
            
            Console.WriteLine($"Today is {dayofweek}");
        }

        private static string GetHoliday(DayOfWeek dayOfWeek)
        {
            switch(dayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                    return "non-holiday";
                case DayOfWeek.Sunday:
                    return "holiday";
            }
            return String.Empty;
        }
    }
}
