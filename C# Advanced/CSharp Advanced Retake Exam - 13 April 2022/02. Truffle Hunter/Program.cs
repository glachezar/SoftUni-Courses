using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] forest = new char[size, size];

            Dictionary<char, int> peterHarvested = new Dictionary<char, int>
            {
                {'B', 0 },
                {'S', 0 },
                {'W', 0 },
            };

            int boarEatenTrufflesCount = 0;

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    forest[row, col] = input[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "Stop the hunt") break;
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Collect")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                   
                    Harvester(row, col, forest, peterHarvested);
                }
                else if (tokens[0] == "Wild_Boar")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    string direction = tokens[3];
                    Boar(row, col, direction, ref boarEatenTrufflesCount, forest);
                }
            }

            Console.WriteLine($"Peter manages to harvest {peterHarvested['B']} black, {peterHarvested['S']} summer, and {peterHarvested['W']} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarEatenTrufflesCount} truffles.");
            PrintMatrix(forest);
            
        }

        static void Boar(int row, int col, string direction, ref int boarEatenTrufflesCount, char[,] forest)
        {
            int size = forest.GetLength(0);
            while (row >= 0 && row < size && col >= 0 && col < size)
            {
                if (forest[row, col] != '-')
                {
                    boarEatenTrufflesCount++;
                    forest[row, col] = '-';
                }
                switch (direction)
                {
                    case "up": row -= 2; break;
                    case "down": row += 2; break;
                    case "left": col -= 2; break;
                    case "right": col += 2; break;
                }
            }

        }

        static void Harvester(int row, int col, char[,] forest, Dictionary<char, int> harvestResult)
        {
            if (forest[row, col] == 'B')
            {
                harvestResult['B']++;
                forest[row, col] = '-';
            }
            else if (forest[row, col] == 'S')
            {
                harvestResult['S']++;
                forest[row, col] = '-';
            }
            else if (forest[row, col] == 'W')
            {
                harvestResult['W']++;
                forest[row, col] = '-';
            }
        }

        static void PrintMatrix(char[,] forest)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < forest.GetLength(0); row++)
            {
                for (int col = 0; col < forest.GetLength(1); col++)
                {
                    sb.Append($"{forest[row,col]} ");
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
