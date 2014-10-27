using System;

namespace _04CountOccurrence
{
    class SubstringOccurrence
    {
        static void Main(string[] args)
        {
            // Predefined input
            string text = "We are living in an yellow submarine. We don't have anything else." +
                " Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            // Make all the text lowercase for case insensitive search
            string textToLower = text.ToLower();

            string searchedSubStr = "in";
            int counter = 0;
            int index = 0;

            // Count occurrences of "in"
            while (true)
            {
                index = textToLower.IndexOf(searchedSubStr, index + 1);
                if (index == -1)
                {
                    break;
                }
                counter++;
            }

            Console.WriteLine("In the given text: " + text);
            Console.WriteLine("\"" + searchedSubStr + "\"" + " occurs " + counter + " times.");
        }
    }
}
