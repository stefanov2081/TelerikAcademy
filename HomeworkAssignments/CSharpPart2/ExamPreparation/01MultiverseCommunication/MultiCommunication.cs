using System;
using System.Text;

namespace _01MultiverseCommunication
{
    class MultiCommunication
    {
        static long ToDecimal(string[] num)
        {
            string[] baseThirteen = 
            { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            long multiplier = 1;
            long result = 0;
            long currentNum;

            // Reverse
            Array.Reverse(num);

            // Get decimal number
            for (int i = 0; i < num.Length; i++)
            {
                currentNum = Array.IndexOf(baseThirteen, num[i]);
                result += currentNum * multiplier;
                multiplier = multiplier * 13;
            }

            return result;
        }

        // Split each code num into array
        static string[] SplitInput(string inp)
        {
            string[] result = new string[inp.Length / 3];
            StringBuilder sb = new StringBuilder();
            int index = 0;

            // Put each 3 letter long substring in array
            for (int i = 1; i <= inp.Length; i++)
            {
                sb.Append(inp[i - 1]);
                if (i % 3 == 0)
                {
                    result[index] = sb.ToString();
                    sb.Clear();
                    index++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ToDecimal(SplitInput(input)));
        }
    }
}
