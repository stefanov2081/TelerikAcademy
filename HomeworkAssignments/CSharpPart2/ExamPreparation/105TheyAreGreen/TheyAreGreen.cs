using System;

namespace _105TheyAreGreen
{
    class TheyAreGreen
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
            int n = int.Parse(Console.ReadLine());

            char[] letters = new char[n];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = char.Parse(Console.ReadLine());
            }

            Array.Sort(letters);

            // Call next permutation while there are permutations left, and count matches
            int count = 0;
            do
            {
                if (IsMatch(letters))
                {
                    count++;
                }
            }
            while (NextPermutation(letters));
            Console.WriteLine(count);
        }
    }
}
