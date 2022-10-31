using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\b[A-Z][a-z]+) ([A-Z][a-z]+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            
            MatchCollection match = regex.Matches(input);

            foreach (Match name in match)
            {
                Console.Write($"{name.Value} ");
            }
        }
    }
}
