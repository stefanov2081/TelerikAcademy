using System;

namespace _11FindIndexOfNBinarySearch
{
    class FindIndexOfNBinarySearch
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

            Console.WriteLine("For what value would you like to see the index?");
            int key = int.Parse(Console.ReadLine());

            // Sort the array
            Array.Sort(array);

            // Print the sorted array
            Console.WriteLine("Sorted, the array looks like this:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Array element[{0}] is {1}", i, array[i]);
            }
            Console.WriteLine();

            // Find the index of the element that is being searched
            int min;
            min = 0;
            int max;
            max = n - 1;

            int index = -1;
            int mid;

            while (max >= min)
            {
                mid = (min + max) / 2;
                if (array[mid] == key)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < key)
                {
                    min = mid + 1;
                }
                else if (array[mid] > key)
                {
                    max = mid - 1;
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Nothing found");
            }
            else
            {
                Console.WriteLine("The index of {0} is {1}", key, index);
            }
        }
    }
}
