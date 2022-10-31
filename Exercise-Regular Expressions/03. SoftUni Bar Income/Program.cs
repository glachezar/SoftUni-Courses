using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"%(?<name>\b[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<qty>\d+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+?)\$";

            double income = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);
                if (isValid)
                {
                    Match match = regex.Match(input);
                    string customerName = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["qty"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double totalPrice = price * quantity;
                    income += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                }

            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
