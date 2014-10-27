using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07IsNPrime
{
    class IsNPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to see if it is prime.");

            // Get value from user input.
            int n = int.Parse(Console.ReadLine());
            
            // Boolean to store the value of whether or not n is prime.
            bool isTrue = true;
            
            // Divide all numbers from 2 to n / 1. If there is no remainder isTrue = false.
            for (int i = 2; i < n / 2; i++)
            {

                if (n % i == 0)
                {
                    isTrue = false;
                    break;
                }
            }

            // If isTue == true => n is prime. Else n is composite.
            if (isTrue == true)
            {
                Console.WriteLine(n + " is a prime number.");
            }
            else if (isTrue == false)
            {
                Console.WriteLine(n + " is a composite number.");
            }
        }
    }
}
