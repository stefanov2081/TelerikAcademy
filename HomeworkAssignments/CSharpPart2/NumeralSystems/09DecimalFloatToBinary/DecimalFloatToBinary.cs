using System;
using System.Text;

namespace _09DecimalFloatToBinary
{
    class DecimalFloatToBinary
    {
        // Floating point decimal to int64
        static long DoubleToInt(double n)
        {
            long floatToInt64 = BitConverter.DoubleToInt64Bits(n);
            return floatToInt64;
        }

        // Decimal number to binary
        static string ToBinary(long a)
        {

            long remainder;
            string binaryNum = "";
            long[] binary = new long[64];

            // Check for negative numbers
            if (a < 0)
            {
                a = a * -1;
                binary[63] = 1;
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
            long[] binary = new long[64];
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
            long[] binaryToIntArr = new long[64];
            char[] binaryToChar = n.ToCharArray();
            int remainder = 1;
            string binary = "";

            // Convert string to int
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
            Console.Write("Enter floating point number: ");
            double number = double.Parse(Console.ReadLine());

            // Call TwosComplement() <- OnesComplement() <- ToBinary() <- DoubleToInt and print
            Console.Write(number + "\nin binary: ");
            Console.WriteLine(TwosComplement(OnesComplement(ToBinary(DoubleToInt(number)))));
            Console.Write("       sign|| exponent||                                          mantissa|");
            Console.WriteLine();
            Console.WriteLine();

            // Call TwosComplement() <- OnesComplement() <- ToBinary() <- DoubleToInt and print
            char[] binNum = TwosComplement(OnesComplement(ToBinary(DoubleToInt(number)))).ToCharArray();
            Console.WriteLine("sign     = " + binNum[0]);
            Console.Write("exponent = ");
            for (int i = 1; i < 12; i++)
            {
                Console.Write(binNum[i]);
            }

             // Print
            Console.WriteLine();
            Console.Write("mantissa = ");
            for (int i = 12; i < 64; i++)
            {
                Console.Write(binNum[i]);
            }
            Console.WriteLine();
        }
    }
}
