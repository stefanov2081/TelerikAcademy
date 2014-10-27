using System;
using System.Text;

namespace _23ReadAString
{
    class RplcConsecIdentLetters
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter string with consecutive identical letters: ");
            string text = Console.ReadLine();

            // Declare new StringBuilder object
            StringBuilder sb = new StringBuilder();

            // Loop through the string, if there are repeating consecutive letters => Append() just one
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0 && text[i] != text[i - 1])
                {
                    sb.Append(text[i]);
                }
                else if (i == 0 && text[i] == text[i + 1])
                {
                    sb.Append(text[i]);
                }
            }
            
            // Print
            Console.WriteLine(sb.ToString());
        }
    }
}
