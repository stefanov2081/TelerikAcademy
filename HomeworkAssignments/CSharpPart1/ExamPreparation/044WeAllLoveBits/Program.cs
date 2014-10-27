using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044WeAllLoveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            uint pNew = 0;
            uint pReversed = 0;

            for (int i = 1; i <= n; i++)
            {
                uint eachP = uint.Parse(Console.ReadLine());

                while (eachP > 0)
                {
                    pReversed <<= 1;
                    if ((eachP & 1) == 1)
                    {
                        pReversed |= 1;
                    }
                    eachP >>= 1;
                }

                pNew = eachP ^ (~eachP) & pReversed;
                Console.WriteLine(pNew);
                pReversed = 0;
            }
        }
    }
}
