using System;

namespace _04BinSearchKInSortedArray
{
    class BinSearchKInSortedArray
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element[{0}]", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter k, the value whose index you want to see:");
            int k = int.Parse(Console.ReadLine());

            // Sort array
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        int swapVall;
                        swapVall = array[i];
                        array[i] = array[j];
                        array[j] = swapVall;
                    }
                }
            }

            // Binary search for k
            int originalK = k;
            int index = Array.BinarySearch(array, k);
            // If k is equal to element in the array
            if (index >= 0)
            {
                Console.WriteLine("{0} has index {1}", k, index);
            }
            // If k is not equal to element in the array find one that is smaller than k
            else
            {
                while (index < 0)
                {
                    k--;
                    index = Array.BinarySearch(array, k);
                    // If no such element is found break
                    if (k == int.MinValue)
                    {
                        Console.WriteLine("There is no element smaller than " + originalK);
                        break;
                    }
                }
                Console.WriteLine("The closest element to {0}, less than or equal to {0} is {1} with index {2}", originalK, k, index);
            }
        }
    }
}
