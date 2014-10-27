using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _014BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            uint numbers;
            string nToBinaryString;
            BigInteger nToBinaryBigInt;
            BigInteger remainder;
            int countZeros = 0;
            int countOnes = 0;

            for (int i = 0; i < n; i++)
            {
                numbers = uint.Parse(Console.ReadLine());
                nToBinaryString = Convert.ToString(numbers, 2);
                nToBinaryBigInt = BigInteger.Parse(nToBinaryString);
                
                while (nToBinaryBigInt != 0)
                {
                    if (b == 0)
                    {
                        remainder = nToBinaryBigInt % 10;
                        nToBinaryBigInt = nToBinaryBigInt / 10;
                        if (remainder == 0)
                        {
                            countZeros++;
                        }
                    }
                    else if (b == 1)
                    {
                        remainder = nToBinaryBigInt % 10;
                        nToBinaryBigInt = nToBinaryBigInt / 10;
                        if (remainder == 1)
                        {
                            countOnes++;
                        }
                    }
                }
                if (b == 0)
                {
                    Console.WriteLine(countZeros);
                }
                else if (b == 1)
                {
                    Console.WriteLine(countOnes);
                }
                countZeros = 0;
                countOnes = 0;
            }

        }
    }
}
