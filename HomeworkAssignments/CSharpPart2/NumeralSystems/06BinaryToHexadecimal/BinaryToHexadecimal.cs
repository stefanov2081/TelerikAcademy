using System;
using System.Numerics;

namespace _06BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        // Binary to hexadecimal
        static string BinToHex(string n)
        {
            char[] hexaNums = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int multiplier = 1;
            string result = "";
            BigInteger binNum = BigInteger.Parse(n);
            int remainder;
            int temp = 0;

            // Get hexadecimal number
            for (int i = n.Length - 1; i >= 0; i-=4)
            {
                multiplier = 1;
                temp = 0;
                for (int j = 0; j < 4; j++)
                {
                    remainder = (int)(binNum % 10);
                    binNum /= 10;
                    temp += remainder * multiplier;
                    multiplier = multiplier << 1;
                }

                result = hexaNums[temp] + result;
            }

            result = result.TrimStart('0');
            return result;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter binary number: ");
            string number = Console.ReadLine();
            Console.WriteLine(number + " in hexadecimal looks like this:");

            // Call BinToHex() and print
            Console.WriteLine(BinToHex(number));
        }
    }
}
