using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05GameOfPage
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] tray = new long[16];
            long x;
            long y = 14;
            long remainder = 0;
            long row1Cookie = 0;
            long row1SecCookie = 0;
            long row1rThrdCookie = 0;
            long row2Cookie = 0;
            long row2SecCookie = 0;
            long row2ThrdCookie = 0;
            long row3Cookie = 0;
            long row3SecCookie = 0;
            long row3ThrdCookie = 0;
            long row1Counter = 0;
            long row2Counter = 0;
            long row3Counter = 0;
            bool threeCookiesRowMinus1 = false;
            bool threeCookiesRow0 = false;
            bool threeCookiesRowPlus1 = false;
            bool brokenCookie = false;
            bool cookieCrumb = false;
            decimal bill = 0M;
            decimal cookiePrice = 1.79M;

            for (int i = 15; i > 0; i--)
            {
                tray[i] = int.Parse(Console.ReadLine());
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "paypal")
                {
                    break;
                }
                if (input == "what is")
                {
                    while (true)
                    {
                         threeCookiesRowMinus1 = false;
                         threeCookiesRow0 = false;
                         threeCookiesRowPlus1 = false;
                         brokenCookie = false;
                         cookieCrumb = false;

                        x = int.Parse(Console.ReadLine());
                        y = int.Parse(Console.ReadLine());
                        for (long i = x; i < x + 3; i++)
                        {
                            if (x - 1 >= 0)
                            {
                                row1Cookie = tray[i - 1];
                                row2Cookie = tray[i];
                                row3Cookie = tray[i + 1];

                                // Row -1
                                for (int j = 0; j < y; j++)
                                {
                                    remainder = row1Cookie % 10;
                                    row1Cookie = row1Cookie / 10;
                                }
                                if (remainder == 1)
                                {
                                    cookieCrumb = true;
                                    remainder = row1Cookie % 10;
                                    row1Cookie = row1Cookie / 10;
                                    if (remainder == 1)
                                    {
                                        cookieCrumb = false;
                                        brokenCookie = true;
                                        remainder = row1Cookie % 10;
                                        row1Cookie = row1Cookie / 10;
                                        if (remainder == 1)
                                        {
                                            brokenCookie = false;
                                            threeCookiesRowMinus1 = true;
                                        }
                                    }
                                }

                                // Row 0
                                for (int jj = 0; jj < y; jj++)
                                {
                                    remainder = row2Cookie % 10;
                                    row2Cookie = row2Cookie / 10;
                                }
                                if (remainder == 1)
                                {
                                    cookieCrumb = true;
                                    remainder = row2Cookie % 10;
                                    row2Cookie = row2Cookie / 10;
                                    if (remainder == 1)
                                    {
                                        cookieCrumb = false;
                                        brokenCookie = true;
                                        remainder = row2Cookie % 10;
                                        row2Cookie = row2Cookie / 10;
                                        if (remainder == 1)
                                        {
                                            brokenCookie = false;
                                            threeCookiesRow0 = true;
                                        }
                                    }
                                }

                                // Row +1
                                for (int jjj = 0; jjj < y; jjj++)
                                {
                                    remainder = row3Cookie % 10;
                                    row3Cookie = row3Cookie / 10;
                                    if (remainder == 1)
                                    {
                                        brokenCookie = true;
                                        remainder = row3Cookie % 10;
                                        row3Cookie = row3Cookie / 10;
                                        if (remainder == 1)
                                        {
                                            cookieCrumb = false;
                                            brokenCookie = true;
                                            remainder = row3Cookie % 10;
                                            row3Cookie = row3Cookie / 10;
                                            if (remainder == 1)
                                            {
                                                brokenCookie = false;
                                                threeCookiesRowPlus1 = true;
                                            }
                                        }
                                    }
                                }
                                if ((threeCookiesRowPlus1 == true) && (threeCookiesRowMinus1 == true)
                                    && (threeCookiesRow0 == true))
                                {
                                    Console.WriteLine("cookie");
                                    if (input == "buy")
                                    {
                                        bill = bill + cookiePrice;
                                    }
                                    
                                }
                                if (cookieCrumb == true)
                                {
                                    Console.WriteLine("cookie crumb");
                                }
                                if (brokenCookie == true)
                                {
                                    Console.WriteLine("broken cookie");
                                }
                                else
                                {
                                    Console.WriteLine("page");
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
