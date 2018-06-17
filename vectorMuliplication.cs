using System;
using System.Linq;

namespace ConsoleAppl
{
    public static class vectorMultiplication
    {

        public static double[] inputVector(string vectorName)
        {
            string[] inputString;
            double[] vector = new double[3];
            Console.WriteLine("Enter the values of the i,j,k vectors of vector {0}, seperated by a comma:", vectorName);
            inputString = Console.ReadLine().Split(',');
            for (int i = 0; i < inputString.Length; i++)
                vector[i] = double.Parse(inputString[i]);
            return vector;
        }

        public static double[] CrossProduct(ref double[] vectorA, ref double[] vectorB)
        {
            double[] product = new double[3];
            for (int i = 0; i < 4; i++)
            {
                
            }

            return product;
        }
    }
}