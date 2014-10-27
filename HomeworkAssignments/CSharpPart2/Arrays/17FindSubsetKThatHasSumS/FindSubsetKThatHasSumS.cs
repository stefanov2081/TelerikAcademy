using System;

namespace _17FindSubsetKThatHasSumS
{
    class FindSubsetKThatHasSumS
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int numberOfIntegers = int.Parse(Console.ReadLine());
            int[] setOfIntegers = new int[numberOfIntegers];
            bool isSubsetFound = false;

            for (int number = 0; number < numberOfIntegers; number++)
            {
                Console.WriteLine("Enter array element[{0}]", number);
                setOfIntegers[number] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What is the sum that you want to search the array for?");
            int sum = int.Parse(Console.ReadLine());
            int originalSum = sum;

            Console.WriteLine("How big is the subset that has sum of " + sum);
            int k = int.Parse(Console.ReadLine());
            int counter = 0;

            // Iterate all subsets
            for (int subsets = 1; subsets <= (1 << numberOfIntegers) - 1; subsets++)
            {
                sum = 0;
                counter = 0;
                for (int bit = 0; bit < numberOfIntegers; bit++)
                {
                    if (0 != (subsets & (1 << bit)))
                    {
                        sum += setOfIntegers[bit];
                        counter++;
                    }
                }
                if (sum == originalSum && (counter == k))
                {
                    // Break - we found a subset whose sum is equal to sum
                    isSubsetFound = true;
                    Console.WriteLine("There is a subset that has a sum of {0}.", sum);
                    for (int bit = 0; bit < numberOfIntegers; bit++)
                    {
                        if (0 != (subsets & (1 << bit)))
                        {
                            // Print subset
                            Console.WriteLine("Element {0} with value {1}", bit, setOfIntegers[bit]);
                        }
                    }
                }
            }
            if (isSubsetFound == false)
            {
                Console.WriteLine("There is no subset with sum equal to " + originalSum);
            }
        }
    }
}
