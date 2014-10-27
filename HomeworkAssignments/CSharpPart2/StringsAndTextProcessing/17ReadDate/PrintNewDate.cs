using System;
using System.Globalization;
using System.Threading;

namespace _17ReadDate
{
    class PrintNewDate
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter date (yyyy.mm.dd hh:mm:ss): ");
            string date = Console.ReadLine();

            // Parse input to integer
            // Get year
            int frstIndex = date.IndexOf('.');
            int scndIndex = date.IndexOf('.', frstIndex + 1);
            int length = scndIndex - frstIndex;
            int year = int.Parse(date.Substring(0, frstIndex));
            
            // Get month
            int month = int.Parse(date.Substring(frstIndex + 1, length - 1));
            
            // Get day
            frstIndex = date.IndexOf(' ');
            length = frstIndex - scndIndex;
            int day = int.Parse(date.Substring(scndIndex + 1, length - 1));

            // Get hour
            frstIndex = date.IndexOf(' ');
            scndIndex = date.IndexOf(':');
            length = scndIndex - frstIndex;
            int hour = int.Parse(date.Substring(frstIndex + 1, length - 1));

            // Get minute
            frstIndex = date.IndexOf(':', scndIndex + 1);
            length = frstIndex - scndIndex;
            int minute = int.Parse(date.Substring(scndIndex + 1, length - 1));

            // Get second
            int second = int.Parse(date.Substring(frstIndex + 1));

            // Set culture to BG
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            // Set DateTime and print current time
            DateTime time = new DateTime(year, month, day, hour, minute, second);
            Console.WriteLine("Six and a half hours from " + time);

            // Add 6 hours and 30 minutes and print
            time = time.AddHours(6);
            time = time.AddMinutes(30);
            Console.Write("will be " + time);
            
        }
    }
}
