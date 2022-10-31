using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int topNumberCeiling = int.Parse(Console.ReadLine());
            TopIntegers(topNumberCeiling);
        }
        //· Its sum of digits is divisible by 8, e.g. 8, 17, 88

        //· Holds at least one odd digit, e.g. 232, 707, 87578

        //· Some examples of top numbers are: 17, 161, 251, 4310, 123200
        private static void TopIntegers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDigitSumDivisibleBy8(i) && HasOddDigit(i))
                    Console.WriteLine(i);
            }
        }

        private static bool IsDigitSumDivisibleBy8(int number)
        {
            int digitSum = 0;
            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            if (digitSum % 8 == 0)
                return true;

            return false;
        }
        private static bool HasOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                    return true;
                number /= 10;
            }

            return false;
        }
    }
}
