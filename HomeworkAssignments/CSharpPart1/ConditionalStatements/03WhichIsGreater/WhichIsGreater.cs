using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03WhichIsGreater
{
    class WhichIsGreater
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter integer \"a\"");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer \"b\"");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer \"c\"");
            int c = int.Parse(Console.ReadLine());

            // a is greater than b and c => a is greater.
            if (a > b & a > c)
            {
                Console.WriteLine(a + " is greater.");
            }
            // If b is greater than a and c => b is greater.
            else if (b > a & b > c)
            {
                Console.WriteLine(b + " is greater.");
            }
            // If c is greater than a and b => c is greater.
            else if (c > a & c > b)
            {
                Console.WriteLine(c + " is greater.");
            }
            // All other cases => numbers are equal.
            else
            {
                Console.WriteLine(a + ", " + b + " and " + c + " are equal.");
            }
        }
    }
}
