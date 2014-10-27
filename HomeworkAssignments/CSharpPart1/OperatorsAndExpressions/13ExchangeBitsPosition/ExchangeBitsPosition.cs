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

            // The position of the bits in the left adn right side of n.
            int rightHandSideBits = 3;
            int leftHandSideBits = 24;

            // Loop to get the values of the bits at position 3, 4, 5, 24, 25, 26.
            for (int i = 0; i < 3; i++)
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
            Console.WriteLine("If you exchange the bits at position 3, 4 and 5 with the bits at position " +
                "24, 25 and 26, " + originalN + " will have a value of " + n);
        }
    }
}
