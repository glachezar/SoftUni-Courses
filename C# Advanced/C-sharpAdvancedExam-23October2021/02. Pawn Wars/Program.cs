using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _02._Pawn_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];

            int whiteRow = 0;
            int whiteCol = 0;

            int blackRow = 0;
            int blackCol = 0 ;


            int[] currBlackPownPosition = new int[2];

            for (int row = 0; row < 8; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < 8; col++)
                {
                    board[row,col] = input[col];

                    if (input[col] == 'w')
                    {
                        whiteRow = row;
                        whiteCol = col;
                    }
                    else if (input[col] == 'b')
                    {
                        blackRow = row;
                        blackCol = col;
                    }

                }
            }

            bool whiteTurn = true;

            while (true)
            {

                if (whiteTurn)
                {

                    if (whiteRow == 0)
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(97 + whiteCol)}8.");
                        return;
                    }

                    if (IsValidPosition(whiteRow - 1, whiteCol - 1, board) && board[whiteRow - 1, whiteCol - 1] == 'b')
                    {
                        whiteRow --;
                        whiteCol --;

                        Console.WriteLine($"Game over! White capture on {(char)(97 + whiteCol)}{8 - whiteRow}.");
                        return;
                    }
                    if (IsValidPosition(whiteRow - 1, whiteCol + 1, board) && board[whiteRow - 1, whiteCol + 1] == 'b')
                    {
                        whiteRow--;
                        whiteCol++;

                        Console.WriteLine($"Game over! White capture on {(char)(97 + whiteCol)}{8 - whiteRow}.");
                        return;
                    }

                    whiteRow--;
                    board[whiteRow, whiteCol] = 'w';

                }
                else
                {
                    if (blackRow == 7)
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(97 + blackCol)}1.");
                        return;
                    }
                    if (IsValidPosition(blackRow + 1, blackCol - 1, board) && board[blackRow + 1, blackCol - 1] == 'w')
                    {
                        blackRow++;
                        blackCol--;

                        Console.WriteLine($"Game over! Black capture on {(char)(97 + blackCol)}{8 - blackRow }.");
                        return;
                    }
                    if (IsValidPosition(blackRow + 1, blackCol + 1, board) && board[blackRow + 1, blackCol + 1] == 'w')
                    {
                        blackRow++;
                        blackCol++;

                        Console.WriteLine($"Game over! Black capture on {(char)(97 + blackCol)}{8 - blackRow}.");
                        return;
                    }

                    blackRow++;
                    board[blackRow, blackCol] = 'b';
                }

                whiteTurn = !whiteTurn;
            }
        }

        static bool IsValidPosition(int row, int col, char[,] board)
        {
            return row >= 0
                   && row < board.GetLength(0)
                   && col >= 0
                   && col < board.GetLength(1);

        }


    }
}
