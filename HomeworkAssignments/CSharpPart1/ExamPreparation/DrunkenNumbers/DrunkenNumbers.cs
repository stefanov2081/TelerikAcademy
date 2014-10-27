using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            // Get values from user input. Get length for all members of the array.
            int rounds = int.Parse(Console.ReadLine());
            int[] dNInt = new int[rounds];
            int[] length = new int[rounds];
            int num;

            for (int i = 0; i < rounds; i++)
            {
                dNInt[i] = int.Parse(Console.ReadLine());
                length[i] = 0;
                if (dNInt[i] < 0)
                {
                    dNInt[i] *= -1;
                }
                num = dNInt[i];
                while (num != 0)
                {
                    num = num / 10;
                    length[i]++;
                }
            }




            int sumV = 0;
            int sumM = 0;
            int remainder;
            int beersLeftToSum;

            // 
            for (int i = 0; i < rounds; i++)
            {
                // Find if a member of the array is even.
                if (length[i] % 2 == 0)
                {
                    beersLeftToSum = dNInt[i];  // Give the value of the current member of the array.
                    // Sum the numbers in the right-hand side, a.k.a Vladko's beers.
                    for (int j = 0; j < length[i] / 2; j++)
                    {
                        remainder = beersLeftToSum % 10;
                        beersLeftToSum = beersLeftToSum / 10;
                        sumV = sumV + remainder;
                    }
                    // Sum the number in the left-hand side, a.k.a Mitko's beers.
                    for (int k = 0; k < length[i] / 2; k++)
                    {
                        remainder = beersLeftToSum % 10;
                        beersLeftToSum = beersLeftToSum / 10;
                        sumM = sumM + remainder;
                    }
                }
                // Find if a member of the array is odd.
                else if (length[i] % 2 > 0)
                {
                    beersLeftToSum = dNInt[i];  // Give the value of the current member of the array.
                    // Sum the numbers in the right-hand side, a.k.a Vladko's beers.
                    for (int j = 0; j < length[i] / 2; j++)
                    {
                        remainder = beersLeftToSum % 10;
                        beersLeftToSum = beersLeftToSum / 10;
                        sumV = sumV + remainder;
                    }
                    // Divide the number in the middle, and give half of it to V and half to M.
                    remainder = beersLeftToSum % 10;
                    beersLeftToSum = beersLeftToSum / 10;
                    sumV = sumV + remainder;
                    sumM = sumM + remainder;
                    // Sum the numbers in the left-hand side, a.k.a Mitko's numbers.
                    for (int k = 0; k < length[i] / 2; k++)
                    {
                        remainder = beersLeftToSum % 10;
                        beersLeftToSum = beersLeftToSum / 10;
                        sumM = sumM + remainder;
                    }
                }
            }

            if (sumM > sumV)
            {
                Console.WriteLine("M " + (sumM - sumV));
            }
            else if (sumV > sumM)
            {
                Console.WriteLine("V " + (sumV - sumM));
            }
            else if (sumM == sumV)
            {
                Console.WriteLine("No " + (sumM + sumV));
            }

        }
    }
}
