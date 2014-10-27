using System;

namespace _05SortStringArrayByLength
{
    class SortStringArrayByLength
    {
        static void Sort(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].Length <= a[i].Length)
                    {
                        string swapVal;
                        swapVal = a[i];
                        a[i] = a[j];
                        a[j] = swapVal;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter string array element[{0}]", i);
                array[i] = Console.ReadLine();
            }

            Sort(array);

            Console.WriteLine("Sorted, the array looks like this:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
