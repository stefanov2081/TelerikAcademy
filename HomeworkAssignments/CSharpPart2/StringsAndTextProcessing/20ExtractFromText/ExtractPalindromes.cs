using System;
using System.Text;

namespace _20ExtractFromText
{
    class ExtractPalindromes
    {
        // Reverse string
        static string Reverse(string inp)
        {
            string reversed = string.Empty;

            // Read the string from end and concat it to result
            for (int i = inp.Length - 1; i >= 0; i--)
            {
                reversed += inp[i];
            }

            return reversed;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter text to check for palindromes: ");
            string text = Console.ReadLine();

            // Split the text into array
            string[] textToArr = text.Split();

            // Declare new StringBuilder object
            StringBuilder sb = new StringBuilder();

            // Loop through array to find palindromes
            for (int i = 0; i < textToArr.Length; i++)
            {
                // Reverse each word
                string currentWordReversed = Reverse(textToArr[i]);

                // If the reversed word is the same => Append to sb
                if (currentWordReversed == textToArr[i])
                {
                    sb.Append(textToArr[i] + " ");
                }
            }

            // Get the words from sb
            string palindromes = sb.ToString();

            // If palindromes length is greater than zero, else there were no palindromes
            if (palindromes.Length > 0)
            {
                Console.WriteLine("Palindromes: " + palindromes);
            }
            else
            {
                Console.WriteLine("There are no palindromes!");
            }
        }
    }
}
