using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02IntDivNoRemainder
{
    class IntDivNoRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer.");

            // Get value from user input.
            int remainderOrNoRem = int.Parse(Console.ReadLine());
            
            // If it divides by 5 and by 7 without remainder => user value can be divided by 5 and 7 at the                   same time. Else => It can't be divided by 5 and 7 at the same time.
            if ((remainderOrNoRem % 5) == 0 && (remainderOrNoRem % 7) == 0)
            {
                Console.WriteLine(remainderOrNoRem + " divides by 5 and 7 with no remainder.");
            }
            else
            {
                Console.WriteLine(remainderOrNoRem + " can not be divided by 5 and 7 without a remainder");
            }
        }
    }
}
