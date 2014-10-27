using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _032LeastMajorityMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int remainderA;
            int remainderB;
            int remainderC;
            int remainderD;
            int remainderE;



            int divisor = 1;

            while (true)
            {
                remainderA = a;
                remainderB = b;
                remainderC = c;
                remainderD = d;
                remainderE = e;
                remainderA = divisor % remainderA;
                remainderB = divisor % remainderB;
                remainderC = divisor % remainderC;
                remainderD = divisor % remainderD;
                remainderE = divisor % remainderE;

                if ((remainderA == 0) && (remainderB == 0) && (remainderC == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderA == 0) && (remainderB == 0) && (remainderD == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderA == 0) && (remainderB == 0) && (remainderE == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderA == 0) && (remainderC == 0) && (remainderD == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderA == 0) && (remainderC == 0) && (remainderE == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderA == 0) && (remainderD == 0) && (remainderE == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderB == 0) && (remainderC == 0) && (remainderD == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderB == 0) && (remainderC == 0) && (remainderE == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderB == 0) && (remainderD == 0) && (remainderE == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else if ((remainderC == 0) && (remainderD == 0) && (remainderE == 0))
                {
                    Console.WriteLine(divisor);
                    break;
                }
                else
                {
                    divisor++;
                }
                
 
            }
        }
    }
}
