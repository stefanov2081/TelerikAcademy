using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Age_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());
            //DateTime futureAge = new DateTime(age, 1, 1);
            //futureAge = futureAge.AddYears(10);
            //Console.WriteLine("In ten years you will be {0} years old.", futureAge.Year);

            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime tomorrow = new DateTime(year, month, day);
            tomorrow = tomorrow.AddDays(1);
            Console.WriteLine(tomorrow.ToString("d.M.yyyy"));
        }
    }
}
