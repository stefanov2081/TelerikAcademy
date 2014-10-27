﻿using System;
using System.Text.RegularExpressions;

namespace _18ExtractFromText
{
    class ExtractEmails
    {
        // Validate e-mail... Courtesy of Thunder@stackoverflow.com
        const string MatchEmailPattern =
       @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
       + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
         + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
       + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter e-mail: ");
            string text = Console.ReadLine();

            // Use regular expression to find matches
            Regex regEx = new Regex(MatchEmailPattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            
            // Find matches.
            MatchCollection emails = regEx.Matches(text);
            
            // Print
            if (emails.Count > 0)
            {
                Console.WriteLine("There is/are " + emails.Count + " e-mail/s:");
                for (int i = 0; i < emails.Count; i++)
                {
                    Console.WriteLine(emails[i]);
                }
            }
            else
            {
                Console.WriteLine("Unable to find any e-mail.");
            }
        }
    }
}
