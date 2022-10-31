using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<product>[A-Z-a-z\s]+)<<(?<price>\d+(.\d+)?)!(?<qty>\d+)";

            List<string> productNameList = new List<string>();
            string input = Console.ReadLine();
            double totalMoneySpent = 0;

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    var name = match.Groups["product"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var qty = int.Parse(match.Groups["qty"].Value);
                    productNameList.Add(name);
                    totalMoneySpent += price * qty;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            productNameList.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalMoneySpent:f2}");
        }
    }
}
