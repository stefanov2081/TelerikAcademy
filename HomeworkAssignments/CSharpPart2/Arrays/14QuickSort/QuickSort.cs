using System;

namespace _14QuickSort
{
    class QuickSort
    {
        // Sort the array
        public static void QuickSortArr(int[] elements, int left, int right)
        {
            // Find pivot
            int i = left, j = right;
            int pivot = elements[left + (right - left) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSortArr(elements, left, j);
            }

            if (i < right)
            {
                QuickSortArr(elements, i, right);
            }
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());
            int[] sortedArray = new int[n];

            int[] unsortedArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element[{0}]", i);
                unsortedArray[i] = int.Parse(Console.ReadLine());
            }

            // Call the sorting function
            QuickSortArr(unsortedArray, 0, unsortedArray.Length - 1);
            
            // Print
            Console.WriteLine("Sorted, the array looks like this:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(unsortedArray[i]);
            }
        }
    }
}
