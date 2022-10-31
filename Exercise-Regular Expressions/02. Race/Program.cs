using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex patternForName = new Regex(@"(?<name>[A-Za-z])");
            var patternForDigits = @"(?<distance>\d+)";
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[] participants = Console.ReadLine().Split(", ").ToArray();
            foreach (var participant in participants)
            {
                result.Add(participant, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection participantName = patternForName.Matches(input);
                MatchCollection participantDigits = Regex.Matches(input, patternForDigits);
                string currName = String.Join("", participantName);
                string distanceRunne = String.Join("", participantDigits);
                int distance = 0;
                if (result.ContainsKey(currName))
                {
                    foreach (var digit in distanceRunne)
                    {
                        distance += int.Parse(digit.ToString());
                    }

                    result[currName] += distance;
                }

                input = Console.ReadLine();
            }

            var orderedByResult = result.OrderByDescending(x => x.Value).Take(3);

            var firstPlace = orderedByResult.Take(1);
            var secondPlace = orderedByResult.OrderByDescending(x=>x.Value)
                .Take(2).OrderBy(x=>x.Value).Take(1);
            var thirdPlace = orderedByResult.OrderBy(x => x.Value).Take(1);
            foreach (var first in firstPlace)
            {
                Console.WriteLine($"1st place: {first.Key}");
            }
            foreach (var second in secondPlace)
            {
                Console.WriteLine($"2nd place: {second.Key}");
            }
            foreach (var third in thirdPlace)
            {
                Console.WriteLine($"3rd place: {third.Key}");
            }
        }
    }
}
