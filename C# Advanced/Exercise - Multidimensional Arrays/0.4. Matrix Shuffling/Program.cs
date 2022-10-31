using System;
using System.Linq;
using System.Threading.Channels;

namespace _0._4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeRowCol = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] matrix = new string[sizeRowCol[0], sizeRowCol[1]];

            for (int row = 0; row < sizeRowCol[0]; row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < sizeRowCol[1]; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                {
                    break;
                }

                //bool isValidCommand = true;
                if (IsCommandCorrect(command, sizeRowCol))
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row,col]} ");
                        }

                        Console.WriteLine();
                    }
                }
                else if(!IsCommandCorrect(command, sizeRowCol))
                {
                    Console.WriteLine("Invalid input!");
                }

                
            }
            //You should swap the values at the given coordinates (cell [row1, col1] with cell [row2, col2])
        }

        static bool IsCommandCorrect(string[] command, int[] sizeRowCol)
        {
            
            //int row1 = int.Parse(command[1]);
            //int col1 = int.Parse(command[2]);
            //int row2 = int.Parse(command[3]);
            //int col2 = int.Parse(command[4]);
            return
                command[0] == "swap"
                && command.Length == 5
                && int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= sizeRowCol[0] && int.Parse(command[3]) >= 0 && int.Parse(command[3]) <= sizeRowCol[0]
                && int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= sizeRowCol[0] && int.Parse(command[4]) >= 0 && int.Parse(command[4]) <= sizeRowCol[0];
        }
    }
}
