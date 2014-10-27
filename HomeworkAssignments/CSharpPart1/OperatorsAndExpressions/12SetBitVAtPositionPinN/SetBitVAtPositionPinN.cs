using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SetBitVAtPositionPinN
{
    class SetBitVAtPositionPinN
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer \"n\" to modify it's bits.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value \"v\", that must be 0 or 1, to modify \"n\".");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit that you want to modify with the value of \"v\" \nin"               + "\"n\".");
            int p = int.Parse(Console.ReadLine());
            
            // Stores the value of n with modified bits.
            int newValue;

            // If user input is 1 => set the bit at position p to 1. Else set the bit at p to 0.
            if (v == 1)
            {
                newValue = n | (1 << p);
                Console.WriteLine("If you change the bit in " + n + ", at position " + p + ", with " + v + 
                    ", it will " + "have a value of " + newValue + ".");
            }
            else if (v == 0)
            {
                newValue = n & (~(1 << p));
                Console.WriteLine("If you change the bit in " + n + ", at position " + p + ", with " + v +
                    ", it will " + "have a value of " + newValue + ".");
            }
        }
    }
}
