using System;

namespace _06FirstIndexOfGreaterThanNeigb
{
    class FirstIndexOfGreaterThanNeigb
    {
        static int GreaterThanNeighbours(int[] arr, int index)
        {
            bool isGreater = false;
            // Check if the index is not greater or smaller than the array
            if (index > arr.Length - 1)
            {
                return 0;
            }
            else if (index < 0)
            {
                return 0;
            }
            // Check if index is not greater or smaller than the array
            if (index > arr.Length - 1)
            {
                return 0;
            }
            else if (index < 0)
            {
                return 0;
            }
            // Check if the array has at least 3 elements
            if (arr.Length > 2)
            {
                // Check if the index of the element isn't 0 or the last one in the array
                if (index > 0 && index <= arr.Length - 2)
                {
                    // Check if the element is larger than it's neighbours
                    if ((arr[index] > arr[index - 1]) && (arr[index] > arr[index + 1]))
                    {
                        isGreater = true;
                    }
                }
            }
            if (isGreater)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        static int FirstIndexOf(int[] arr)
        {
            // Loop through the array, call GreaterThanNeighbours and return the index of the first element
            // that is greater than it's neighbour, or if no such element exists return -1
            for (int i = 1; i < arr.Length; i++)
            {
                if (GreaterThanNeighbours(arr, i) == 1)
                {
                    return i;
                }
            }
            return -1;
        }

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

            Console.WriteLine("The first element that is greater than it's neighbours has an index of {0}" +
                "\n(-1 if no such element exists)",FirstIndexOf(array));
        }
    }
}
