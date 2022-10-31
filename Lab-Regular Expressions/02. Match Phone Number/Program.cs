using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"( ?\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection match = regex.Matches(input);

            var matchedPhones = match.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
