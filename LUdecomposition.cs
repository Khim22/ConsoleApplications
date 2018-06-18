using System;


namespace ConsoleAppl
{
    public static class LUdecomposition{
        public static double[,] findLower(ref double[,] A){


            return A;
        }

        public static void findLU(ref double[,] L, ref double[,] U, double[,] A){
            Boolean isSquare = A.GetLength(0)==A.GetLength(1)? true : false ;

            if(isSquare){
                int size = A.GetLength(0);

        
                for(int i =0; i< size; i++){
                    U[0,i] = A[0,i];
                    L[i,0] = A[i,0] / U[0,0];

                    if(i>0 && i< size - 2){

                        double sum = 0;
                        double sum2 = 0;
                        for(int j = i+1; j< size -1;j++){
                            for(int k = 0; k< i - 2;k++){
                            
                                sum+=L[i,k]*U[k,j];
                                sum2+= L[j,k]*U[k,j]; 
                            }
                            U[i,i] = A[i,i] - sum;
                            U[i,j] = A[i,j] - sum;
                            L[j,i] = (A[j,i] - sum2)/U[i,i] ;
                        }
                    }

                }
                U[size -1 , size -1] = A[size -1 , size -1 ];
            }
      
        }
    }
}