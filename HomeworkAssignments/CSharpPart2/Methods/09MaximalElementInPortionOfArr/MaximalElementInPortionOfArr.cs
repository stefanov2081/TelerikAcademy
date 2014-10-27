using System;

namespace _09MaximalElementInPortionOfArr
{
    class MaximalElementInPortionOfArr
    {
        // Find max element
        static int MaxElementInPortion(int[] arr, int index)
        {
            int maxEl = arr[index];
            int maxElIndex = index;
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] > maxEl)
                {
                    maxEl = arr[i];
                    maxElIndex = i;
                }
            }
            return maxElIndex;
        }

        // Create subarray
        static int[] SubArray(int[] arr, int index)
        {
            int[] temp = new int[arr.Length - index];
            for (int i = 0; i < arr.Length - index; i++)
            {
                temp[i] = arr[i + index];
            }
            return temp;
        }

        // Sort array in ascending order
        static void SortInAsc(int[] arr)
        {
            int swapVal;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] <= arr[i])
                    {
                        swapVal = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swapVal;
                    }
                }
            }
        }

        // Sort array in descending order
        static void SortInDesc(int[] arr)
        {
            int swapVal;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        swapVal = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swapVal;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element[{0}]", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            string input = "";
            int ind = -1;
            while (ind >= array.Length || ind < 0)
            {
                Console.WriteLine("You can see which is the largest element in a portion of the array.");
                Console.WriteLine("Enter starting index:");
                ind = int.Parse(Console.ReadLine());
                if (ind >= array.Length || ind < 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    Console.WriteLine("Largest element is " + array[MaxElementInPortion(array, ind)] + " with index " + MaxElementInPortion(array, ind));
                }
            }
            Console.WriteLine("You can now sort the new subarray either in ascending or descending order.");
            Console.WriteLine("To sort it in ascending order type: asc");
            Console.WriteLine("To sort it in descending order type: dsc");
            Console.WriteLine("To exit type: exit");
            while (input != "exit")
            {
                int[] subArr;
                Console.Write("Input:");
                input = Console.ReadLine();
                if (input == "asc")
                {
                    subArr = SubArray(array, ind);
                    SortInAsc(subArr);
                    Console.WriteLine("Sortet in ascending order:");
                    foreach (var item in subArr)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                if (input == "dsc")
                {
                    subArr = SubArray(array, ind);
                    SortInDesc(subArr);
                    Console.WriteLine("Sorted in ascending order:");
                    foreach (var item in subArr)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}
