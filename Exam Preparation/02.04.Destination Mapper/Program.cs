using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._04.Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|/)(?<location>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> destinations = new List<string>();
            
            int travelPoints = 0;

            foreach (Match match in matches)
            {
                travelPoints += match.Groups["location"].Value.Length;
                destinations.Add(match.Groups["location"].Value);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
