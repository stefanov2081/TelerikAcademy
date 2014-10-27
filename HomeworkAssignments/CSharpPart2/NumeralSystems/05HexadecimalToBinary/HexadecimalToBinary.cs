using System;

namespace _05HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        // Hexadecimal to binary
        static string HexToBinary(string n)
        {
            char[] hexaNums = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            n = n.TrimStart('0');
            n = n.TrimStart('x');
            n = n.ToUpper();
            char[] numToChar = n.ToCharArray();
            string result = "";
            int currentNum;
            
            // Get binary number
            for (int i = n.Length - 1; i >= 0; i--)
            {
                currentNum = Array.IndexOf(hexaNums, numToChar[i]);
                for (int j = 0; j < 4; j++)
                {
                    result = currentNum % 2 + result;
                    currentNum /= 2;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("* Note: If you want to input negative numbers, use two's complement!" +
                "\nExample: -123(dec) = 0xFFFFFF85");
            Console.Write("Enter hexadecimal number: ");
            string number = Console.ReadLine();
            Console.WriteLine(number + " in binary looks like this:");

            // Call HexToBinary() and print
            Console.WriteLine(HexToBinary(number));
        }
    }
}
