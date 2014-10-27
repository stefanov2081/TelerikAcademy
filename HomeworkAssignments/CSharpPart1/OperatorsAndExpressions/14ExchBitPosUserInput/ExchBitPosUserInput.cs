using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ExchangeBitsPosition
{
    class ExchangeBitsPosition
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter unsigned integer. ");
            uint n = uint.Parse(Console.ReadLine());

            // Holds the original value of n.
            uint originalN = n;

            // Get value for the position of the bits in the left adn right side of n from user input.
            Console.WriteLine("Enter position for the starting bit that you want to move " + 
                "\nfrom the right hand side.");
            int rightHandSideBits = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position for the starting bit that you want to move " + 
                "\nfrom the left hand side.");
            int leftHandSideBits = int.Parse(Console.ReadLine());

            // Get value for how many bits to move from user input.
            Console.WriteLine("How many bits would you like to move.");
            int moveBits = int.Parse(Console.ReadLine());

            // Loop to get the values of the bits at position provided by user input.
            for (int i = 0; i < moveBits; i++)
            {
                uint mask1 = 1u << (rightHandSideBits + i);
                uint mask2 = 1u << (leftHandSideBits + i);
                uint exchangeLToRight = n & mask1;
                uint exchangeRToLeft = n & mask2;

                // Set the value of the bits from the left hand side, to the right hand side.
                // If n and mask1 = 1 => set 1. Else set 0.
                if (exchangeLToRight > 0)
                {
                    n = n | (1u << (leftHandSideBits + i));
                }
                else
                {
                    n = n & (~(1u << (leftHandSideBits + i)));
                }

                // Set the value of the bits from the right hand side, to the left hand side.
                // If n and mask2 = 1 => set 1. Else set 0.
                if (exchangeRToLeft > 0)
                {
                    n = n | (1u << (rightHandSideBits + i));
                }
                else
                {
                    n = n & (~(1u << (rightHandSideBits + i)));
                }
            }
            Console.WriteLine("If you exchange " + moveBits + " bits in a row, at starting position " + 
                rightHandSideBits +  "\nwith the bits at starting position " + leftHandSideBits + ", " + 
                originalN + " will have a value of " + n +".");
        }
    }
}
