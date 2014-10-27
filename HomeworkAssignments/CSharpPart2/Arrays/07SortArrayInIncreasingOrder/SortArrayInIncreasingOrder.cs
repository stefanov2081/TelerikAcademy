using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SortArrayInIncreasingOrder
{
    class SortArrayInIncreasingOrder
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

            // For every element that is smaller than the selected, swap them
            int swapVal;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] <= array[i])
                    {
                        swapVal = array[i];
                        array[i] = array[j];
                        array[j] = swapVal;
                    }
                }
            }

            // Print
            Console.WriteLine("Sorted in increasing order:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
