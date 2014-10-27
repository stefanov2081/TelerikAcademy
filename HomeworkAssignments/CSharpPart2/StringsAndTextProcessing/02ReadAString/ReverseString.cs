using System;

namespace _02ReadAString
{
    class ReverseString
    {
        // Reverse string
        static string Reverse(string inp)
        {
            string reversed = string.Empty;

            // Read the string from end and concat it to result
            for (int i = inp.Length - 1; i >= 0; i--)
            {
                reversed += inp[i];
            }

            return reversed;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            
            // Call Reverse()
            string reversedInput = Reverse(input);

            // Print
            Console.WriteLine(input + " reversed = " + reversedInput);
        }
    }
}
