using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04IsThirdDigit7
{
    class IsTheThirdDigit7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number that you want to find if it's third digit is 7.");

            // Get value from user input.
            int number = int.Parse(Console.ReadLine());
            
            // Divide by 100 to eliminate last two digits and get the remainder from the third digit.
            int thirdDigit = (number / 100) % 10;
            
            // If the remainder from the third digit is 0 => third digit is 7. Else it is something else.
            if (thirdDigit == 7)
            {
                Console.WriteLine("The third digit is " + thirdDigit);
            }
            else
            {
                Console.WriteLine("The third digit is not seven. It is " + thirdDigit);
            }
        }
    }
}
