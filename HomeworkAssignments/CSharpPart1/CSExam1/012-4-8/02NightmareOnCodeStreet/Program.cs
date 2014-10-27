using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _02NightmareOnCodeStreet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
           
            string inpToStrRev = "";
            long inPutTolongReversed;
            
            long amountOffOddPos = 0;
            long sumOfDigOddPos = 0;
            long[] digits = new long[input.Length];


            for (int i = 0; i < input.Length; i++)
            {
                if ((chars[i] != '0') || (chars[i] != '1') || (chars[i] != '2') || (chars[i] != '3') || 
                    (chars[i] != '4') || (chars[i] != '5') || (chars[i] != '6') || (chars[i] != '7') || 
                    (chars[i] != '8') || (chars[i] != '9'))
                {
                    continue;
                }
                inpToStrRev += chars[i];
                Console.WriteLine(inpToStrRev);
            }

            long inputTolong = long.Parse(inpToStrRev);
            long eachDigit = inputTolong;

            for (long i = 0; i < input.Length; i++)
            {
                eachDigit = inputTolong % 10;
                inpToStrRev += "" + eachDigit;
                eachDigit = inputTolong / 10;
                inputTolong = eachDigit;
            }

            inPutTolongReversed = long.Parse(inpToStrRev);
            for (long i = 0; i < input.Length; i++)
            {

                eachDigit = inPutTolongReversed % 10;
                //digits[i] = eachDigit;

                if (i % 2 != 0)
                {
                    amountOffOddPos++;
                    sumOfDigOddPos += eachDigit;
                }
                eachDigit = inPutTolongReversed / 10;
                inPutTolongReversed = eachDigit;

            }
 
            Console.WriteLine(amountOffOddPos + " " + sumOfDigOddPos);
 
            //for (long i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine(digits[i]);
            //}
            
        }
    }
}
