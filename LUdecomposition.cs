using System;


namespace ConsoleAppl
{
    public static class LUdecomposition{


        public static void findLU(ref double[,] L, ref double[,] U, double[,] A){
            Boolean isSquare = A.GetLength(0)==A.GetLength(1)? true : false ;

            if(isSquare){
                int size = A.GetLength(0);
                L= new double[size,size];
                U= new double[size,size];
                Array.Clear(L,0,size*size);
                Array.Clear(U,0,size*size);

                findUpper(ref L, ref U, size, A);
                findLower(ref L, ref U, size, A);
            }
      
        }

        private static double[,] findUpper(ref double[,] L, ref double[,] U, int size, double[,] A){
            for (int i = 0; i<size; i++){
                for(int k=i; k<size;k++){
                    double sum=0;
                    for(int j=0; j<i;j++){
                        sum+= (L[i,j]*U[j,k]);
                    }
                    U[i,k]= A[i,k] - sum;
                }
            }
            return U;
        }

        private static double[,] findLower(ref double[,] L, ref double[,] U, int size, double[,] A){
            for (int i = 0; i<size; i++){
                for(int k=i; k<size;k++){
                    if(i==k)
                        L[i,i]=1;
                    else{
                        double sum=0;
                        for(int j=0; j<i;j++){
                            sum+= (L[k,j]*U[j,i]);
                        }
                        L[k,i]= (A[k,i] - sum)/ U[i,i];
                    }                   
                }
            }
            return L;
        }
    }
}