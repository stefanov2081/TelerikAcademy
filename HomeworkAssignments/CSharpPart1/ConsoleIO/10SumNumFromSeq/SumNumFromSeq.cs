using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SumNumFromSeq
{
    class SumNumFromSeq
    {
        static void Main(string[] args)
        {
            // * Note: I am using rounding to the 4th symbol, insted to the 3rd, beacause it looks better!
            // x is used to store the value after the division and sum it in sum. divideEven divides the even
            // positive numbers, and divideOdd divides the negative odd numbers.
            double x = 0.0;
            double sum = 1.0;
            int divideEven = 2;
            int divideOdd = 3;

            // Prints 1, it's easier that way...
            Console.WriteLine("1 ...");
            
            // Divide the even numbers, sum the value in sum, print the result, increment divideEven by 2;
            do
            {
                x = 1.0 / divideEven;
                sum += x;
                Console.Write("...+1/{0,-5}={1,4:f4}; ", divideEven, sum);
                divideEven = divideEven + 2;
                // Divide the odd numbers, sum the value in sum, print the result, increment divideOdd by 2;
                // First while loop is an infinite loop. Break; breaks the loop at each iteration.
                // Break; evaluate the second while statement and do the loops while x > 0.001;
                
                while (true)
                {
                    x = 1.0 / divideOdd;
                    sum -= x;
                    Console.Write("...-1/{0,-5}={1,4:f4}; ", divideOdd, sum);
                    divideOdd = divideOdd + 2;
                    break;
                }
            } while (x > 0.001);
            
            Console.WriteLine("Sum is  = {0:f4}", sum);
        }
    }
}
