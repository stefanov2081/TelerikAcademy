using System;

namespace _07FromAnyNumSysToAny
{
    class FromAnyNumSysToAny
    {
        // Any numeral to decimal
        static int ToDecimal(int numBase, string num)
        {
            char[] base36 = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 
                'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            
            num = num.ToUpper();
            char[] numToChar = num.ToCharArray();
            int multiplier = 1;
            int result = 0;
            int currentNum;

            // Get decimal number
            for (int i = numToChar.Length - 1; i >= 0; i--)
            {
                currentNum = Array.IndexOf(base36, numToChar[i]);
                result += currentNum * multiplier;
                multiplier = multiplier * numBase;
            }

            return result;
        }

        // Decimal to any numeral base
        static string ToNumBase(int numBase, int num)
        {
            char[] base36 = 
            { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 
                'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string result = "";

            // Check for negative numbers
            if (num < 0)
            {
                num *= -1;
            }

            // Get base number
            while (num != 0)
            {
                result = base36[num % numBase] + result;
                num /= numBase;
            }

            return result;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("You can convert from any numeral system to any other in the range 2 - 36!");
            Console.WriteLine("Example: numeral system base: 30");
            Console.WriteLine("What numeral system is your number?");
            Console.Write("Enter numeral system base: ");
            int inNumBase = int.Parse(Console.ReadLine());
            Console.Write("Enter number in base " + inNumBase + ", (Example: BEER(Base 36)) input: ");
            string number = Console.ReadLine();
            Console.WriteLine("In what numeral system do you want to convert {0} in base {1} to?", number, inNumBase);
            Console.Write("Enter desired numeral system base: ");
            int outNumBase = int.Parse(Console.ReadLine());

            // Call ToNumBase() with outNumbase and the result from ToDecimal() and print
            Console.WriteLine(ToNumBase(outNumBase, ToDecimal(inNumBase, number)));
        }
    }
}
