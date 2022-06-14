using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Power(baseNum, powerNum));
        }

        static double Power(double baseNum, double powerNum)
        {
            double result = Math.Pow(baseNum, powerNum);

            return result;
        }
    }
}
