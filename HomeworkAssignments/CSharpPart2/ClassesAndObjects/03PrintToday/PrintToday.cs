using System;

namespace _03PrintToday
{
    class PrintToday
    {
        static void Main(string[] args)
        {
            // Print today's date
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(today.DayOfWeek);
        }
    }
}
