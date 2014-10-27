using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02IsProductPlusOrMinus
{
    class IsProductPlusOrMinus
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter number \"a\"");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"b\"");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"c\"");
            float c = float.Parse(Console.ReadLine());

            // If a and b and c are greater than zero => product is positive.
            if (a > 0 & b > 0 & c > 0)
            {
                Console.WriteLine("The product of the multiplication will be positive.");
            }
            // If a is less than zero and b is less than than zero and c is greater than zero,
            // or If a is greater than zero and b is less than zero and c is less than zero,
            // or If a is less than zero and b is greater than zero and c less than zero => positive.
            else if ((a < 0 & b < 0 & c > 0) || (a > 0 & b < 0 & c < 0) || (a < 0 & b > 0 & c < 0))
            {
                Console.WriteLine("The product of the multiplication will be positive.");
            }
            // If a or b or c are equal to zero => product is zero.
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The product of the multiplication will be zero.");
            }
            // All other cases => product is negative.
            else
            {
                Console.WriteLine("The product of the multiplication will be negative.");
            }
        }
    }
}
