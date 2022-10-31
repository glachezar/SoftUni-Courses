using System;
using System.Linq;

namespace _0._2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeRowCol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[sizeRowCol[0], sizeRowCol[1]];

            for (int row = 0; row < sizeRowCol[0]; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < sizeRowCol[1]; col++)
                {
                    matrix[row, col] = input[col];
                }

            }

            int count = 0;


            for (int row = 0; row < sizeRowCol[0] - 1; row++)
            {

                for (int col = 0; col < sizeRowCol[1] - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            

            Console.WriteLine(count);
        }
    }
}
