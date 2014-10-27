using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071NextDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime tomorrow = new DateTime(year, month, day);
            tomorrow = tomorrow.AddDays(1);
            Console.WriteLine(tomorrow.ToString("d.M.yyyy"));
        }
    }
}
