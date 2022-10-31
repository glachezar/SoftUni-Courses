using System;
using System.Linq;

namespace _0._1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0, col = n-1; row < n; row++, col--)
            {
                primarySum += matrix[row, row];
                secondarySum += matrix[col, row];
            }

            Console.WriteLine($"{Math.Abs(primarySum - secondarySum)}");
        }
    }
}
