using System;
using System.Collections.Generic;
namespace _05ChangeText
{
    class BetweenTags
    {
        // Change from lower to upper case
        static string ChangeCase(string line)
        {
            int indexOfOpeningTag = 0;
            int indexOfClosingTag = 0;
            int lengthOfWord;
            string wordToReplace;

            while (true)
            {
                // Get words between opening and closing tag and length of words
                indexOfOpeningTag = line.IndexOf("<upcase>", indexOfOpeningTag) + 8;
                if (indexOfOpeningTag != -1)
                {
                    indexOfClosingTag = line.IndexOf("</upcase>", indexOfOpeningTag);
                }
                lengthOfWord = indexOfClosingTag - indexOfOpeningTag;

                // If there are no more opening tags => indexOfOpeningTag = -1
                if (indexOfOpeningTag - 8 == -1)
                {
                    break;
                }

                // If there is no closing tag => lengthOfWord < 0
                if (lengthOfWord > 0)
                {
                    wordToReplace = line.Substring(indexOfOpeningTag, lengthOfWord);
                    line = line.Replace(wordToReplace, wordToReplace.ToUpper());
                }
            }

            return line;
        }

        static void Main(string[] args)
        {
            // Predefined input
            string text = "We are living in a <upcase>yellow submarine</upcase>." + " We don't have <upcase>anything</upcase> else.";

            // Call ChangeCase()
            text = (ChangeCase(text));

            // Remove opening and closing tags
            text = text.Replace("<upcase>", "");
            text = text.Replace("</upcase>", "");

            // Print
            Console.WriteLine(text);
        }
    }
}
