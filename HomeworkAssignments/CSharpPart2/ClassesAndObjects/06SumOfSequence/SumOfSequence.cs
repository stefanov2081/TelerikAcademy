using System;

namespace _06SumOfSequence
{
    class SumOfSequence
    {
        // Sum the numbers in a string
        static int SumSeq(string num)
        {
            string currentN = "0";
            int sum = 0;
            int i = 0;

            // Loop thorugh array
            while (i < num.Length)
            {
                // Check if the current element being itterated is a number
                if (num[i] >= 48 && num[i] <= 57)
                {
                    currentN += num[i];
                }
                // Add currentN to sum
                if (i == num.Length - 1 || num[i] < 48 || num[i] > 57)
                {
                    sum += int.Parse(currentN);
                    currentN = "0";
                }

                i++;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine("Enter anything you like! Example: Even 12 this12works!?! = 24)");
            Console.Write("Input:");
            string num = Console.ReadLine();
            Console.WriteLine("The sum of the numbers in " + num + " = " + SumSeq(num));
        }
    }
}
