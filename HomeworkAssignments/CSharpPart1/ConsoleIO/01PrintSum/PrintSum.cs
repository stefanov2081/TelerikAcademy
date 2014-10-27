using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PrintSum
{
    class PrintSum
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter first integer");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integer");
            int c = int.Parse(Console.ReadLine());

            // Sum a + b + c, and print the sum.
            Console.WriteLine("The sum of " + a + " + " + b + " + " + c + " = " + (a + b + c));
        }
    }
}
