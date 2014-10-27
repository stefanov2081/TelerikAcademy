using System;

namespace _01PrintName
{
    class PrintName
    {
        // Get name and print
        static void NamePrint(string name = "name")
        {
            if (name == "name")
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                Console.WriteLine("Hello, " + name + "!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hello, " + name + "!");
                Console.WriteLine();
            }
        }
        // Call NamePrint() with random name
        static void AutoTest()
        {
            string[] names = { "Pesho", "Iva", "Gosho", "Elena", "Haralampii", "Nadejda" };
            Random rand = new Random();
            int randomNumber = rand.Next(0, 6);
            string name = names[randomNumber];
            NamePrint(name);
        }

        static void Main(string[] args)
        {

            int input = 0; 

            // Switch for each option
            while (input != 3)
            {
                // Get value from user input
                Console.WriteLine("You have three options:");
                Console.WriteLine("Option 1: Write your name, and see it printed.");
                Console.WriteLine("Option 2: See the automated test.");
                Console.WriteLine("Option 3: Exit");
                Console.Write(@"Enter ""1"", ""2"" or ""3"": ");
                Console.WriteLine();
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        NamePrint();
                        break;
                    case 2:
                        AutoTest();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
