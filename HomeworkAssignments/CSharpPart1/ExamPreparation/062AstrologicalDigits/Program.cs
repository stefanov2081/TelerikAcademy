using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062AstrologicalDigits
{
    class Program
    {
        static void SumDecimalDigits(decimal decimalDigits = 0)
        {

        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputAsChar;
            inputAsChar = input.ToCharArray();
            int sum = 0;
            int remainder = 0;
            foreach (var item in inputAsChar)
            {
                if (item == '.' || item == '-')
                {
                    continue;
                }
                sum += item - '0';
            }
            if (sum > 9)
            {

            }
            if (sum > 9)
            {
                while (sum > 9)
                {
                    remainder = sum % 10;
                    sum /= 10;
                    sum += remainder;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
