using System;

namespace _15FindPrimeN
{
    class FindPrimeN
    {
        static void Main(string[] args)
        {
            // Allocate and fill array with 10 million elements
            long[] array = new long[10000000];
            long count = 10000000;
            for (long i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            // Find and count each prime number using the sieve or Eratosthenes
            for (long i = 4 - 1; i < array.Length; i += 2)
            {
                if (array[i] != 0 && (array[i] % 2 == 0))
                {
                    array[i] = 0;
                    count--;
                }
            }
            for (long i = 6 - 1; i < array.Length; i += 3)
            {
                if (array[i] != 0 && (array[i] % 3 == 0))
                {
                    array[i] = 0;
                    count--;
                }
            }
            for (long i = 10 - 1; i < array.Length; i += 5)
            {
                if (array[i] != 0 && (array[i] % 5 == 0))
                {
                    array[i] = 0;
                    count--;
                }
            }
            for (long i = 14 - 1; i < array.Length; i += 7)
            {
                if (array[i] != 0 && (array[i] % 7 == 0))
                {
                    array[i] = 0;
                    count--;
                }
            }
            // Fill new array with all the prime numbers
            long j = 0;
            long[] primeN = new long[count];
            for (long i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    primeN[j] = (int)array[i];
                    j++;
                }
            }
            
            // Infinite loop to print prime numbers accessed by index
            decimal userChoice = 0;
            while (userChoice >= 0)
            {
                Console.WriteLine("There are {0} prime numbers in the interval from 1 to 10000000 \nTo see " +
                    "prime number enter number from 0 to {1}" +
                    "\nTo exit the program enter negative number i.e. -1", count, count - 1);
                Console.Write("Input:");
                userChoice = decimal.Parse(Console.ReadLine());
                if (userChoice >= 0 && userChoice < count)
                {
                    Console.WriteLine("The prime number with index {0} is {1}", userChoice, 
                        primeN[(long)userChoice]);
                }
                if (userChoice >= count)
                {
                    Console.WriteLine("Try again with smaller value!");
                }
            }
        }
    }
}
