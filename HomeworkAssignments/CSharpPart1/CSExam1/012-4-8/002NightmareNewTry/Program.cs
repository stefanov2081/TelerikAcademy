using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _002NightmareNewTry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input and parse it to long
            string input = Console.ReadLine();
            // Reg exp to remove everything that is not 0-9
            input = Regex.Replace(input, "[^0-9]", string.Empty);
            
            long inputTolong;
            bool inToLng = long.TryParse(input, out inputTolong);
            
            
            // If input is negative multiply by -1 to make it possitive
            //if (inputTolong < 0)
            //{
            //    inputTolong *= -1;
            //}

            string inpToStrRev = "";
            long inPutTolongReversed;
            long eachDigit = inputTolong;
            long amountOffOddPos = 0;
            long sumOfDigOddPos = 0;
            long[] digits = new long[input.Length];


            for (long i = 0; i < input.Length; i++)
            {
                eachDigit = inputTolong % 10;
                inpToStrRev += eachDigit;
                eachDigit = inputTolong / 10;
                inputTolong = eachDigit;
            }

            bool inpToLngRvrsd = long.TryParse(inpToStrRev, out inPutTolongReversed);
            for (long i = 0; i < input.Length; i++)
            {

                eachDigit = inPutTolongReversed % 10;

                if (i % 2 != 0)
                {
                    amountOffOddPos++;
                    sumOfDigOddPos += eachDigit;
                }
                eachDigit = inPutTolongReversed / 10;
                inPutTolongReversed = eachDigit;

            }

            Console.WriteLine(amountOffOddPos + " " + sumOfDigOddPos);
        }
    }
}