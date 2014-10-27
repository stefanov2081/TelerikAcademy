using System;

namespace _05Workdays
{
    class Workdays
    {
        // Sorry for the mess, I thought that I solved this problem and when I was sending it I saw an error.
        // I had to fix it fast it was 23:45h

        // Find workdays in a time period. * Note that today is excluded!
        static int Workingdays(int year, int month, int day)
        {
            DateTime today = DateTime.Today;
            DateTime future = new DateTime(year, month, day);

            // Oficial holidays in Bulgaria (Easter not included)
            string[] holidays = { "1.1", "3.3", "1.4", "6.4", "24.4", "6.9", "22.9", "1.11", "24.12", "25.12", "26.12" };
            int holidaysCount = 0;

            // I know that these are stupid names for variables and a stupit alghoritm, 
            // but I had to include them in the last minute
            bool oneMoreIteration = false;
            int checkHoliday;
            int checkHoliMonth;
            string holiDate;

            // Count weekends between today and future date
            while (true)
            {
                if (today.DayOfWeek.ToString() == "Saturday" || today.DayOfWeek.ToString() == "Sunday")
                {
                    holidaysCount++;
                }

                checkHoliday = today.Day;
                checkHoliMonth = today.Month;
                holiDate = checkHoliday + "." + checkHoliMonth;

                for (int i = 0; i < holidays.Length; i++)
                {
                    if (holidays[i] == holiDate && (today.DayOfWeek.ToString() != "Saturday" || today.DayOfWeek.ToString() != "Sunday"))
                    {
                        holidaysCount++;
                    }
                }

                today = today.AddDays(1);

                if (today == future)
                {
                    oneMoreIteration = true;
                }
                else if (today!= future && oneMoreIteration)
                {
                    break;
                }
            }


            today = DateTime.Today;
            string temp = (future - today).ToString();
            temp = temp.TrimEnd('0', ':', '.');
            int span = int.Parse(temp);

            return span - holidaysCount;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("You can check the workdays in the period between today and a given future date." + 
                "\n* Note that today is excluded!");
            Console.Write("Enter year in the given format \"2014\": ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter month in the given format \"2\": ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter day in the given format \"7\": ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Today is " + DateTime.Today);
            DateTime td = DateTime.Today;
            DateTime ft = new DateTime(y, m, d);
            Console.WriteLine(ft - td + " total days.");
            Console.WriteLine("There are " + Workingdays(y, m, d) + " workdays between today and " + ft);
        }
    }
}
