using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10IsBitAtPositionP1
{
    class IsBitAtPositionP1
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter the integer in which you want to see if a given bit is 1.");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the postion of the bit in the given integer, to see if it is  1.");
            int p = int.Parse(Console.ReadLine());

            // mask = 1; 1 has 1 bit at position 0. Move the bit from position 0 to position p.
            int mask = 1 << p;

            // Set the value of vAndMask to a value that has 1 where v and mask has 1.
            int vAndMask = v & mask;

            // Move the bit from vAndMask to 0th position.
            int bit = vAndMask >> p;

            // If bit = 1 (binary - 0001) => the bit at position p was one. Else => 0. 
            if (bit == 1)
            {
                Console.WriteLine("The bit at position " + p + " in integer " + v + " is 1.");
            }
            else
            {
                Console.WriteLine("The bit at position " + p + " in integer " + v + " is 0.");
            }
        }
    }
}
