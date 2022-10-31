using System;
using System.Linq;

namespace _0._3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int result = 0;

            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                    if (row == col)
                    {
                        result += input[col];
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
