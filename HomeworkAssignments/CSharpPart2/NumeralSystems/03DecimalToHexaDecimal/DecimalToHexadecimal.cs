using System;
using _01DecimalToBinary;

namespace _03DecimalToHexaDecimal
{
    class DecimalToHexadecimal
    {
        // Decimal to hexadecimal
        static string ToHexadecimal(int n)
        {
            int remainder;
            string hex = "";
            string[] hexaNums = 
            { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int originalN = n;

            // Check for negative numbers
            if (n < 0)
            {
                n *= -1;
            }

            // Get hexadecimal number
            while (n != 0)
            {
                remainder = n % 16;
                n /= 16;
                hex = hexaNums[remainder] + hex;
            }

            if (originalN < 0)
            {
                hex = "-" + hex;
            }

            return hex;
        }

        // Decimal number to binary
        static string ToBinary(int a)
        {
            int originalA = a;
            int remainder;
            string binaryNum = "";
            int[] binary = new int[32];

            // Check for negative numbers
            if (a < 0)
            {
                a = a * -1;
                binary[31] = 1;
            }

            // Get binary number
            while (a != 0)
            {
                remainder = a % 2;
                a = a / 2;
                binaryNum = remainder.ToString() + binaryNum;
            }

            // Convert string to int and append leading zeros
            char[] array = binaryNum.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                binary[array.Length - 1 - i] = array[i] - 48;
            }

            // Convert back to string to preserve leading zeros
            binaryNum = "";
            for (int i = 0; i < binary.Length; i++)
            {
                binaryNum = binary[i].ToString() + binaryNum;
            }

            return binaryNum;
        }

        // Using One's Complement
        static string OnesComplement(string n)
        {
            char[] binaryToChar = n.ToCharArray();
            int[] binary = new int[32];
            string binaryToStr = "";

            // Get the binary string to int
            for (int i = 0; i < binaryToChar.Length; i++)
            {
                binary[i] = binaryToChar[i] - 48;

                // Reverse all the bits except MSB
                if (i > 0)
                {
                    if (binary[i] == 0)
                    {
                        binary[i] = 1;
                    }
                    else
                    {
                        binary[i] = 0;
                    }
                }

                binaryToStr += binary[i].ToString();
            }

            return binaryToStr;

        }

        // Using two's complement
        static string TwosComplement(string n)
        {
            int[] binaryToIntArr = new int[32];
            char[] binaryToChar = n.ToCharArray();
            int remainder = 1;
            string binary = "";

            // Get binary string to int
            for (int i = 0; i < binaryToChar.Length; i++)
            {
                binaryToIntArr[i] = binaryToChar[i] - 48;
            }

            // Add one to binary number
            for (int i = binaryToIntArr.Length - 1; i >= 0; i--)
            {
                if (i == binaryToIntArr.Length - 1 || remainder > 0)
                {
                    binaryToIntArr[i] += remainder;
                    if (binaryToIntArr[i] > 1)
                    {
                        binaryToIntArr[i] = 0;
                        remainder = 1;
                    }
                    else
                    {
                        remainder = 0;
                    }
                }

                binary = binaryToIntArr[i].ToString() + binary;
            }

            return binary;
        }

        static string ToHexaDecimalFromBinary(int n)
        {
            // Conver binary string to char array
            string[] hexaNums = 
            { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string binNum = TwosComplement(OnesComplement(ToBinary(n))).ToString();
            char[] binNumToCharArr = binNum.ToCharArray();
            int multiplier = 1;
            int result;
            string toHex = "";

            // Get hexadecimal number
            for (int i = binNumToCharArr.Length - 1; i >= 0; i -= 4)
            {
                result = 0;
                multiplier = 1;
                for (int j = 0; j < 4; j++)
                {
                    result += (binNumToCharArr[i - j] - 48) * multiplier;
                    multiplier = multiplier << 1;
                }
                if (result > 0)
                {
                    toHex = hexaNums[result] + toHex;
                }
            }

            return toHex;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter decimal number:");
            int number = int.Parse(Console.ReadLine());
            
            if (number >= 0)
            {
                Console.WriteLine(number + " in hexadecimal looks like this:");
                
                // Call ToHexadecimal() and print
                Console.WriteLine(ToHexadecimal(number));
            }
            else
            {
                Console.WriteLine("For negative numbers conversion is made from binary using two's complement.");
                Console.WriteLine(number + " in hexadecimal looks like this:");

                // Call ToHexaDecimalFromBinary() and print
                Console.WriteLine(ToHexaDecimalFromBinary(number));
            }

        }
    }
}
