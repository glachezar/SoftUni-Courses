using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double result1 = FactorialNumber(num1);
            double result2 = FactorialNumber(num2);
            PrintResult(result1, result2);
        }
        private static double FactorialNumber(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
        private static void PrintResult(double result1, double result2) => Console.WriteLine($"{result1 / result2:F2}");
    }
}
