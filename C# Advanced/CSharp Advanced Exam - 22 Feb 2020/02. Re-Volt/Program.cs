using System;
using System.Data;
using System.Drawing;
using System.Threading;

namespace _02._Re_Volt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());

            char[,] track = new char[size, size];
            Player player = new Player();

            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    track[row, col] = input[col];
                    if (input[col] == 'f')
                    {
                        player.Row = row;
                        player.Col = col;
                    }
                }
            }


            for (int i = 0; i < numberOfMoves; i++)
            {
                string command = Console.ReadLine();

                player.Move(command, track);

                if(player.PlayerWon == true) break;
                
            }
            
            
            track[player.Row, player.Col] = 'f';

            if (player.PlayerWon == true) Console.WriteLine("Player won!");

            else Console.WriteLine("Player lost!");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(track[row, col]);
                }

                Console.WriteLine();
            }

        }

        class Player
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public bool PlayerWon { get; set; }

            public void Move(string command, char[,] track)
            {
                int size = track.GetLength(0);
                if (track[this.Row, this.Col] != 'B') track[this.Row, this.Col] = '-';

                int newRowIndex = this.Row;
                int newColIndex = this.Col;

                switch (command)
                {
                    case "up": newRowIndex--; break;
                    case "down": newRowIndex++; break;
                    case "left": newColIndex--; break;
                    case "right": newColIndex++; break;
                }

                if (newRowIndex < 0) newRowIndex = size - 1;
                if (newRowIndex == size) newRowIndex = 0;
                if (newColIndex < 0) newColIndex = size - 1;
                if (newColIndex == size) newColIndex = 0;

                char symbol = track[newRowIndex, newColIndex];

                if (symbol == 'T') return;

                else if (symbol == 'B')
                {
                    this.Row = newRowIndex;
                    this.Col = newColIndex;
                    Move(command, track);
                    return;
                }

                else if (symbol == 'F') this.PlayerWon = true;

                this.Row = newRowIndex;
                this.Col = newColIndex;
            }
        }
    }
}
