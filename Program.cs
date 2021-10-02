using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            int[,] array;
            
            matrix1 = matrix1.multiplyMatrix(matrix1, matrix2);
            if(matrix1 != null)
            {
                matrix1.printMatrix();
            }
            

        }
    }
}
