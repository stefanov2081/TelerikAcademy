using System;
using System.Collections.Generic;
using System.Text;

namespace _03CheckExpression
{
    // I know that this isn't exactly what was expected from the problem,
    // but I've already solved this in Classes and objects, and it checks the parentheses.
    // I decided to include it here. It is an expression calculator.
    class CheckParentheses
    {
        static List<char> arithmeticOperators = new List<char>() { '+', '-', '*', '/' };
        static List<string> arithmeticFunctions = new List<string>() { "ln", "pow", "sqrt" };
        static List<char> brackets = new List<char>() { '(', ')' };

        // Remove all whitespace
        static string RemoveWhitespace(string input)
        {
            input = input.Trim();
            input = input.Replace(" ", "");

            return input;
        }

        // Separate all tokens
        static List<string> SeparateTokens(string input)
        {
            List<string> result = new List<string>();
            StringBuilder number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                // Separate numbers
                if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
                {
                    number.Append(input[i]);
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                // Separate arithmetic operators
                else if (arithmeticOperators.Contains(input[i]) && !arithmeticOperators.Contains(input[i - 1]))
                {
                    result.Add(input[i].ToString());
                }
                // Separate brackets
                else if (brackets.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                // Separate comma
                else if (input[i] == ',')
                {
                    result.Add(input[i].ToString());
                }
                // Separate arithmetic functions
                else if (i + 1 < input.Length && arithmeticFunctions.Contains(input.Substring(i, 2)))
                {
                    result.Add(input.Substring(i, 2));
                    i++;
                }
                else if (i + 2 < input.Length && arithmeticFunctions.Contains(input.Substring(i, 3)))
                {
                    result.Add(input.Substring(i, 3));
                    i += 2;
                }
                else if (i + 3 < input.Length && arithmeticFunctions.Contains(input.Substring(i, 4)))
                {
                    result.Add(input.Substring(i, 4));
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid input: Invalid expression!");
                }
            }

            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }

            return result;
        }

        // Get operator precedence
        static int OperatorPrecedence(string input)
        {
            if (input == "+" || input == "-")
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        // Convert the tokens into a queue - Shunting-yard Algorithm
        static Queue<string> ConvertToReversePolishNotation(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> outputQueue = new Queue<string>();
            double currentNumber;
            string currentToken;

            // While there are tokens to be read:
            for (int i = 0; i < tokens.Count; i++)
            {
                // Read a token.
                currentToken = tokens[i];
                double.TryParse(currentToken, out currentNumber);

                // If the token is a number, then add it to the output queue.
                if (double.TryParse(currentToken, out currentNumber))
                {
                    outputQueue.Enqueue(currentToken);
                }
                // If the token is a function token, then push it onto the stack.
                else if (arithmeticFunctions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                // If the token is a function argument separator (e.g., a comma):
                else if (currentToken == ",")
                {
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid input: Missmatched parenthesis or invalid function separator!");
                    }

                    // Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue. 
                    // If no left parentheses are encountered, either the separator was misplaced or parentheses were mismatched.
                    while (stack.Peek() != "(")
                    {
                        outputQueue.Enqueue(stack.Pop());
                    }
                }

                // If the token is an operator, o1, then:
                else if (arithmeticOperators.Contains(currentToken[0]))
                {
                    // while there is an operator token, o2, at the top of the stack, and
                    // either o1 is left-associative and its precedence is equal to that of o2,x
                    // or o1 has precedence less than that of o2,
                    while (stack.Count != 0 && arithmeticOperators.Contains(stack.Peek()[0]) &&
                        OperatorPrecedence(currentToken) <= OperatorPrecedence(stack.Peek()))
                    {
                        // pop o2 off the stack, onto the output queue;
                        outputQueue.Enqueue(stack.Pop());
                    }

                    // push o1 onto the stack.
                    stack.Push(currentToken);
                }

                // If the token is a left parenthesis, then push it onto the stack.
                else if (currentToken == "(")
                {
                    stack.Push(currentToken);
                }

                // If the token is a right parenthesis:
                else if (currentToken == ")")
                {
                    // If the stack runs out without finding a left parenthesis, then there are mismatched parentheses.
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid input: Missmatched parenthesis!");
                    }

                    // Until the token at the top of the stack is a left parenthesis, pop operators off the stack onto the output queue.
                    while (stack.Peek() != "(")
                    {
                        outputQueue.Enqueue(stack.Pop());
                    }

                    // Pop the left parenthesis from the stack, but not onto the output queue.
                    stack.Pop();

                    // If the token at the top of the stack is a function token, pop it onto the output queue.
                    if (stack.Count != 0 && arithmeticFunctions.Contains(stack.Peek()))
                    {
                        outputQueue.Enqueue(stack.Pop());
                    }
                }
            }

            // When there are no more tokens to read
            // While there are still operator tokens in the stack:
            while (stack.Count != 0)
            {
                // If the operator token on the top of the stack is a parenthesis, then there are mismatched parentheses.
                if (brackets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid input: Missmatched parenthesis!");
                }

                // Pop the operator onto the output queue.
                outputQueue.Enqueue(stack.Pop());
            }

            return outputQueue;

        }

        // Calculate the final result with theReverse Polish Notation
        static double CalculateExpression(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();
            double currentNumber;
            double result;
            double n1;
            double n2;

            // While there are input tokens left 
            while (queue.Count != 0)
            {
                // Read the next token from input.
                string currentToken = queue.Dequeue();

                // If the token is a value
                if (double.TryParse(currentToken, out currentNumber))
                {
                    // Push it onto the stack.
                    stack.Push(currentNumber);
                }
                // Otherwise, the token is an operator (operator here includes both operators and functions). 
                else if (arithmeticOperators.Contains(currentToken[0]) || arithmeticFunctions.Contains(currentToken))
                {
                    // It is known a priori that the operator takes n arguments.
                    if (currentToken[0] == '+')
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 2)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();
                            n2 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = n1 + n2;

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                    else if (currentToken[0] == '-')
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 2)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();
                            n2 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = n2 - n1;

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                    else if (currentToken[0] == '*')
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 2)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();
                            n2 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = n2 * n1;

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                    else if (currentToken[0] == '/')
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 2)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();
                            n2 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = n2 / n1;

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                    else if (currentToken == "ln")
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 1)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = Math.Log(n1);

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                    else if (currentToken == "pow")
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 2)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();
                            n2 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = Math.Pow(n2, n1);

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                    else if (currentToken == "sqrt")
                    {
                        // If there are fewer than n values on the stack 
                        if (stack.Count < 1)
                        {
                            // (Error) The user has not input sufficient values in the expression.
                            throw new ArgumentException("Invalid input: Input sufficient values in the expression!");
                        }
                        // Else, Pop the top n values from the stack.
                        else
                        {
                            n1 = stack.Pop();

                            // Evaluate the operator, with the values as arguments.
                            result = Math.Sqrt(n1);

                            // Push the returned results, if any, back onto the stack.
                            stack.Push(result);
                        }
                    }
                }
            }
            // If there is only one value in the stack 
            if (stack.Count == 1)
            {
                // That value is the result of the calculation.
                return stack.Pop();
            }
            // Otherwise, there are more values in the stack 
            else
            {
                // (Error) The user input has too many values.
                throw new ArgumentException("Invalid input: Too many or too few values!");
            }
        }

        // Run the program
        static void Run()
        {
            string input = "";
            while (input.ToLower() != "exit")
            {
                input = Console.ReadLine();
                if (input.ToLower() != "exit")
                {
                    // If exceptions occur => print error message
                    try
                    {
                        Console.WriteLine("= " + CalculateExpression(ConvertToReversePolishNotation(SeparateTokens(RemoveWhitespace(input)))));
                    }
                    catch (ArgumentException errors)
                    {
                        Console.WriteLine(errors.Message);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new string('_', 29) + "Expression calculator" + new string('_', 30));
            Run();
        }
    }
}
