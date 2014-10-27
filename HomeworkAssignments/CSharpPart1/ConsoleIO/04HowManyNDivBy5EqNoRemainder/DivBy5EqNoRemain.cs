using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HowManyNDivBy5EqNoRemainder
{
    class DivBy5EqNoRemain
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter integer.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another one, bigger than the first one, to see how many times the numbers " +
             "between the two integers can be divided without remainder");
            int b = int.Parse(Console.ReadLine());
            
            // Holds the original value of a.
            int originalA = a;
            
            // Count how many time the loop has been iterated.
            int counter = 0;

            // Stores the result from the division.
            int quotient;

            // Divide a by 5, while a = b. If there is no remainder increment counter.
            do
            {
                quotient = a % 5;
                a++;
                if (quotient == 0)
                {
                    counter++;
                }
            } while (a <= b);
            Console.WriteLine("The interval from " + originalA + " to " + b + " has " + counter + 
                " digit(s) that can be " + "divided by 5 \nwithout remainder.");
        }
    }
}
