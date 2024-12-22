using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySection2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtaining the size of the matrix
            Console.WriteLine("Please enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] nums = new int[rows, cols];

            FillMatrix(ref nums);
            DisplayMatrix(nums);
            l();
            DisplayMatrix(TransposeMatrix(nums));
            l();
            int sum = SumMatrix(nums);
            int max = MaxMatrix(nums);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Max: " + max);
            l();
            Console.ReadKey();
        }

        // Filling the matrix
        static void FillMatrix(ref int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Row {i + 1}: ");

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Displaying the matrix
        static void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("[");

                for (int j = 0; j < cols; j++)
                {
                    if (j == cols - 1) Console.Write(matrix[i, j]);
                    else Console.Write("{0}, ", matrix[i, j]);
                }

                Console.Write("]");
                Console.WriteLine();
            }
        }

        // Summing the matrix
        static int SumMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        static int MaxMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int max = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max) max = matrix[i, j];
                }
            }

            return max;
        }
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed;
        }

        static void l()
        {
            Console.WriteLine("-------------");
        }
    }
}



