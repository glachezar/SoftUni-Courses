using System;

namespace _02.Wall_Destroyer
{
    internal class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] wall = new char[matrixSize, matrixSize];

            int currRow = 0;
            int currCol = 0;
            bool isVankoElectrocuted = false;
            
            for (int row = 0; row < matrixSize; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrixSize; col++)
                {
                    wall[row, col] = input[col];

                    if (input[col] == 'V')
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            wall[currRow, currCol] = '*';
            int holeCounter = 1;
            int rodCounter = 0;

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                int oldRow = currRow;
                int oldCol = currCol;

                switch (command)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                }

                if (currRow >= 0 && currRow < matrixSize && currCol >= 0 && currCol < matrixSize)
                {
                    if (wall[currRow, currCol] == '-')
                    {
                        wall[currRow, currCol] = '*';
                        holeCounter++;
                    }
                    else if (wall[currRow, currCol] == 'R')
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        rodCounter++;
                        currRow = oldRow;
                        currCol = oldCol;
                    }
                    else if (wall[currRow, currCol] == '*')
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCol}]!");
                    }
                    else if (wall[currRow, currCol] == 'C')
                    {
                        wall[currRow, currCol] = 'E';
                        holeCounter++;
                        isVankoElectrocuted = true;
                        Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
                        break;
                    }
                }
                else
                {
                    currRow = oldRow;
                    currCol = oldCol;
                }
            }

            if (!isVankoElectrocuted)
            {
                wall[currRow, currCol] = 'V';
                Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {rodCounter} rod(s).");
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(wall[row,col]);
                }

                Console.WriteLine();
            }
        }
    } 
}
