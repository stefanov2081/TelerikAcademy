using System;

namespace _04HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        // Hexadecimal to decimal
        static int HexToDecimal(string n)
        {
            char[] hexaNums = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            n = n.TrimStart('0');
            n = n.TrimStart('x');
            n = n.ToUpper();
            char[] numToChar = n.ToCharArray();
            int multiplier = 1;
            int result = 0;
            int currentNum;

            // Get decimal number
            for (int i = n.Length - 1; i >= 0; i--)
            {
                currentNum = Array.IndexOf(hexaNums, numToChar[i]);
                result += currentNum * multiplier;
                multiplier = multiplier << 4;
            }
            
            return result;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("* Note: If you want to input negative numbers, use two's complement!" + 
                "\nExample: -123(dec) = 0xFFFFFF85");
            Console.Write("Enter hex number:");
            string number = Console.ReadLine();
            Console.WriteLine(number + " in decimal looks like this: ");

            // Call HexToDecimal() and print
            Console.WriteLine(HexToDecimal(number));
        }
    }
}
