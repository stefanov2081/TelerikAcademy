using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PrintFrom1ToN
{
    class PrintFrom1ToN
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer greater than 1.");
            int n = int.Parse(Console.ReadLine());

            // Loop through all the number from n to 1 and print.
            while (n >= 1)
            {
                Console.WriteLine(n);
                n--;
            }
        }
    }
}
