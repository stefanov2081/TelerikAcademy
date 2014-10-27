using System;
using System.Text;

namespace _06OverloadClassMatrix
{
    class Matrix
    {
        public int row;
        public int col;
        private int[,] matrix;

        // Default constructor
        public Matrix(int x, int y)
        {
            matrix = new int[x, y];
            row = x;
            col = y;
        }

        // Set value of matrix
        public int this[int x, int y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

        // Add matrices
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1.row, matrix1.col);
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix;
        }

        // Subtract matrices
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1.row, matrix1.col);
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    matrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return matrix;
        }

        // Multiply matrices
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1.row, matrix1.col);
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.col; j++)
                {
                    for (int k = 0; k < matrix.row; k++)
                    {
                        matrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return matrix;
        }

        // Ovveride ToString()
        public override string ToString()
        {
            StringBuilder matrixToString = new StringBuilder();
            for (int i = 0; i < this.col; i++)
            {
                for (int j = 0; j < this.row; j++)
                {
                    matrixToString.AppendFormat("{0,5}", this[i, j]);
                }
                matrixToString.AppendFormat("\n");
            }
            return matrixToString.ToString();
        }
    }
    class OverloadClassMatrix
    {
        static void Main(string[] args)
        {
            // Get value from user input
            Console.WriteLine(new string('_', 80));
            Console.WriteLine(new string(' ', 16) + "This program creates custom class Matrix that adds,");
            Console.WriteLine(new string(' ', 22) + "subtracts and multiplies matrices.");
            Console.WriteLine(new string('_', 80));
            Console.WriteLine();
            string userInput = "";
            int n;
            int m;

            // Infinite loop to do different stuff with different matrices
            while (userInput != "quit")
            {
                Console.WriteLine("If you want to add two matrices, type: add.");
                Console.WriteLine("If you want to subtract two matrices, type: subtract.");
                Console.WriteLine("If you want to multiply two matrices, type: multiply.");
                Console.WriteLine("To exit type: quit.");
                Console.Write("Input: ");
                userInput = Console.ReadLine();

                if (userInput == "add")
                {
                    Console.WriteLine(new string('*',50));
                    Console.WriteLine("To add two matrices, their height and width must be equal! \nExample:");
                    Console.WriteLine("|1 2| \n|3 4| \n  + (plus)");
                    Console.WriteLine("|1 2| \n|3 4| \n");
                    Console.WriteLine("Enter height of matrix:");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width of matrix:");
                    m = int.Parse(Console.ReadLine());
                    Matrix array1 = new Matrix(n, m);
                    Matrix array2 = new Matrix(n, m);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine("Enter matrix 1 element[{0}, {1}]:", i, j);
                            array1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine("Enter matrix 2 element[{0}, {1}]:", i, j);
                            array2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("First matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0,5}", array1[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Second matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0,5}",array2[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nResult:");
                    Console.WriteLine(array1 + array2);
                    Console.WriteLine(new string('*', 50));
                }
                else if (userInput == "subtract")
                {
                    Console.WriteLine(new string('*', 50));
                    Console.WriteLine("To subtract two matrices, their height and width must be equal! \nExample:");
                    Console.WriteLine("|1 2| \n|3 4| \n  - (minus)");
                    Console.WriteLine("|1 2| \n|3 4| \n");
                    Console.WriteLine("Enter height of matrix:");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width of matrix:");
                    m = int.Parse(Console.ReadLine());
                    Matrix array1 = new Matrix(n, m);
                    Matrix array2 = new Matrix(n, m);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine("Enter matrix 1 element[{0}, {1}]:", i, j);
                            array1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine("Enter matrix 2 element[{0}, {1}]:", i, j);
                            array2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("First matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0,5}", array1[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Second matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0,5}", array2[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nResult:");
                    Console.WriteLine(array1 - array2);
                    Console.WriteLine(new string('*', 50));
                }
                else if (userInput == "multiply")
                {
                    Console.WriteLine(new string('*', 50));
                    Console.WriteLine("To multiply two matrices, their height and width must be equal! \nExample:");
                    Console.WriteLine("|1 2| \n|3 4| \n  * (times)");
                    Console.WriteLine("|1 2| \n|3 4| \n");
                    Console.WriteLine("Enter height of matrix:");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width of matrix:");
                    m = int.Parse(Console.ReadLine());
                    Matrix array1 = new Matrix(n, m);
                    Matrix array2 = new Matrix(n, m);
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine("Enter matrix 1 element[{0}, {1}]:", i, j);
                            array1[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine("Enter matrix 2 element[{0}, {1}]:", i, j);
                            array2[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("First matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0,5}", array1[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Second matrix:");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0,5}", array2[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nResult:");
                    Console.WriteLine(array1 * array2);
                    Console.WriteLine(new string('*', 50));
                }
            }
        }
    }
}
