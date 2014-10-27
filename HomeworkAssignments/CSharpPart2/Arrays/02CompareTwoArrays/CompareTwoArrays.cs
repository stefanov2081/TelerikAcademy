using System;

namespace _02CompareTwoArrays
{
    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big arrays would you like to allocate?");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("First array, index[{0}]:", i);
                arr1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Second array, index[{0}]", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            // Compare and print the arrays
            for (int i = 0; i < n; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine(arr1[i] + " != " + arr2[i]);
                }
                else
                {
                    Console.WriteLine(arr1[i] + " = " + arr2[i]);
                }
            }
        }
    }
}
