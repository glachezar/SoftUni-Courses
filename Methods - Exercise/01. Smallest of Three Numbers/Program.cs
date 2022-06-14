using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SmalestOfThreeNumbers(num1, num2, num3));
        }

        static int SmalestOfThreeNumbers(int num1, int num2, int num3)
        {
            int result = 0;
            //if (num1 > num2 && num1 > num3)
            //{
            //    result = num1;
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    result = num2;
            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    result = num3;
            //}
            result = Math.Min(num1, Math.Min(num2, num3));
            return result;
        }
    }
}
