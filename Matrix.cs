using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        private int rows;
        private int columns;
        private int[,] matrix;

        public Matrix()
        {
            Console.WriteLine("Enter the Number of Rows");
            this.rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of Columns");
            this.columns = Convert.ToInt32(Console.ReadLine());
            if(rows < 1 && columns < 1)
            {
                Console.WriteLine("The Number of Rows or Columns are less than 1");
                return;
            }
            matrix = new int[rows, columns];
            Console.WriteLine("Enter the Elements of array");

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    this.matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }

        public void printMatrix()
        {
            for(int i = 0; i < this.rows; i++)
            {
                for(int j = 0; j < this.columns; j++)
                {
                    Console.Write(this.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Matrix addMatrix(Matrix matrix1, Matrix matrix2)
        {
            if(matrix1.rows == matrix2.rows && matrix1.columns == matrix2.columns)
            {
                for (int i = 0; i < matrix1.rows; i++)
                {
                    for(int j = 0; j < matrix1.columns; j++)
                    {
                        matrix1.matrix[i, j] = matrix1.matrix[i, j] + matrix2.matrix[i, j];
                    }
                }
                return matrix1;
            }
            else
            {
                Console.WriteLine("Number of Rows or Columns of Matrix are not equal cannot Add Matrices");
                return null;
            }
            
        }

        public Matrix multiplyMatrix(Matrix matrix1, Matrix matrix2)
        {
            Matrix matrix = new Matrix(matrix1.rows, matrix2.columns);
            if(matrix1.columns == matrix2.rows)
            {
                int sum;
                for(int i = 0; i < matrix.rows; i++)
                {
                    for(int j = 0; j < matrix.columns; j++)
                    {
                        matrix.matrix[i, j] = 0;
                    }
                }
                for (int i = 0; i < matrix1.rows; i++)    //row of first matrix
                {
                    for (int j = 0; j < matrix2.columns; j++)    //column of second matrix
                    {
                        sum = 0;
                        for (int k = 0; k < matrix1.columns; k++)
                            sum = sum + matrix1.matrix[i, k] * matrix2.matrix[k, j];
                        matrix.matrix[i, j] = sum;
                    }
                }
                return matrix;
            }
            else
            {
                Console.WriteLine("Cannot Multiply the following Matrices");
                return null;
            }
            
            
        }
    }
}
