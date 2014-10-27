using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _054BatGoikosTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            char blank = '.';
            char leftSide = '/';
            char rightSide = '\\';
            char dash = '-';
            int dashProgression = 1;
            int j = 2;

            for (int i = 0; i < h; i++)
            {
                Console.Write(new string(blank, h - i - 1));
                Console.Write(new string(leftSide, 1));
                if (i == dashProgression)
                {
                    dashProgression += j;
                    j++;
                    Console.Write(new string(dash, i * 2));
                }
                else
                {
                    Console.Write(new string(blank, i * 2));
                }
                Console.Write(new string(rightSide, 1));
                Console.WriteLine(new string(blank, h - i - 1));
                
            }
        }
    }
}
