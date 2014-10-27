using System;
using System.Linq;

namespace _09FindMostFrequentNumInArr
{
    class FindMostFrequentNumInArr
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

            // Count every element in the array
            int[] count = new int[10];
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    count[0]++;
                }
                if (array[i] == 1)
                {
                    count[1]++;
                }
                if (array[i] == 2)
                {
                    count[2]++;
                }
                if (array[i] == 3)
                {
                    count[3]++;
                }
                if (array[i] == 4)
                {
                    count[4]++;
                }
                if (array[i] == 5)
                {
                    count[5]++;
                }
                if (array[i] == 6)
                {
                    count[6]++;
                }
                if (array[i] == 7)
                {
                    count[7]++;
                }
                if (array[i] == 8)
                {
                    count[8]++;
                }
                if (array[i] == 9)
                {
                    count[9]++;
                }
            }

            // Print most frequently occuring element
            Console.WriteLine("The number {0} occurs {1} times", Array.IndexOf(count, count.Max()), 
                count.Max());
        }
    }
}
