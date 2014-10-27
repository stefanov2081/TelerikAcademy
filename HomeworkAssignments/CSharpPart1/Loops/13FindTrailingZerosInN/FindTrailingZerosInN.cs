using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13FindTrailingZerosInN
{
    class FindTrailingZerosInN
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter BigIntegereger, to find how many trailing zeros does it have.");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger originalN = n;
            BigInteger count = 0;
            BigInteger remainder;

            for (BigInteger i = n - 1; i >= 1; i--)
            {
                n = n * i;
            }

            BigInteger nFactorial = n;
            while (true)
            {
                remainder = n % 10;
                n = n / 10;

                if (remainder == 0)
                {
                    count++;
                }
                else if (remainder > 0)
                {
                    break;
                }
            }
            Console.WriteLine(originalN + " factorial = " + nFactorial + ". " + nFactorial + " has " + 
                count + " trailing zeros.");
        }
    }
}
