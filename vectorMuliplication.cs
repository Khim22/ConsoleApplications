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

            product[0] = vectorA[1]*vectorB[2] - vectorA[2]*vectorB[1];
            product[1] = vectorA[2]*vectorB[0] - vectorA[0]*vectorB[2];
            product[2] = vectorA[0]*vectorB[1] - vectorA[1]*vectorB[0];

            return product;
        }

        public static double DotProduct(ref double[] vectorA, ref double[] vectorB)
        {
            double product=0;
            
            for(int i = 0 ; i<3 ; i++){
                product+=vectorA[i]*vectorB[i];
            }

            return product;
        }
    }
}