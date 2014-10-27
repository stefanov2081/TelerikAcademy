using System;
using System.Collections.Generic;

namespace _22ReadAString
{
    class ExtractAllWords
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter string to count each word: ");
            string text = Console.ReadLine();

            // Split() each word to textToArr
            string[] textToArr = text.Split();

            // Decalte new List<string> object
            List<string> textList = new List<string>();

            // Put all unique words in the textList
            for (int i = 0; i < textToArr.Length; i++)
            {
                if (!textList.Contains(textToArr[i]))
                {
                textList.Add(textToArr[i]);
                }
            }

            // Trim() excess length of textList and declare int[] occurrence
            textList.TrimExcess();
            int[] occurrence = new int[textList.Count];

            // Count each word
            for (int i = 0; i < occurrence.Length; i++)
            {
                for (int j = 0; j < textToArr.Length; j++)
                {
                    if (textList[i] == textToArr[j])
                    {
                        occurrence[i]++;
                    }
                }

                // Print
                Console.WriteLine(textList[i] + " occurs " + occurrence[i] + " times.");
            }
        }
    }
}
