using System;

namespace _12PrintIndexOfEachLetterInAWord
{
    class PrintIndexOfEachLetterInAWord
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();

            string wordToLower = word.ToLower();
            char[] wordToCharArr = wordToLower.ToCharArray();
            char[] letter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string result = "";

            // Find the index of each letter and print it
            for (int i = 0; i < wordToCharArr.Length; i++)
            {
                for (int ii = 0; ii < letter.Length; ii++)
                {
                    if (wordToCharArr[i] == letter[ii])
                    {
                        if ((i > 0) && (i % 3 == 0))
                        {
                            result += "\n";
                        }
                        result += "\"" + letter[ii] + "\"" + " has an index: " + ii;
                        if (i < wordToCharArr.Length - 1)
                        {
                            result += ", ";
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
