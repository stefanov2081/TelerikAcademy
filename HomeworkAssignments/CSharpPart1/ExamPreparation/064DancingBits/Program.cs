using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064DancingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int currentN;
            int mask;
            int bit;
            int nextBit;
            int countOnes = 0;
            int countZeros = 0;
            int globalCounter = 0;
            bool afterLeadingZeros = false;

            // 101110111010001111
            for (int i = 0; i < n; i++)
            {
                currentN = int.Parse(Console.ReadLine());
                
                // Every new number starts with zeros
                afterLeadingZeros = false;
                
                for (int p = 31; p >= 0; p--)
                 {
                    mask = currentN & (1 << p);
                    bit = mask >> p;

                    mask = currentN & (1 << p - 1);
                    nextBit = mask >> p - 1;
                    
                    Console.Write(bit);
                    
                    // When there are no more leading zeros counting starts
                    if (bit == 1)
                    {
                        afterLeadingZeros = true;
                    }
                    if (afterLeadingZeros == true)
                    {
                        if (bit == 1)
                        {
                            countOnes++;
                        }
                        if (bit == 0)
                        {
                            countZeros++;
                        }
                        // Make sure that there isn't subset larger than k
                        if ((countOnes == k) && (nextBit == 1))
                        {
                            countOnes = 0;
                        }
                        //if ((countZeros == k) && (nextBit == 0))
                        //{
                        //    countZeros = 0;
                        //}

                        // Futile atempt
                        if ((countOnes == k))
                        {
                            countOnes = 0;
                            countZeros = 0;
                            globalCounter++;
                        }
                        if ((countZeros == k))
                        {
                            countOnes = 0;
                            countZeros = 0;
                            globalCounter++;
                        }

                        // Does not take into accout the bits from the next number
                        //if ((countOnes == k) && (nextBit != 1))
                        //{
                        //    countOnes = 0;
                        //    countZeros = 0;
                        //    globalCounter++;
                        //}
                        //if ((countZeros == k) && (nextBit != 0))
                        //{
                        //    countOnes = 0;
                        //    countZeros = 0;
                        //    globalCounter++;
                        //}

                        // Working solution for 20/100 points
                        //if (countOnes > k)
                        //{
                        //    countOnes = 0;
                        //    globalCounter--;
                        //}
                        //if (countZeros > k)
                        //{
                        //    countZeros = 0;
                        //    globalCounter--;
                        //}
                        //if ((countOnes >= 1) && (countZeros >= 1))
                        //{
                        //    countOnes = 0;
                        //    countZeros = 0;
                        //}
                        if ((bit == 1) && (nextBit == 0) && (p - 1 >= 0))
                        {
                            countOnes = 0;
                            countZeros = 0;
                        }
                        if ((bit == 0) && (nextBit == 1) && (p - 1 >= 0))
                        {
                            countOnes = 0;
                            countZeros = 0;
                        }
                        
                    }

                }

                Console.WriteLine();
                Console.WriteLine(globalCounter);
            }

            //Console.WriteLine(globalCounter);

        }
    }
}
