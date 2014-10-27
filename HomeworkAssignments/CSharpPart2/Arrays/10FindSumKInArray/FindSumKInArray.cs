using System;

namespace _10FindSumKInArray
{
    class FindSumKInArray
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element[{0}]", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("What sum would you like to search the array for?");
            int k = int.Parse(Console.ReadLine());

            // Find sum k
            int sum = 0;
            int ii = 0;
            int j = 0;
            string sequence = "";
            while (true)
            {
                // Prevents index out of range errors
                if (j > n - 1)
                {
                    break;
                }
                // Sum every element and check if the sum is equal to k
                sum += array[j];
                sequence += array[j] + " ";

                if (sum == k)
                {
                    break;
                }

                // If the sum is greater than k, start from the next element
                if (sum > k)
                {
                    sum = 0;
                    sequence = "";
                    ii++;
                    j = ii;
                }

                j++;
            }
            // Print
            if (sum == k)
            {
                Console.WriteLine("The numbers {0}have a sum of {1}", sequence, sum);
            }
            else
            {
                Console.WriteLine("There are no elements with sum " + k);
            }
        }
    }
}
