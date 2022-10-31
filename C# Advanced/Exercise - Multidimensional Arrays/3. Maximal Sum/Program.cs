using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeRowCol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[sizeRowCol[0], sizeRowCol[1]];

            for (int row = 0; row < sizeRowCol[0]; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < sizeRowCol[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = 0;
            int startRow = -1;
            int startCol = -1;

            for (int row = 0; row < sizeRowCol[0]-2; row++)
            {
                for (int col = 0; col < sizeRowCol[1]-2; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col+1] + matrix[row, col +2] +
                                  matrix[row+1, col] + matrix[row+1, col+1] + matrix[row +1, col+2]+
                                  matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
