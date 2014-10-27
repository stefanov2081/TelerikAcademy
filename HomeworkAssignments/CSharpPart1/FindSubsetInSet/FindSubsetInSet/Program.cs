using System;

class Subsets
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of integers:");
        int numberOfIntegers = int.Parse(Console.ReadLine());
        int[] setOfIntegers = new int[numberOfIntegers];
        for (int number = 0; number < numberOfIntegers; number++)
        {
            Console.WriteLine("Enter integer number {0}", number + 1);
            setOfIntegers[number] = int.Parse(Console.ReadLine());
        }
        //iterate all subsets
        for (int subsets = 1; subsets <= (1 << numberOfIntegers) - 1; subsets++)
        {
            int sum = 0;
            for (int bit = 0; bit < numberOfIntegers; bit++)
            {
                if (0 != (subsets & (1 << bit)))
                {
                    sum += setOfIntegers[bit];
                }
            }
            if (sum == 0)
            {
                //break - we found a subset whose
                Console.WriteLine("Found a subset whose sum is 0.");
                for (int bit = 0; bit < numberOfIntegers; bit++)
                {
                    if (0 != (subsets & (1 << bit)))
                    {
                        Console.WriteLine("Element {0} with value {1}", bit, setOfIntegers[bit]);
                    }
                }
            }
        }
    }
}

