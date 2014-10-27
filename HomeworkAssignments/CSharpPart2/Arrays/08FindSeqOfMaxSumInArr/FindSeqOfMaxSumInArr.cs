using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08FindSeqOfMaxSumInArr
{
    class FindSeqOfMaxSumInArr
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

            // Find sequence with largest sum
            int sum = 0;
            int maxSum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                if (sum <= 0)
                {
                    sum = 0;
                    i = i + 1;
                }
            }

            // Print
            Console.WriteLine("The sequence with largest sum, has a sum of " + maxSum);
        }
    }
}
