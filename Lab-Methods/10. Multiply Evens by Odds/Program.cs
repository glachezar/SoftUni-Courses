using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = Math.Abs(number);
            int sumOfEven = GetSumOfEvenDigits(num);
            int sumOfOdd = GetSumOfOddDigits(num);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOfEven, sumOfOdd));
        }

        static int GetMultipleOfEvenAndOdds(int sumOfEven, int sumOfOdd)
        {
            int result = sumOfEven * sumOfOdd;
            return result;
        }
        static int GetSumOfEvenDigits(int num)
        {
            int result = 0;
            string length = num.ToString();
            int currentNum = num;

            for (int i = 0; i < length.Length ; i++)
            {
                int lastDigit = currentNum % 10;
                currentNum = currentNum / 10;
                if (lastDigit % 2 == 0)
                {
                    result += lastDigit;
                }
            }
            return result;
        }

        static int GetSumOfOddDigits(int num)
        {
            int result = 0;
            string length = num.ToString();
            int currentNum = num;
            for (int i = 0; i < length.Length; i++)
            {
                int lastDigit = currentNum % 10;
                currentNum = currentNum / 10;

                if (lastDigit % 2 != 0)
                {
                    result += lastDigit;
                }
            }
            return result;
        }
    }
}
