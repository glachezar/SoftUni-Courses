using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = SumOfFirstTwoIntegers(num1, num2);
            SubtractThirdInteger(result, num3);
        }

        private static int SumOfFirstTwoIntegers(int num1, int num2)
        {
            return num1 + num2;
        }

        private static void SubtractThirdInteger(int result, int num3)
        {
            Console.WriteLine(result - num3);
        }
    }
}
