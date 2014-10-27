using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _034OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            //int counter = 0;
            long result = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                result = result ^ array[i];
            }
            Console.WriteLine(result);

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    for (int j = n - 1; j >= 0; j--)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            counter++;
            //        }
            //    }
            //    if (counter % 2 > 0)
            //    {
            //        Console.WriteLine(array[i]);
            //        break;
            //    }
            //}
        }
    }
}
