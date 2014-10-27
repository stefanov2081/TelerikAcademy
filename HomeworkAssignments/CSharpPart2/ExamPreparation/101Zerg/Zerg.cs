using System;

namespace _101Zerg
{
    class Zerg
    {
        // Convert from base15 to base10
        static long ToDecimal(string[] inp)
        {
            string[] base15 = 
            {"Rawr", "Rrrr", "Hsst", "Ssst", "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", "Djav", "Myau", "Gruh",};
            int currentNum;
            long result = 0;;

            for (int i = 0; i < inp.Length; i++)
            {
                currentNum = Array.IndexOf(base15, inp[i]);
                result *= 15;
                result += currentNum;
            }

            return result;
        }

        // Split input
        static string[] SplitInput(string inp)
        {
            string[] splitInput = new string[inp.Length / 4];
            int index = 0;

            for (int i = 0; i < inp.Length; i+=4)
            {
                string current = inp.Substring(i, 4);
                splitInput[index] = current;
                index++;
            }

            return splitInput;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            string input = Console.ReadLine();
            Console.WriteLine(ToDecimal(SplitInput(input)));
        }
    }
}
