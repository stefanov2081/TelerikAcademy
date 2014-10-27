using System;

namespace _05IsNGreaterThanTwoNeighbours
{
    class IsNGreaterThanTwoNeighbours
    {
        static void GreaterThanNeighbours(int[] arr, int index)
        {
            // Check if the index is not greater or smaller than the array
            if (index > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            else if (index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
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
                        Console.WriteLine("{0} is greater than {1} and {2}!", arr[index], arr[index - 1], arr[index + 1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not greater than {1} and {2}!", arr[index], arr[index - 1], arr[index + 1]);
                    }
                }
            }
            else
            {
                Console.WriteLine("The element must have neighbouring element from each side!");
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
                Console.WriteLine("Enter array element[{0}]", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Which element do you want to see if it is greater than it's neighbours?");
            Console.Write("Enter index:");
            int index = int.Parse(Console.ReadLine());
            GreaterThanNeighbours(array, index);
        }
    }
}
