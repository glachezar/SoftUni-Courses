using System;
using System.Linq;

namespace _0._6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];

            for (int row = 0; row < array.Length; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                array[row] = input;
            }
            //Add {row} {col} {value} – Increase the number at the given coordinates with the value.
            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0] == "END")
                {
                    break;
                }
                string command = tokens[0];
                int inputRow = int.Parse(tokens[1]);
                int inputCol = int.Parse(tokens[2]);
                int number = int.Parse(tokens[3]);

                if (command == "Add")
                {
                    if (inputRow >= 0 && inputRow <= array.Length - 1 && inputCol >= 0 && inputCol < array[inputRow].Length - 1)
                    {
                        array[inputRow][inputCol] += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command == "Subtract")
                {
                    if (inputRow >= 0 && inputRow <= array.Length-1 && inputCol >= 0 && inputCol < array[inputRow].Length - 1)
                    {
                        array[inputRow][inputCol] -= number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int row = 0; row < array.Length; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write($"{array[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
