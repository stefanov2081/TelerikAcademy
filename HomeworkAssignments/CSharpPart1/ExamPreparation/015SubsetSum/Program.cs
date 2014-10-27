using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long wantedSum = long.Parse(Console.ReadLine());
            int numberOfSubsets = int.Parse(Console.ReadLine());
            long[] set = new long[numberOfSubsets];
            int counter = 0;
            long sum = 0;

            for (int i = 0; i < numberOfSubsets; i++)
            {
                set[i] = long.Parse(Console.ReadLine());
            }

            for (long diffSubsets = 1; diffSubsets <= (1 << numberOfSubsets) - 1; diffSubsets++)
            {
                sum = 0;
                for (int bit = 0; bit < numberOfSubsets; bit++)
                {
                    if (0 != (diffSubsets & (1 << bit)))
                    {
                        sum += set[bit];
                    }
                }
                if (sum == wantedSum)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
