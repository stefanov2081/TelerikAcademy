using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07SumNNumFromFibonacciNumber
{
    class SumNNumFromFibonacciNumber
    {
        static void Main(string[] args)
        {
            // Get value from user input.
            Console.WriteLine("Enter integer n, to find the sum of the first n numbers " +
                "from Fibonacci number. N must be positive integer.");
            int n = int.Parse(Console.ReadLine());
            
            // First and second members from Fibonacci number and sum.
            BigInteger a = 0;
            BigInteger b = 1;
            BigInteger sum = 0;

            // Print first member from Fibonnaci number.
            Console.WriteLine("0");

            // Print and sum the other members of the Fibonacci number from 1 to n.
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(b);
                sum = b + sum;
                b = a + b;
                a = b - a;
            }
            Console.WriteLine("The sum of the first " + (n + 1) + " members of the Fibonnaci number = " +sum);
        }
    }
}
