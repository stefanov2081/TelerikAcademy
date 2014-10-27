using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03MinAndMaxFromNNumbers
{
    class MinAndMaxFromNNumbers
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("For how many numbers would you like to check min and max value?" + 
                " Enter integer.");
            int n = int.Parse(Console.ReadLine());
            int[] userInput = new int[n];

            // Fill in array.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter integer number " + (i + 1));
                userInput[i] = int.Parse(Console.ReadLine());
            }
            
            // Find min and max value.
            Console.WriteLine("Minimal value is " + userInput.Min());
            Console.WriteLine("Maximum value is " + userInput.Max());
        }
    }
}
