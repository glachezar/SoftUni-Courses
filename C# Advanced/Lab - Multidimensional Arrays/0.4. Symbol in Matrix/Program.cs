using System;
using System.Linq;

namespace _0._4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            
            bool foundMatch = false;

            for (int row = 0; row < size; row++)
            {
                string consoleInput = Console.ReadLine();
                char[] input = consoleInput.ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char theSymbol = Convert.ToChar(Console.ReadLine());

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (theSymbol == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        foundMatch = true;
                        return;
                    }
                }
            }
            if (foundMatch == false)
            {
                Console.WriteLine($"{theSymbol} does not occur in the matrix");
            }
            
            
        }
    }
}
