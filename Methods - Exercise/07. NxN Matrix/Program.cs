using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            NxNMatrix(number);
        }

        private static void NxNMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
