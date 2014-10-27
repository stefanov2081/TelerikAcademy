using System;

namespace _03CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big arrays would you like to allocate?");
            int n = int.Parse(Console.ReadLine());

            char[] arr1 = new char[n];
            char[] arr2 = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter character[{0}] in the first char array:", i);
                arr1[i] = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter character[{0}] in the second char array:", i);
                arr2[i] = char.Parse(Console.ReadLine());
            }

            // Compare and print the two arrays
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
