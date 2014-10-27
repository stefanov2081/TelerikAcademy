using System;

namespace _20PermutationsFrom1ToNInSubsetK
{
    class PermutationsFrom1ToNInSubsetK
    {
        // Find and print all the permutations from 1 to n in subset k
        static void Permutation(int[] array, int n, int iteration, int sNum)
        {
            if (iteration >= array.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                    Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    array[iteration] = i;
                    Permutation(array, n, iteration + 1, i);
                }
            }
            
        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter n, to see all the permutations from 1 to n, limited in subset k");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of subset, k");
            int k = int.Parse(Console.ReadLine());
            
            int[] array = new int[k];
            // Call function permutation
            Permutation(array, n, 0, 1);


            

        }
    }
}
