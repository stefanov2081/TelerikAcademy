using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq.Expressions;

namespace _02BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            List<ulong> cages = new List<ulong>(105);

            while (true)
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                cages.Add(ulong.Parse(input));
            }

            // Proccess cyclce

            ulong sum;
            int index;
            BigInteger product;
            ulong productToAdd;
            ulong sumToAdd;
            string removeZerosAndOnes = "";

            for (int i = 0; i < cages.Count; i++)
            {
                // Maybe cages.count - 1
                //1.	If there are less than i cages, the factory stops the multiplication process.
                if (i > cages.Count)
                {
                    break;
                }

                // Null
                index = 0;
                sum = 0;
                product = 0;
                // 2.	The factory gets the first i cages and calculate the sum s of all bunnies in them.
                for (int k = 0; k <= i; k++)
                {
                    index += (int)cages[k];
                }

                // 3.	If there are less than s cages after the i-th one, the factory stops the multiplication process.
                if (cages.Count - i < index)
                {
                    break;
                }

                // 4.	The factory gets the next s cages after the i-th one and calculates the sum and product of all bunnies in them. 
                for (int j = index + i; j > i; j--)
                {
                    sum += cages[j];
                    if (product == 0)
                    {
                        product = cages[j];
                    }
                    else
                    {
                        product *= cages[j];
                    }
                }

                // 5.	These sum and product are concatenated as next cages. All cages that were not included in the calculations are simply appended to next.
                cages.RemoveRange(0, index + 1 + i);

                while (product != 0)
                {
                    productToAdd = (ulong)(product % 10);
                    product /= 10;
                    cages.Insert(0, productToAdd);
                }

                while (sum != 0)
                {
                    sumToAdd = sum % 10;
                    sum /= 10;
                    cages.Insert(0, sumToAdd);
                }



                removeZerosAndOnes = "";
                // 6.	The factory gets several empty cages then gets the digits of next and for each digit puts the same amount of bunnies in each cell. 
                // If the digit is 1 or 0, the digit is ignored.
                foreach (var item in cages)
                {
                    removeZerosAndOnes += item;
                }

                
                removeZerosAndOnes = removeZerosAndOnes.Replace("0", "");
                removeZerosAndOnes = removeZerosAndOnes.Replace("1", "");
                cages.Clear();

                for (int m = 0; m < removeZerosAndOnes.Length; m++)
                {
                    cages.Add((ulong)(removeZerosAndOnes[m] - 48));
                }


                // 7.	Step 1 is repeated for the newly generated cages with bunnies.
            }

            foreach (var item in cages)
            {
                Console.Write(item + " ");
            }
        }
    }
}
