using System;
using System.Globalization;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            CultureInfo cultureInfo = new CultureInfo("bg-BG");

            string firstDateSubString = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            string secondDateSubstring = other.OtherInfo.Substring(other.OtherInfo.Length - 10);

            DateTime firstDate;
            DateTime secondDate;
            DateTime.TryParse(firstDateSubString, cultureInfo, System.Globalization.DateTimeStyles.None, out firstDate);
            DateTime.TryParse(secondDateSubstring, cultureInfo, System.Globalization.DateTimeStyles.None, out secondDate);

            if (firstDate == new DateTime(0001, 1, 1, 00, 00, 00) || secondDate == new DateTime(0001, 1, 1, 00, 00, 00))
            {
                throw new ArgumentException("Invalid date");
            }

            int result = DateTime.Compare(firstDate, secondDate);

            if (result < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
