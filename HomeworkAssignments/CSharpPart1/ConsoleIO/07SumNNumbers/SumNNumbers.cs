using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SumNNumbers
{
    class SumNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many numbers would you like to sum. Must be integer.");

            // Get value from user input.
            int n = int.Parse(Console.ReadLine());
            
            // Get the value for each number to sum from user input.
            float eachN;

            // Hold the value of the sum from all the numbers.
            float sum = 0;

            // Get value from user input for each number. Iterate n times and sum.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter digit. It can be with a floating point.");
                eachN = float.Parse(Console.ReadLine());
                sum = sum + eachN;
            }
            
            Console.WriteLine("The sum of all the numbers is " + sum);
            
        }
    }
}
