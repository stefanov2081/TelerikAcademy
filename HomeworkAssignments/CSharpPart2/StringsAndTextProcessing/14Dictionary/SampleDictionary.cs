using System;
using System.Globalization;

namespace _14Dictionary
{
    class SampleDictionary
    {
        static void Main(string[] args)
        {
            // Predefined entries
            Console.WriteLine("Sample dictionary. It contains just three entries: .NET, CLR, namespace");
            string[] dictionary = 
            { ".NET – platform for applications from Microsoft", 
                "CLR – managed execution environment for .NET", 
                "namespace – hierarchical organization of classes" };

            // Get value from user input
            Console.Write("Enter term to search the dictionary:");
            string input = Console.ReadLine();

            bool found = false;

            // Search the dictionary for given entry
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i].Length >= input.Length)
                {
                    if (dictionary[i].IndexOf(input, 0, input.Length, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        Console.WriteLine(dictionary[i]);
                        found = true;
                    }
                }

            }
            // If nothing found => no entry
            if (found == false)
            {
                Console.WriteLine("There is no entry in the dictionary for " + input);
            }

        }
    }
}
