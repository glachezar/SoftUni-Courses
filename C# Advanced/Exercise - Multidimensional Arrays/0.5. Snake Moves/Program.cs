using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeRowCol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[sizeRowCol[0], sizeRowCol[1]];
            Queue<char> snake = new Queue<char>(Console.ReadLine().ToCharArray());


            for (int row = 0; row < sizeRowCol[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < sizeRowCol[1]; col++)
                    {
                        matrix[row, col] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());
                    }
                }
                else
                {
                    for (int col = sizeRowCol[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake.Peek();
                        snake.Enqueue(snake.Dequeue());
                    }
                }
            }

            for (int row = 0; row < sizeRowCol[0]; row++)
            {
                for (int col = 0; col < sizeRowCol[1]; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
