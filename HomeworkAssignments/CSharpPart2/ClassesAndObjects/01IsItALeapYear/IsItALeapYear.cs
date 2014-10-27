using System;

namespace _01IsItALeapYear
{
    class IsItALeapYear
    {
        // Check if it is a leap year
        static string IsItLeapYear(int year)
        {
            string result;
            bool leap = DateTime.IsLeapYear(year);
            if (leap == false)
            {
                result = "Year " + year + " is not a leap year!";
            }
            else
            {
                result = "Year " + year + " is a leap year!";
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            // Call IsItLeapYear() and print
            Console.WriteLine(IsItLeapYear(year));
        }
    }
}
