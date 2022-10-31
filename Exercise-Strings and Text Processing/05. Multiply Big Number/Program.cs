using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine(); // 9999
            int multiplier = int.Parse(Console.ReadLine()); // 9

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder();
            int currNum = 0;
            int currDozens = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                string num = number[i].ToString();
                int currDigit = int.Parse(num); // 9 
                int currResult = currDigit * multiplier + currDozens; // 81
                result.Append(currResult % 10);

                currDozens = currResult / 10; // 8

                //int lastDigit = currResult % 10; // 1
            }

            if (currDozens > 0)
            {
                result.Append(currDozens);
            }
            //char[] charArray = result.ToString().ToCharArray();
            //Array.Reverse(charArray);
            //string finalResult = new string(charArray);
            StringBuilder finalResult = new StringBuilder();
            for (int i = result.Length - 1; i >= 0; i--)
            {
                finalResult.Append(result[i]);
            }

            Console.WriteLine(finalResult);

        }
    }
}
