using System;

namespace _16ReadTwoDates
{
    class DistanceInDays
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter date (yyyy/mm/dd): ");
            string first = Console.ReadLine();

            // Parse input to integer
            int frstIndex = first.IndexOf('/') + 1;
            int scndIndex = first.IndexOf('/', frstIndex);
            int monthLength = scndIndex - (frstIndex);
            int year = int.Parse(first.Substring(0, frstIndex - 1));
            int month = int.Parse(first.Substring(frstIndex, monthLength));
            int day = int.Parse(first.Substring(scndIndex + 1));

            // Feed input to DateTime()
            DateTime firstDate = new DateTime(year, month, day);

            // Get value from user input
            Console.Write("Enter second date (yyyy/mm/dd): ");
            string second = Console.ReadLine();

            // Parse input to integer
            frstIndex = second.IndexOf('/') + 1;
            scndIndex = second.IndexOf('/', frstIndex);
            monthLength = scndIndex - (frstIndex);
            year = int.Parse(second.Substring(0, frstIndex - 1));
            month = int.Parse(second.Substring(frstIndex, monthLength));
            day = int.Parse(second.Substring(scndIndex + 1));

            // Feed input to DateTime()
            DateTime secondDate = new DateTime(year, month, day);

            // Print
            if (firstDate >= secondDate)
            {
                Console.WriteLine("There are {0} days between \n{1} and {2}", (firstDate - secondDate), firstDate, secondDate);
            }
            else
            {
                Console.WriteLine("There are {0} days between \n{1} and {2}", (secondDate - firstDate),secondDate ,firstDate);
            }
        }
    }
}
