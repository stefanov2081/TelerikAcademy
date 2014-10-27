using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neurons
{
    class Neurons
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long n = long.Parse(Console.ReadLine());
                if (n == -1)
                {
                    break;
                }

                char[] number = Convert.ToString(n, 2).ToArray();

                int leftOne = Array.IndexOf(number, '1');
                int rightOne = Array.LastIndexOf(number, '1');

                if (leftOne != -1)
                {
                    for (int i = leftOne; i <= rightOne; i++)
                    {
                        if (number[i] == '1')
                        {
                            number[i] = '0';
                        }
                        else
                        {
                            number[i] = '1';
                        }
                    }
                }
                Console.WriteLine(Convert.ToInt32(string.Join(string.Empty, number), 2));
            }
        }
    }
}
