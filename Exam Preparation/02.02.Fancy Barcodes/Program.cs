using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._02.Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+(?<characters>[A-Z][a-zA-Z\d]{4,}[A-Z])@#+";

            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string barcode = Console.ReadLine();

                if (Regex.IsMatch(barcode, pattern))
                {
                    char[] digits = barcode.Where(char.IsDigit).ToArray();

                    string barcodeGroup = digits.Length == 0 ? "00" : string.Join("", digits);

                    Console.WriteLine($"Product group: {barcodeGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
