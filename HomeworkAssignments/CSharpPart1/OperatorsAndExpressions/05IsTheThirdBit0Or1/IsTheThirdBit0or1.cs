using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05IsTheThirdBit0Or1
{
    class IsTheThirdBit0or1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number, to find if it's third bit is 0 or 1.");

            // Get value from user input.
            int userInput = int.Parse(Console.ReadLine());
            
            // Set value of thirdBit where userInput and 8 have 1. 8 has 1 only in it's third bit.
            int thirdBit = userInput & 8;
            
            // If third bit is larger than 0 => third bit in userInput is 1. Else => 0.
            if (thirdBit > 0)
            {
                Console.WriteLine("The third bit is 1");
            }
            else
            {
                Console.WriteLine("The third bit is 0");
            }
        }
    }
}
