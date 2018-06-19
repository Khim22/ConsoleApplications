using System;

namespace ConsoleAppl{

    public static class InverseMatrix{

        public static double[,] findInverse(ref double[,] matrix){
            int size = matrix.GetLength(0);
            double[,] result = new double[size,size];

            if(matrix.GetLength(0)!=matrix.GetLength(1))
                return null;
            
            else{
                //making the [0,0] value non zero
                for(int i=0 ; i<size;i++){
                    result[i,i]=0;
                    while(matrix[0,0]==0){
                        double temp;
                        double temp2;
                        for(int j=1; j<size;j++){
                            temp = matrix[i,j];
                            temp2 = result[i,j];
                            if(i<size){
                                matrix[i,j]= matrix[i+1,j];
                                matrix[i+1,j] = temp;
                                result[i,j]= result[i+1,j];
                                result[i+1,j] = temp2;
                            }
                            else if (i==size){
                                matrix[i,j]= matrix[0,j];
                                matrix[0,j] = temp;
                                result[i,j]= result[0,j];
                                result[0,j] = temp2;
                            }
                        }
                    }
                }

                //making [0,0] value equals 1
                for(int i=0;i<size;i++){
                    matrix[0,i]=matrix[0,i]/matrix[0,0];
                    result[0,i] = result[0,i]/ matrix[0,0];
                    if(matrix[0,0]<0){
                        matrix[0,i]*=-1;
                        result[0,i]*=-1;
                    }
                }
                //making [1,0] equal 0
                for(int i = 0; i<size;i++){
                    matrix[1,i] = matrix[1,i] - matrix[1,0]; 
                }
                    
                return result;

            }
        }
    }
}