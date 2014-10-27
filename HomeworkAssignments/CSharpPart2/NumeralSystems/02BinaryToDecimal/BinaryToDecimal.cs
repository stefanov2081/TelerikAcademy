using System;

namespace _02BinaryToDecimal
{
    class BinaryToDecimal
    {
        // Binary number to decimal
        static int ToDecimal(string n)
        {
            int result = 0;
            int multiplier = 1;
            char[] binNum = n.ToCharArray();

            // Get decimal number
            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                result += (binNum[i] - 48) * multiplier;
                multiplier = multiplier << 1;
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter binary number: ");
            string number = Console.ReadLine();
            Console.WriteLine(number + " in decimal looks like this:");

            // Call ToDecimal() and print
            Console.WriteLine(ToDecimal(number));
        }
    }
}
