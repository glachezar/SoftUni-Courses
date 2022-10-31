using System;
using System.Linq;

namespace _0._6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedMatrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                jaggedMatrix[row] = input;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedMatrix[row].Length == jaggedMatrix[row+1].Length )
                {
                    for (int col = 0; col < jaggedMatrix[row].Length; col++)
                    {
                        jaggedMatrix[row][col] *= 2;
                        jaggedMatrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedMatrix[row].Length; col++)
                    {
                        jaggedMatrix[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedMatrix[row+1].Length; col++)
                    {
                        jaggedMatrix[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string commnad = Console.ReadLine();

                if (commnad == "End")
                {
                    break;
                }

                string[] tokens = commnad.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var row = int.Parse(tokens[1]);
                var col = int.Parse(tokens[2]);
                var value = double.Parse(tokens[3]);

                if (tokens[0] == "Add")
                {
                    if (row >= 0 && row < jaggedMatrix.Length && col >= 0 && col < jaggedMatrix[row].Length)
                    {
                        
                        jaggedMatrix[row][ col] += value;
                    }
                }
                else if (tokens[0] == "Subtract")
                {
                    if (row >= 0 && row < jaggedMatrix.Length && col >= 0 && col < jaggedMatrix[row].Length)
                    {
                        ;
                        jaggedMatrix[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    Console.Write($"{jaggedMatrix[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
