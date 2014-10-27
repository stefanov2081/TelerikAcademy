using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());
            bool isPillarFound = false;

            int pillar = 7;
            int onesCount = 0;
            int leftCount = 0;
            int rightCount = 0;

            for (int column = 7; column >= 0; column--)
            {
                leftCount = 0;
                rightCount = 0;
                for (int leftColumn = 7; leftColumn > column; leftColumn--)
                {
                    leftCount += n0 >> leftColumn & 1;
                    leftCount += n1 >> leftColumn & 1;
                    leftCount += n2 >> leftColumn & 1;
                    leftCount += n3 >> leftColumn & 1;
                    leftCount += n4 >> leftColumn & 1;
                    leftCount += n5 >> leftColumn & 1;
                    leftCount += n6 >> leftColumn & 1;
                    leftCount += n7 >> leftColumn & 1;
                }
                for (int rightColumn = column - 1; rightColumn >= 0; rightColumn--)
                {
                    rightCount += n0 >> rightColumn & 1;
                    rightCount += n1 >> rightColumn & 1;
                    rightCount += n2 >> rightColumn & 1;
                    rightCount += n3 >> rightColumn & 1;
                    rightCount += n4 >> rightColumn & 1;
                    rightCount += n5 >> rightColumn & 1;
                    rightCount += n6 >> rightColumn & 1;
                    rightCount += n7 >> rightColumn & 1;
                }
                if (leftCount == rightCount)
                {
                    pillar = column;
                    onesCount = leftCount;
                    isPillarFound = true;
                    break;
                }
            }
            if (isPillarFound == true)
            {
                Console.WriteLine(pillar);
                Console.WriteLine(leftCount);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
