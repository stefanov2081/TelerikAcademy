using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Sum1_N_DivByX_N
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get values from user input.
            Console.WriteLine("Enter integer n.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer x");
            int x = int.Parse(Console.ReadLine());

            double nFactorial = n;
            double sum = 0;

            // Find n factorial and divide it by x^i.
            for (double i = 1; i < n; i++)
            {
                nFactorial = nFactorial * i;
                sum = sum + nFactorial / Math.Pow(x, i);
            }
            // Print sum.
            Console.WriteLine("Sum = " + (sum + 1));
        }
    }
}
