using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11GetBitInPositionB
{
    class GetBitInPositionB
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter the integer in which you want to see if a given bit is 0 or 1.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the postion of the bit in the given integer, to see if it is 0 or 1.");
            int p = int.Parse(Console.ReadLine());

            // mask = 1; 1 has 1 bit at position 0. Move the bit from position 0 to position p.
            // Set the value of mask to a value that has 1 where n and mask has 1.
            int mask = n & (1 << p);
            
            // Move the bit from position p to 0th position
            int bit = mask >> p;

            // Print the bit.
            Console.WriteLine("The bit at position " + p + " in integer " + n + " is " + bit + ".");
        }
    }
}
