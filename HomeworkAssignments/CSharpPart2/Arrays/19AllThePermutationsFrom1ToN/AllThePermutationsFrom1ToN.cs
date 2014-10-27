using System;
using System.Numerics;

namespace _19AllThePermutationsFrom1ToN
{
    class AllThePermutationsFrom1ToN
    {
        // Find factorial of n
        static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n < 0)
            {
                return 0;   // Factorial undefined for negative numbers
            }
            BigInteger sum = 1;
            for (int i = 1; i <= n; i++)
            {

                sum *= i;
            }
            return sum;
        }

        // Swap values
        static int[] Swap(int[] s, int k, int j)
        {
            int temp;
            temp = s[k];
            s[k] = s[j];
            s[j] = temp;
            return s;
        }

        // Find all the permutations
        static int[] Permutation(int[] s)
        {
            bool notLastPermutation = false;
            int k = 0;
            int l = 0;
            // Find the largest index k such that a[k] < a[k + 1]. If no such index exists, 
            // the permutation is the last permutation.
            for (int i = s.Length - 1; i > 0; i--)
            {
                if (s[i] > s[i - 1])
                {
                    k = i - 1;
                    notLastPermutation = true;
                    break;
                }
            }
            // Find the largest index l such that a[k] < a[l].
            if (notLastPermutation == true)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] > s[k])
                    {
                        l = i;
                        break;
                    }
                }
            }
            if (notLastPermutation == false)
            {
                return s;
            }
            // Swap the value of a[k] with that of a[l].
            Swap(s, k, l);
            // Reverse the sequence from a[k + 1] up to and including the final element a[n].
            int[] tempArray = new int[s.Length - (k + 1)];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = s[k + 1 + i];
            }
            Array.Reverse(tempArray);
            for (int i = 0; i < tempArray.Length; i++)
            {
                s[k + 1 + i] = tempArray[i];
            }

            return s;
        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter number n, to see all the permutations from 1 to n");
            int n = int.Parse(Console.ReadLine());
            
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            // Print first permutation
            Console.WriteLine("Permutation number " + (1));
            for (int ii = 0; ii < n; ii++)
            {
                if (ii < n - 1)
                {
                    Console.Write(array[ii] + ",");
                }
                else
                {
                    Console.Write(array[ii]);
                }
            }
            Console.WriteLine();

            // Print all permutations except the first
            for (BigInteger i = 0; i < Factorial(n) - 1; i++)
            {
                array = Permutation(array);
                Console.WriteLine("Permutation number " + (i + 2));
                for (int ii = 0; ii < n; ii++)
                {
                    if (ii < n - 1)
                    {
                        Console.Write(array[ii] + ",");
                    }
                    else
                    {
                        Console.Write(array[ii]);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
