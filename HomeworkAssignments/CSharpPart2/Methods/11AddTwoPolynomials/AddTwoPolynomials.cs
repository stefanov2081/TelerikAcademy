﻿using System;

namespace _11AddTwoPolynomials
{
    class AddTwoPolynomials
    {
        // Add polynomials
        static decimal[] Add(decimal[] a, decimal[] b)
        {
            decimal[] result;

            // If first polynomial is greater
            if (a.Length > b.Length)
            {
                result = new decimal[a.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    result[i] = a[i] + b[i];
                }
            }
            // If second polynoimal is greater or equal to first
            else
            {
                result = new decimal[b.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    result[i] = a[i] + b[i];
                }
            }

            // Fill the polynomials at the end of the larger polynomial if available
            if (a.Length > b.Length)
            {
                for (int i = b.Length; i < a.Length; i++)
                {
                    result[i] = a[i];
                }
            }
            else if (b.Length > a.Length)
            {
                for (int i = a.Length; i < b.Length; i++)
                {
                    result[i] = b[i];
                }
            }
            return result;
        }

        // Print polynomial
        static void Print(decimal[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (i != 1)
                {
                    if (a[i] != 0 && i != 0)
                    {
                        if (a[i - 1] >= 0)
                        {
                            Console.Write("{0}x^{1} +", a[i], i);
                        }
                        else
                        {
                            Console.Write("{0}x^{1} ", a[i], i);
                        }
                    }
                    else
                    {
                        Console.Write(a[i]);
                    }
                }
                else
                {
                    if (a[i - 1] >= 0)
                    {
                        Console.Write("{0}x +", a[i]);
                    }
                    else
                    {
                        Console.Write("{0}x ", a[i]);
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Predefined values
            decimal[] frstPoly = { 12, 13, -5, 10 };
            decimal[] scndPoly = { 5, 12, 15 };
            decimal[] result;
            
            Console.Write("First polynom:   ");
            Print(frstPoly);
            Console.Write("Second polynom:  ");
            Print(scndPoly);
            Console.Write("First + second = ");
            result = Add(frstPoly, scndPoly);
            Print(result);
        }
    }
}
