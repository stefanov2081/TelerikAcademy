using System;

namespace _07ReverseDigitsOfNumber
{
    class ReverseDigitsOfNumber
    {
        static string ReverseDigits(int a)
        {
            // Convert the number to char array if it is negative and reverse it. Else reverse the number
            string num = a.ToString();
            char[] numToCharArr = num.ToCharArray();
            string revNum = "";
            int currentN;
            int remainder;
            if (numToCharArr[0] == '-')
            {
                for (int i = numToCharArr.Length - 1; i >= 1; i--)
                {
                    currentN = (int)numToCharArr[i];
                    remainder = currentN - 48;
                    revNum += remainder.ToString();
                }
                revNum = revNum.Insert(0, "-");
            }
            else
            {
                while (a != 0)
                {
                    remainder = a % 10;
                    a = a / 10;
                    revNum += remainder.ToString();
                }
            }
            return revNum;
        }
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter integer:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + " reversed = " + ReverseDigits(n));
        }
    }
}
