using System;
using System.Text;

namespace _04CountNumberInArray
{
    class CountNumberInArray
    {
        static int Count(int[] array, int a)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (a == array[i])
                {
                    count++;
                }
            }

            return count;
        }

        static string AutoTest(int a = 0)
        {
            StringBuilder result = new StringBuilder();
            result.Append("Automated test: \n");
            int emmersionInArray;
            
            // Test 1
            // Input: array[] = {1, 2, 2, 2}, a = 2, count how many times 2 appears in the array
            // Expected output: 3
            int[] testArray = { 1, 2, 2, 2 };
            emmersionInArray = Count(testArray, 2);
            if (emmersionInArray == 3)
            {
                result.Append("Test 1: \nExpected Output: 3 \nOutput: " + emmersionInArray + "\nPassed \n");
            }
            else
            {
                result.Append("Test 1: \nExpected Output: 3 \nOutput: " + emmersionInArray + "\nFailed \n");
            }
            
            // Test 2
            // Input FillArray(10, 5), a = 5
            // Expected output = 6
            testArray = FillArray(10, 5);
            emmersionInArray = Count(testArray, 5);
            if (emmersionInArray == 6)
            {
                result.Append("Test 2: \nExpected Output: 6 \nOutput: " + emmersionInArray + "\nPassed \n");
            }
            else
            {
                result.Append("Test 2: \nExpected Output: 6 \nOutput: " + emmersionInArray + "\nFailed \n");
            }
            
            // Test 3
            // Input FillArray(23, 12), a = 12
            // Expected output = 6
            testArray = FillArray(23, 12);
            emmersionInArray = Count(testArray, 12);
            if (emmersionInArray == 12)
            {
                result.Append("Test 3: \nExpected Output: 12 \nOutput: " + emmersionInArray + "\nPassed \n");
            }
            else
            {
                result.Append("Test 3: \nExpected Output: 12 \nOutput: " + emmersionInArray + "\nFailed \n");
            }

            return result.ToString();
        }

        static string UserDefinedTest()
        {
            // User defined test
            StringBuilder result = new StringBuilder();

            // Get value from user input
            Console.WriteLine("How big array would you like to allocate?");
            int n = int.Parse(Console.ReadLine());
            
            int[] testArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array element[{0}]", i);
                testArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What element would you like to see how many times appear in the array?");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine("Predefined values are uswed for testing. You need to tell how many times \n{0} appears in the array.", element);
            Console.Write("Enter how many times {0} appears in the array:", element);
            int userDefinedEmmersion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int emmersionInArray;
            emmersionInArray = Count(testArray, element);
            if (emmersionInArray == userDefinedEmmersion)
            {
                result.Append("User defined test: \n");
                result.Append("Expected Output: " + userDefinedEmmersion + "\n");
                result.Append("Output: " + emmersionInArray + "\nPassed \n");
            }
            else
            {
                result.Append("Test 3: \nExpected Output: 3 \nOutput: " + emmersionInArray + "\nFailed \n");
            }

            return result.ToString();

        }

        // Fills the array of size a, with elemetns = i, and for every even element appends b
        static int[] FillArray(int a, int b)
        {
            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = b;
                }
                else
                {
                    array[i] = i;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {

            string input = "";
            Console.WriteLine("Function Count(), counts how many times a given element appears in array. \nAutoTest() tests if the count function" + 
                    " is working correct. \nUserDefinedTest() lets you input the test parameters manually and see if \nCount() is working properly. \n" + 
                    "You can either see the results from the automated test or test it manually.");

            while (input != "exit")
            {
                Console.WriteLine("\nTo see the results from the automated test type:" + 
                    "\"auto\" \nTo test it manually type: \"manual\" \nTo exit type: \"exit\"");
                Console.Write("Input:");
                input = Console.ReadLine();
                if (input == "auto")
                {
                    Console.WriteLine(new string('*', 80));
                    Console.WriteLine(AutoTest());
                    Console.WriteLine(new string('*', 80));

                }
                if (input == "manual")
                {
                    Console.WriteLine(new string('*', 80));
                    Console.WriteLine(UserDefinedTest());
                    Console.WriteLine(new string('*', 80));

                }
            }


        }
    }
}
