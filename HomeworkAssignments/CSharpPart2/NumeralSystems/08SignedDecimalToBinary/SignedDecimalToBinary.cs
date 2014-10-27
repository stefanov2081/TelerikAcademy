using System;

namespace _08SignedDecimalToBinary
{
    class SignedDecimalToBinary
    {
        // Decimal number to binary
        static string ToBinary(int a)
        {

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

            // Convert from string to int
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

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter decimal nubmber to see it in binary: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " in binary looks like this:");

            // Call TwosComplement() <- OnesComplement() <- ToBinary() and print
            Console.WriteLine(TwosComplement(OnesComplement(ToBinary(n))));
        }
    }
}
