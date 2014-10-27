using System;

namespace _13ReverseSentence
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            // Predefined value
            string text = "C# is not C++, not PHP and not Delphi!";

            // Get punctoation mark and comma
            string punctuationMark = text.Substring(text.Length - 1);
            int indexOfComma = text.IndexOf(',');

            // Get each word into array
            string[] textToArr = text.Split(' ', ',', '!');
            string result = "";

            

            // Print in reversed order
            for (int i = textToArr.Length - 1; i >= 0; i--)
            {
                if (textToArr[i] != "")
                {
                    if (i != 0)
                    {
                        result += textToArr[i] + " ";
                    }
                    else
                    {
                        result += textToArr[i];
                    }
                }
            }
            result = result.Insert(indexOfComma + 1, ",");
            Console.WriteLine(result + punctuationMark);
        }
    }
}
