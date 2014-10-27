using System;

namespace _06ReadAString
{
    class LessThan20Chars
    {
        static void Main(string[] args)
        {
            try
            {
                // Get value from user input
                Console.Write("Enter string with less than 20 characters: ");
                string input = Console.ReadLine();

                // Evaluate input
                if (input.Length > 20 || input.Length < 0)
                {
                    throw new ArgumentException("String lenght must be 0 < string <= 20 characters!");
                }
                // Append *
                else
                {
                    input += new string('*', 20 - input.Length);
                }

                // Print result
                Console.WriteLine(input);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}
