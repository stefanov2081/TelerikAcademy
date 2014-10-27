using System;

namespace _21DistinctPermutsFrom1ToNInSubsetK
{
    class DistinctPermutsFrom1ToNInSubsetK
    {
        static int[] array;

        // Find and print all distinct permutations
        static void DistinctPermutations(int n, int k, int iteration = 1, int sNum = 1)
        {
            for (int ii = sNum; ii <= n; ii++)
            {
                array[iteration - 1] = ii;
                if (iteration != k)
                {
                    sNum = ii + 1;
                    DistinctPermutations(n, k, iteration + 1, sNum);
                }
                else
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
            }
        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter n, to see all distinct permutations from 1 to n, limited in subset k");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter size of subset, k");
            int k = int.Parse(Console.ReadLine());

            array = new int[k];
            // Call function distinct permutations
            DistinctPermutations(n, k);
        }
    }
}