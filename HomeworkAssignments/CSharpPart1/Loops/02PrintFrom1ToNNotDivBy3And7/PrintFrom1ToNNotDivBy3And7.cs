using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrintFrom1ToNNotDivBy3And7
{
    class PrintFrom1ToNNotDivBy3And7
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer greater than 1.");
            int n = int.Parse(Console.ReadLine());

            // Loop through n to 1, check if it divides by 7 and 3 and if does not => print n.
            while (n >= 1)
            {
                if ((n % 7 == 0) && (n % 3 == 0))
                {
                }
                else
                {
                    Console.WriteLine(n + " is not divisible by 3 and 7 at the same time.");
                }
                n--;
            }
        }
    }
}
