using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads one line of double prices separated by ", ".
            //Print the prices with added VAT for all of them.
            //Format them to 2 signs after the decimal point.
            //The order of the prices must be the same.
            //VAT is equal to 20 % of the price.
            // 1.38, 2.56, 4.4
            //Func<string, string> addVAT = n => n = (double.Parse(n) * 1.2).ToString("F2");

            Console.WriteLine(String.Join(Environment.NewLine, Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(n => n = (double.Parse(n) * 1.2).ToString("F2"))));
        }
    }
}
