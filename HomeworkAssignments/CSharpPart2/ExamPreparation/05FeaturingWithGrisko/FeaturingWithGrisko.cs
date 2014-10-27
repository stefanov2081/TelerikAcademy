using System;

namespace _05FeaturingWithGrisko
{
    class FeaturingWithGrisko
    {
        // Check if the given permutation meets the requirements
        static bool IsMatch(char[] word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        // Get next permutation
        static bool NextPermutation(char[] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                // If the current element is smaller than the next one => swapWithIndex = last element
                if (array[index] < array[index + 1])
                {
                    int swapWithIndex = array.Length - 1;

                    // If the last element is smaller than the current one => decrement swapWithIndex
                    while (array[index] >= array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    // Swap current element with one that is smaller than it
                    char temp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = temp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputAsCharArray = input.ToCharArray();
            Array.Sort(inputAsCharArray);

            // Call next permutation while there are permutations left, and count matches
            int count = 0;
            do
            {
                if (IsMatch(inputAsCharArray))
                {
                    count++;
                }
            }
            while (NextPermutation(inputAsCharArray));
            Console.WriteLine(count);
        }
    }
}
