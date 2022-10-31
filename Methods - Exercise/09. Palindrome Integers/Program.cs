using System;
using System.Data;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int num = 0;
            while ((command = Console.ReadLine()) != "END" )
            {
                 num = int.Parse(command);
                 PalindromeNumber(num);
            }
        }

        private static void PalindromeNumber(int num)
        {
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
