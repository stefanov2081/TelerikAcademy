using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PrintFibonacciNumber
{
    class PrintFibonacciNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are the first 100 numbers from Fibonnaci Number.");

            // Print the first two numbers from the sequence.
            decimal a = 0;
            decimal b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Calculate the value of the next number from the sequence and print it.
            for (int i = 1; i < 100; i++)
            {

                b = a + b;
                a = b - a;
                
                Console.WriteLine(b);
            }
        }
    }
}
