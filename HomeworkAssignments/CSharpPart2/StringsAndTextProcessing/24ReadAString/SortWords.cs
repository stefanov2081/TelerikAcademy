using System;

namespace _24ReadAString
{
    class SortWords
    {
        static void Main(string[] args)
        {
            // Get value from user input
            string text = Console.ReadLine();

            // Split() text to words
            string[] textToArr = text.Split();

            // Sort() the array
            Array.Sort(textToArr);

            // Print
            for (int i = 0; i < textToArr.Length; i++)
            {
                Console.WriteLine(textToArr[i]);
            }
        }
    }
}
