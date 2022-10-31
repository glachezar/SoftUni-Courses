using System;
using System.Linq;

namespace _0._5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];
            var maxSum = 0;
            var squareStartRow = -1;
            var squareStartCol = -1;

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];

                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var sum = matrix[row, col] +
                                       matrix[row + 1, col] +
                                       matrix[row, col + 1] +
                                       matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        squareStartRow = row;
                        squareStartCol = col;
                        maxSum = sum;
                    }
                }
            }

            for (int row = squareStartRow; row < squareStartRow +2; row++)
            {
                for (int col = squareStartCol; col < squareStartCol + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();

            }
            Console.WriteLine(maxSum);

            
        }
    }
}
