using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableLengthCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int l = int.Parse(Console.ReadLine());

            string[] codeTable = new string[l];

            for (int i = 0; i < l; i++)
            {
                codeTable[i] = Console.ReadLine();
            }

            string letter;
            int length;
            ulong[] binary = new ulong[codeTable.Length];
            string currentNum;

            for (int i = 0; i < codeTable.Length; i++)
            {
                letter = codeTable[i].Substring(0, 1);
                codeTable[i] = codeTable[i].Replace(letter, "");
                length = int.Parse(codeTable[i]);
                currentNum = new string('1', length) + 0;
                binary[i] = ulong.Parse(currentNum);
            }

            Array.Sort(binary);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < binary.Length; i++)
            {
                sb.Append(binary[i]);
            }

            string sentence = sb.ToString();
            int remainder = sentence.Length % 8;

            if (remainder != 0)
            {
                sentence += new string('0', remainder);
            }
        }
    }
}
