using System;

namespace _13MergeSort
{
    class MergeSort
    {
        // Split the array
        static int[] Splits(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[arr.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i];
            }
            for (int i = middle, j = 0; i < arr.Length; i++, j++)
            {
                rightArr[j] = arr[i];
            }

            leftArr = Splits(leftArr);
            rightArr = Splits(rightArr);

            return Merge(leftArr, rightArr);
        }

        // Merge and sort the array
        static int[] Merge(int[] left, int[] right)
        {
            int leftIncrease = 0;
            int rightIncrease = 0;
            int[] arr = new int[left.Length + right.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (rightIncrease == right.Length || 
                    ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
                {
                    arr[i] = left[leftIncrease];
                    leftIncrease++; 
                }
                else if (leftIncrease == left.Length || 
                    ((rightIncrease < right.Length) && (left[leftIncrease] >= right[rightIncrease])))
                {
                    arr[i] = right[rightIncrease];
                    rightIncrease++;
                }
            }
            return arr;
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
            sortedArray = Splits(unsortedArray);

            // Print
            Console.WriteLine("Sorted, the array looks like this:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }
        }
    }
}
