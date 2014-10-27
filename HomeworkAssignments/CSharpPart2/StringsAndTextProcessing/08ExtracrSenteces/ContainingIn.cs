using System;
using System.Text.RegularExpressions;

namespace _08ExtracrSenteces
{
    class ContainingIn
    {
        static void Main(string[] args)
        {
            // Predefined input
            string text = "We are living in a yellow submarine. We don't have anything else. " + 
                "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            
            // Split text into sentences into array
            string[] textToArr = text.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

            // Remove whitespace and append fullstop to each sentence
            for (int i = 0; i < textToArr.Length; i++)
            {
                textToArr[i] = textToArr[i].TrimStart(' ');
                textToArr[i] = textToArr[i] + ".";
            }

            // Find keyword in sentence using RegularExpression
            string keyword = @"\bin\b";
            string result = string.Empty;
            for (int i = 0; i < textToArr.Length; i++)
            {
                bool isFound = Regex.IsMatch(textToArr[i], keyword);
                if (isFound)
                {
                    result += textToArr[i] + "\n";
                    isFound = false;
                }
            }

            // Print
            Console.WriteLine(result);
        }
    }
}
