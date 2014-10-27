using System;

namespace _01BasicBASIC
{
    class BasicBASIC
    {
        // Variables
        static string input = "";
        static int V;
        static int W;
        static int X;
        static int Y;
        static int Z;

        // Assign value to a given variable
        static void CommandEquals
            (string varName, string aritOperator, int fisrtValue = 0, int secondValue = 0, string secondVarName = "")
        {
            if (secondValue == 0)
            {
                if (varName == "V")
                {
                    V += fisrtValue;
                }
                else if (varName == "W")
                {
                    W += fisrtValue;
                }
                else if (varName == "X")
                {
                    X += fisrtValue;
                }
                else if (varName == "Y")
                {
                    Y += fisrtValue;
                }
                else if (varName == "Z")
                {
                    Z += fisrtValue;
                }
            }
            else if (secondValue != 0 && aritOperator == "+")
            {
                if ()
            }
        }

        static void Main(string[] args)
        {
            // Commands
            string[] commands = { "=", "IF", "THEN", "GOTO", "CLS", "PRINT", "STOP", "RUN" };
            string firstVarName = "";
            string secondVarName = "";
            string aritOperator = "";
            string command = "";
            string firstNumber = "";
            string secondNumber = "";

            // Char to read each char
            char currentChar;

            while (input != "RUN")
            {
                // Read input
                input = Console.ReadLine();

                // Remove whitespace
                input = input.Replace(" ", "");

                // Read each line char by char
                for (int i = 0; i < input.Length; i++)
                {
                    currentChar = input[i];

                    // Search for Variables
                    // Break if there is more than one operator
                    // If current char is variable
                    if (currentChar == 'V' || currentChar == 'W' || currentChar == 'X' || 
                        currentChar == 'Y' || currentChar == 'Z')
                    {
                        firstVarName = currentChar.ToString();
                    }
                    // If current char is =
                    else if ((firstVarName == "V" || firstVarName == "W" || firstVarName == "X" ||
                        firstVarName == "Y" || firstVarName == "Z") && currentChar == '=')
                    {
                        command = "=";
                    }
                    // Get first number
                    else if ((firstVarName == "V" || firstVarName == "W" || firstVarName == "X" ||
                        firstVarName == "Y" || firstVarName == "Z") && command == "=" && 
                        (char.IsDigit(input[i]) || currentChar == '-') && firstNumber.Length == 0)
                    {
                        firstNumber += currentChar;
                    }
                    // If there is only one variable on the line
                    if ((i == input.Length - 1 && firstVarName != "" && command != "" && firstNumber != "") && secondVarName == "")
                    {
                        CommandEquals(firstVarName, aritOperator, int.Parse(firstNumber));
                        firstVarName = "";
                        secondVarName = "";
                        aritOperator = "";
                        command = "";
                        firstNumber = "";
                    }
                    // Get arithmetic operator
                    else if (firstVarName != "" && (currentChar == '-' || currentChar == '+'))
                    {
                        aritOperator = currentChar.ToString();
                    }
                    // Get second number or variable
                    else if (aritOperator != "" && firstVarName != "" && command != "")
                    {
                        if (currentChar == 'V' || currentChar == 'W' || currentChar == 'X' ||
                        currentChar == 'Y' || currentChar == 'Z')
                        {
                            secondVarName = currentChar.ToString();
                        }
                        else
                        {
                            secondNumber += currentChar;
                        }
                    }
                    // IF there is more than one variable or number
                    if (i == input.Length - 1 && firstVarName != "" && command != "" && firstNumber != "" && secondVarName == "")
                    {
                        CommandEquals(firstVarName, aritOperator, int.Parse(firstVarName), int.Parse(secondNumber));
                        firstVarName = "";
                        secondVarName = "";
                        aritOperator = "";
                        command = "";
                        firstNumber = "";
                    }
                }
            }
        }
    }
}
