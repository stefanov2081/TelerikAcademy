using System;

namespace _09ReplaceInString
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            // Predefined input
            string text = "Microsoft announced its next generation PHP compiler today." + 
                " It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };

            // Censor forbidden words
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                string censor = new string('*', forbiddenWords[i].Length);
                text = text.Replace(forbiddenWords[i], censor);
            }
            
            // Print
            Console.WriteLine(text);
        }
    }
}
