using System;
using System.Linq;

namespace ConsoleAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[1, 1];
            double[,] B = new double[1, 1];
            double[,] result;
            Console.WriteLine("Hello World!");

            do
            {
                InputMatrix("A", ref A);
                InputMatrix("B", ref B);
            }
            while (A.GetLength(1) != B.GetLength(0));

            result = new double[A.GetLength(1), B.GetLength(0)];

            result = MultiplyMatrix(ref A, ref B);

            PrintMatrix("C", ref result);
        }

        public static void InputMatrix(String matrixName, ref double[,] matrix)
        {

            int NumOfRow;
            int NumOfCol;
            string[] inputString;
            double[,] values;

            Console.WriteLine("Enter the number of rows of matrix {0}:", matrixName);
            NumOfRow = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns of matrix {0}:", matrixName);
            NumOfCol = Int32.Parse(Console.ReadLine());

            values = new double[NumOfRow, NumOfCol];

            for (int i = 0; i < NumOfRow; i++)
            {
                Console.WriteLine("Enter the values of the {0} row of matrix {1}, seperated by a comma:", i, matrixName);
                inputString = (Console.ReadLine()).Split(',');
                for (int j = 0; j < inputString.Length; j++)
                    values[i, j] = double.Parse(inputString[j]);
            }

            PrintMatrix(matrixName, ref values);
            matrix = values;
        }

        public static void PrintMatrix(String matrixName, ref double[,] matrix)
        {
            Console.WriteLine("Confirm the matrix {0}:", matrixName);
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j]);
                    if (j < matrix.GetLength(0) - 1) Console.Write(",");
                }
                Console.Write("|\n");
            }
        }

        public static double[,] MultiplyMatrix(ref double[,] matrixA, ref double[,] matrixB)
        {
            double[,] result = new double[matrixA.GetLength(1), matrixB.GetLength(0)];

            for (int i = 0; i < matrixA.GetLength(1); i++)
            {
                for (int j = 0; j < matrixB.GetLength(0); j++)
                {
                    double sum = 0;
                    for (int k = 0; k < matrixA.GetLength(0); k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
    }
}
