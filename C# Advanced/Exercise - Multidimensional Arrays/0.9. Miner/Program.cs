using System;
using System.Linq;

namespace _0._9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeMine = int.Parse(Console.ReadLine());

            string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char[,] matrixMine = new char[sizeMine, sizeMine];

            AddMatrixChar(matrixMine);

            int rowPosition = -1;
            int colPosition = -1;
            int totalCoal = 0;
            bool end = false;
            bool coal = false;

            for (int row = 0; row < matrixMine.GetLength(0); row++)
            {
                for (int col = 0; col < matrixMine.GetLength(1); col++)
                {
                    if (matrixMine[row, col] == 's')
                    {
                        rowPosition = row;
                        colPosition = col;
                    }

                    if (matrixMine[row, col] == 'c')
                    {
                        totalCoal++;
                    }

                }
            }

            for (int i = 0; i < comand.Length; i++)
            {
                switch (comand[i])
                {
                    //left, right, up, and down

                    case "left":
                        if (colPosition - 1 >= 0)
                        {
                            colPosition -= 1;
                            if (matrixMine[rowPosition, colPosition] == 'c')
                            {
                                totalCoal--;
                                matrixMine[rowPosition, colPosition] = '*';
                                if (totalCoal == 0)
                                {
                                    coal = true;
                                }
                            }
                            if (matrixMine[rowPosition, colPosition] == 'e')
                            {
                                end = true;
                            }
                        }
                        break;
                    case "right":

                        if (colPosition + 1 < sizeMine)
                        {
                            colPosition += 1;
                            if (matrixMine[rowPosition, colPosition] == 'c')
                            {
                                totalCoal--;
                                matrixMine[rowPosition, colPosition] = '*';
                                if (totalCoal == 0)
                                {
                                    coal = true;
                                }
                            }
                            if (matrixMine[rowPosition, colPosition] == 'e')
                            {
                                end = true;
                            }
                        }

                        break;
                    case "up":

                        if (rowPosition - 1 >= 0)
                        {
                            rowPosition -= 1;
                            if (matrixMine[rowPosition, colPosition] == 'c')
                            {
                                totalCoal--;
                                matrixMine[rowPosition, colPosition] = '*';
                                if (totalCoal == 0)
                                {
                                    coal = true;
                                }
                            }
                            if (matrixMine[rowPosition, colPosition] == 'e')
                            {
                                end = true;
                            }
                        }

                        break;
                    case "down":

                        if (rowPosition + 1 < sizeMine)
                        {
                            rowPosition += 1;
                            if (matrixMine[rowPosition, colPosition] == 'c')
                            {
                                totalCoal--;
                                matrixMine[rowPosition, colPosition] = '*';
                                if (totalCoal == 0)
                                {
                                    coal = true;
                                }
                            }
                            if (matrixMine[rowPosition, colPosition] == 'e')
                            {
                                end = true;
                            }
                        }

                        break;

                }
                if (end || coal)
                {
                    break;
                }
            }

            if (end)
            {
                Console.WriteLine($"Game over! ({rowPosition}, {colPosition})");
            }
            else
            {
                if (coal)
                {
                    Console.WriteLine($"You collected all coals! ({rowPosition}, {colPosition})");
                }
                else
                {
                    Console.WriteLine($"{totalCoal} coals left. ({rowPosition}, {colPosition})");
                }
            }

        }

        static void AddMatrixChar(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
