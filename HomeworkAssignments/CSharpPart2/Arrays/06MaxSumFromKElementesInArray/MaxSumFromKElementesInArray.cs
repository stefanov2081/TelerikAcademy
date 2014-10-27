using System;

namespace _06MaxSumFromKElementesInArray
{
    class MaxSumFromKElementesInArray
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big an array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element[{0}]", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("How many elements would you like to sum?");
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[k];

            // Find the elements with max sum
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Get the largest k elements from array to sum
                    if (sum[i] <= array[j])
                    {
                        sum[i] = array[j];
                    }
                }
                for (int ii = 0; ii < n; ii++)
                {
                    // When the element is copied to sum, zero it in array to avoid repetition
                    if (sum[i] == array[ii])
                    {
                        array[ii] = 0;
                        break;
                    }
                }
            }

            // Sum the largest k elements and print
            Console.Write("The sum of ");
            long totalSum = 0;
            for (int i = 0; i < k; i++)
            {
                Console.Write(sum[i]);
                if (i < k - 1)
                {
                    Console.Write(" + ");
                }
                totalSum += sum[i];
            }
            Console.WriteLine(" = " + totalSum);
        }
    }
}
