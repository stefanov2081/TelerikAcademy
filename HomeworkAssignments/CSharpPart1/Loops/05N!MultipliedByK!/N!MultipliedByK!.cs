using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05N_MultipliedByK_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter n.");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter k.");
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger nFactorial = n;
            BigInteger kFactorial = k;

            // Find n factorial.
            for (BigInteger i = nFactorial - 1; i >= 1; i--)
            {
                nFactorial = nFactorial * i;
            }
            Console.WriteLine("N factorial:");
            Console.WriteLine(nFactorial);
            // Find k factorial.
            for (BigInteger i = kFactorial - 1; i >= 1; i--)
            {
                kFactorial = kFactorial * i;
            }

            // Calculate and prBigInteger n! * k! / (k - n).
            Console.WriteLine(nFactorial + " * " + kFactorial + " / " + k + " - " + n + " = " + 
                ((nFactorial * kFactorial) / (k - n)));
        }
    }
}
