using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _052TheSecretsOfTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger originalN = n;
            BigInteger counter = 0;
            BigInteger oddDigits = 0;
            BigInteger evenDigits = 0;
            BigInteger remainder = 0;
            BigInteger specialN = 0;
            BigInteger alphaStartingPos = 0;
            BigInteger lastDigitFromSpecN = 0;
            char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                                  'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string alphaSequence = "";

            if (n < 0)
            {
                n *= -1;
            }
           
            while (n != 0)
            {
                remainder = n % 10;
                n = n / 10;
                counter++;
                if (counter % 2 != 0)
                {
                    oddDigits += remainder * (counter * counter);
                }
                else
                {
                    evenDigits += (remainder * remainder) * counter;
                }
            }

            specialN = oddDigits + evenDigits;
            alphaStartingPos = specialN % 26;
            lastDigitFromSpecN = specialN % 10;
            int i = 0;
            
            counter = alphaStartingPos;
            while (i < lastDigitFromSpecN)
            {
                alphaSequence += alphabet[(int)counter];
                i++;
                counter++;
                if (counter == 26)
                {
                    counter = 0;
                }
            }
            if (lastDigitFromSpecN == 0)
            {
                Console.WriteLine(specialN);
                Console.WriteLine(originalN + " has no secret alpha-sequence");

            }
            else
            {
                Console.WriteLine(specialN);
                Console.WriteLine(alphaSequence);
            }
            
        }
    }
}
