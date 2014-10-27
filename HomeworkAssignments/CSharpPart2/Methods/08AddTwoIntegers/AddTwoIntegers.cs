using System;

namespace _08AddTwoIntegers
{
    class AddTwoIntegers
    {
        // Get the char array to int array
        static int[] CharArrToIntArr(char[] a)
        {
            int[] temp = new int[a.Length];
            for (int i = 0; i < temp.Length; i++)
			{
                temp[i] = a[i] - 48;
			}
            return temp;
        }

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

        static void Main(string[] args)
        {
            // Get value from user input
            Console.Write("Enter first number:");
            string numberOne = Console.ReadLine();
            char[] numOneToChar = numberOne.ToCharArray();
            int[] frstArr = new int[numberOne.Length];
            Console.Write("Enter second number:");
            string numberTwo = Console.ReadLine();
            char[] numTwoToChar = numberTwo.ToCharArray();
            int[] scndArr = new int[numberTwo.Length];

            // Call function CharArrToIntArr
            frstArr = CharArrToIntArr(numOneToChar);
            scndArr = CharArrToIntArr(numTwoToChar);

            // Call function Add
            int[] result = Add(frstArr, scndArr);

            // Print the result
            foreach (var item in frstArr)
            {
                Console.Write(item);
            }
            Console.Write(" + ");
            foreach (var item in scndArr)
            {
                Console.Write(item);
            }
            Console.Write(" = ");
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
