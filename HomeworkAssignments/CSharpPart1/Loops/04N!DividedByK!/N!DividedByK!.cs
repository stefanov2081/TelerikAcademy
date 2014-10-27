using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04N_DividedByK_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter integer n.");
            BigInteger nFactorial = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer k. Must be greater than 1 and smaller than n, (1<k<n).");
            BigInteger kFactorial = BigInteger.Parse(Console.ReadLine());

            // Find n factorial.
            for (BigInteger i = nFactorial - 1; i >= 1; i--)
            {
                nFactorial = nFactorial * i;
            }

            // Find k factorial.
            for (BigInteger i = kFactorial - 1; i >= 1; i--)
            {
                kFactorial = kFactorial * i;
            }

            // Divide n! by k!
            BigInteger result = nFactorial / kFactorial;
            Console.WriteLine(nFactorial + " / " + kFactorial + " = " + result);
        }
    }
}
