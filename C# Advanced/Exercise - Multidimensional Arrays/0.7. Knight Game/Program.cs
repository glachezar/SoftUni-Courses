using System;

namespace _0._7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeMatrix, sizeMatrix];

            AddMatrixChar(matrix);

            int outputResult = 0;
            while (true)
            {
                int counerMax = 0;
                int rowMax = 0;
                int colMax = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        if (matrix[row, col] != 'K')
                        {
                            continue;
                        }
                        int count = GameKnight(matrix, row, col);
                        if (count > counerMax)
                        {
                            counerMax = count;
                            rowMax = row;
                            colMax = col;
                        }
                    }
                }
                if (counerMax == 0)
                {
                    break;
                }
                else
                {
                    outputResult++;
                    matrix[rowMax, colMax] = 'O';
                }
            }

            Console.WriteLine(outputResult);
        }



        static void AddMatrixChar(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }

        static int GameKnight(char[,] matrix, int row, int col)
        {
            int counter = 0;

            int row1 = 0;
            int col1 = 0;

            row1 = row - 2;
            col1 = col + 1;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }

            row1 = row - 1;
            col1 = col + 2;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }
            row1 = row + 1;
            col1 = col + 2;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }
            row1 = row + 2;
            col1 = col + 1;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }
            row1 = row + 2;
            col1 = col - 1;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }
            row1 = row + 1;
            col1 = col - 2;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }
            row1 = row - 1;
            col1 = col - 2;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }
            row1 = row - 2;
            col1 = col - 1;
            if (row1 >= 0 && col1 >= 0 && row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1) && matrix[row1, col1] == 'K')
            {
                counter++;
            }


            return counter;
        }
    }
}
