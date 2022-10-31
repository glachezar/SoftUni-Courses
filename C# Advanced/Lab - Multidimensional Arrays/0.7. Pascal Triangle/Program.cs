using System;

namespace _0._7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] pascal = new long[size][];
            long currentWidth = 1;
            for (long row = 0; row < size; row++)
            {
                pascal[row] = new long[currentWidth];
                long[] currentRow = pascal[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;

                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = pascal[row - 1];
                        long prevoiousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = prevoiousRowSum;
                    }
                }
            }

            foreach (var row in pascal)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
