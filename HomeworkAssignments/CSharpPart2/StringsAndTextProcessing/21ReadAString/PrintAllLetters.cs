using System;
using System.Text.RegularExpressions;

namespace _21ReadAString
{
    class PrintAllLetters
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter string to count each letter: ");
            string text = Console.ReadLine();

            // Use regular expression to find matches
            Regex regex = new Regex("[a-zA-Z]");

            // Find matches
            MatchCollection letters = regex.Matches(text);

            // Declare char[] with english alphabet and and int[] to count occurrence
            char[] englishAlphabet = new char[52];
            int[] occurrence = new int[52];

            // This integer will assign each letter of the alphabet in ASCII
            int assignValue = 65;

            // Loop through to assign each letter in the alphabet
            // for I am too lazy to write it down manually
            for (int i = 0; i < englishAlphabet.Length; i++)
            {
                englishAlphabet[i] = (char)assignValue;
                assignValue++;
                if (assignValue == 91)
                {
                    assignValue = 97;
                }
            }

            // Compare each letter in the text with the english alphabet and count occurrences
            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < englishAlphabet.Length; j++)
                {
                    // If I weren't that lazy I could eliminate .ToString()...
                    if (letters[i].ToString() == englishAlphabet[j].ToString())
                    {
                        occurrence[j]++;
                    }
                }
            }

            // Print result
            for (int i = 0; i < occurrence.Length; i++)
            {
                if (occurrence[i] > 0)
                {
                    Console.WriteLine(englishAlphabet[i] + " occures " + occurrence[i] + " times.");
                }
            }
        }
    }
}
