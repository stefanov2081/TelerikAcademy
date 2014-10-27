using System;

namespace _10FactorialFrom1To100
{
    class FactorialFrom1To100
    {
        // Reverse array
        static void ReverseArr(int[] a)
        {
            int swapVal;
            for (int i = 0; i < a.Length / 2; i++)
            {
                swapVal = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = swapVal;
            }
        }

        // Add arrays
        static int[] Add(int[] a, int[] b)
        {
            ReverseArr(a);
            ReverseArr(b);
            // Prevents index out of range errors
            int[] temp = new int[(a.Length + b.Length)];
            bool[] isNumber = new bool[(a.Length + b.Length)];
            int count = 0;
            int remainder;
            // Sum each element in the array
            // If first array is greater than the second
            if (a.Length > b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i < b.Length)
                    {
                        temp[i] += a[i] + b[i];
                        isNumber[i] = true;
                        if (temp[i] > 9)
                        {
                            remainder = temp[i];
                            temp[i] = remainder % 10;
                            temp[i + 1] = remainder / 10;
                            isNumber[i + 1] = true;
                        }
                    }
                    else
                    {
                        temp[i] += a[i];
                        isNumber[i] = true;
                    }
                }
            }

            // If second array is greater or equal to first
            if (b.Length >= a.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (i < a.Length)
                    {
                        temp[i] += a[i] + b[i];
                        isNumber[i] = true;
                        if (temp[i] > 9)
                        {
                            remainder = temp[i];
                            temp[i] = remainder % 10;
                            temp[i + 1] = remainder / 10;
                            isNumber[i + 1] = true;
                        }
                    }
                    else
                    {
                        temp[i] += b[i];
                        isNumber[i] = true;
                    }
                }
            }


            // Remove unnecessary zeros at the end
            for (int i = 0; i < isNumber.Length; i++)
            {
                if (isNumber[i])
                {
                    count++;
                }
            }
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }
            ReverseArr(result);
            ReverseArr(a);
            ReverseArr(b);
            return result;
        }

        // Multiply arrays
        static int[] Multiply(int[] a, int[] b)
        {
            ReverseArr(a);
            ReverseArr(b);
            int[] temp = new int[a.Length + b.Length];
            bool[] isNumber = new bool[a.Length + b.Length];
            int remainder;

            // If first array is greater than the second
            if (a.Length > b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        temp[j + i] += a[j] * b[i];
                        isNumber[j + i] = true;
                        if (temp[j + i] > 9)
                        {
                            remainder = temp[j + i];
                            temp[j + i] = remainder % 10;
                            temp[j + i + 1] += remainder / 10;
                            isNumber[j + i + 1] = true;
                        }
                    }
                }
            }

            // If the second array is greater or equal to the first
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        temp[j + i] += a[i] * b[j];
                        isNumber[j + i] = true;
                        if (temp[j + i] > 9)
                        {
                            remainder = temp[j + i];
                            temp[j + i] = remainder % 10;
                            temp[j + i + 1] += remainder / 10;
                            isNumber[j + i + 1] = true;
                        }
                    }
                }
            }

            // Remove unnecessary zeros at the end
            int count = 0;
            for (int i = 0; i < isNumber.Length; i++)
            {
                if (isNumber[i])
                {
                    count++;
                }
            }
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }
            ReverseArr(a);
            ReverseArr(b);
            ReverseArr(result);
            return result;
        }

        // Find factorial
        static int[] Factorial(int n)
        {
            int[] temp = { 2 };
            int[] addOne = { 1 };
            int[] result = { 1 };
            for (int i = 1; i < n; i++)
            {
                result = Multiply(result, temp);
                temp = Add(temp, addOne);
            }
            return result;
        }

        // Print
        static void Print(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Call method Print() with method Factorial() as parameter
            for (int i = 1; i < 101; i++)
            {
                Console.Write(i + " factorial = ");
                Print(Factorial(i));
            }
        }
    }
}
