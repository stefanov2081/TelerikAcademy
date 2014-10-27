using System;
using System.Collections.Generic;
using System.IO;

namespace _10ExtractFromFile
{
    class WordsWithoutTags
    {
        static string ExtractText(string line)
        {
            // Get word between opening and closing XML tag and length of word
            int indexOfClosingArrowHead = line.IndexOf(">") + 1;
            int indexOfOppenningArrowHead = line.LastIndexOf("<");
            int lengthOfWord = indexOfOppenningArrowHead - indexOfClosingArrowHead;

            // If there is no closing tag on the same line => lengthOfWord < 0
            if (lengthOfWord > 0)
            {
                line = line.Substring(indexOfClosingArrowHead, lengthOfWord);
                return line;
            }
            else
            {
                return string.Empty;
            }
        }

        static void Main(string[] args)
        {
            // Filepath
            string filepath = @"..\..\..\note.xml";
            string line;

            // Read file
            using (StreamReader reader = new StreamReader(filepath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    // Call ExtractText() and print
                    Console.WriteLine(ExtractText(line));
                }
            }
        }
    }
}
