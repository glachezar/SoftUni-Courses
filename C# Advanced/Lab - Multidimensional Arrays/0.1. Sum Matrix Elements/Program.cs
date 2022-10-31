using System;
using System.Linq;

namespace _0._1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];
            int result = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                    result += input[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(result);
            //int matrixRows = matrix.GetLength(0);
            //int matrixCols = matrix.GetLength(1);
            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    for (int col = 0; col < matrixCols; col++)
            //    {
            //        Console.Write($"{matrix[row,col]} ");
            //    }

            //    Console.WriteLine();
            //}
            
        }
    }
}
