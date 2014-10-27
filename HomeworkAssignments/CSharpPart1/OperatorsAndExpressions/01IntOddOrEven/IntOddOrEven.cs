using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IntOddOrEven
{
    class IntOddOrEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer.");
            
            // Get value from user input.
            int oddOrEven = int.Parse(Console.ReadLine());
            
            // If oddOrEven divides without remainder => even. Else => odd.
            if ((oddOrEven % 2) == 0)
            {
                Console.WriteLine(oddOrEven + " is even.");
            }
            else
            {
                Console.WriteLine(oddOrEven + " is odd.");
            }
        }
    }
}
