using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;

namespace _19ExtractFromText
{
    class ExtractDate
    {
        // Validate date
        const string MatchDate = @"[0-9]{1,2}[.][0-9]{1,2}[.][0-9]{1,4}";
        
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter text containing date in current format: dd.mm.yyyy: ");
            string text = Console.ReadLine();

            // Use regular expression to find matches
            Regex regex = new Regex(MatchDate);
            
            // Find matches
            MatchCollection dates = regex.Matches(text);

            // Loop through all dates
            for (int i = 0; i < dates.Count; i++)
            {
                string currentDate = dates[i].ToString();
                // Parse input to integer
                // Get day
                int frstIndex = currentDate.IndexOf('.');
                int scndIndex = currentDate.IndexOf('.', frstIndex + 1);
                int length = scndIndex - frstIndex;
                int day = int.Parse(currentDate.Substring(0, frstIndex));

                // Get month
                int month = int.Parse(currentDate.Substring(frstIndex + 1, length - 1));

                // Get year
                int year = int.Parse(currentDate.Substring(scndIndex + 1));

                // New DateTime object
                DateTime date = new DateTime(year, month, day);

                // Set culture to Canada
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
                
                // Print
                Console.WriteLine(date);
            }
        }
    }
}
