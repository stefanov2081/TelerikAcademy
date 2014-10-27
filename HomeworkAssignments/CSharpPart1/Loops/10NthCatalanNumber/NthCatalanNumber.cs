using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10NthCatalanNumber
{
    class NthCatalanNumber
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer N, to find the Nth Catalan Number. n >= 0");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger nFactorial = n;
            BigInteger twoTimesNFactorial = n * 2;
            BigInteger nPlusOneFactorial = n + 1;
            BigInteger catalanNumber;

            // Find n!.
            for (BigInteger i = n - 1; i > 0; i--)
            {
                nFactorial = nFactorial * i;
            }

            // Find (2 * n)!
            for (BigInteger i = twoTimesNFactorial - 1; i > 0; i--)
            {
                twoTimesNFactorial = twoTimesNFactorial * i;
            }

            // Find (1 + n)!
            for (BigInteger i = nPlusOneFactorial - 1; i > 0; i--)
            {
                nPlusOneFactorial = nPlusOneFactorial * i;
            }
            
            // Find and print Catalan number.
            catalanNumber = twoTimesNFactorial / (nPlusOneFactorial * nFactorial);
            Console.WriteLine("The catalan number for n = " + n + " is " + catalanNumber);
        }
    }
}
