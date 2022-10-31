using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> contestPasswrd = new Dictionary<string, string>();

            SortedDictionary<string, Dictionary<string, int>> participants = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end of contests")
                {
                    break;
                }
                string contest = input[0];
                string password = input[1];

                contestPasswrd.Add(contest, password);

            }
            //After that you will receive another type of inputs in the format "{contest}=>{password}=>{username}=>{points}" until you receive "end of submissions"
            while (true)
            {
                string[] tokens = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "end of submissions")
                {
                    break;
                }
                string contest = tokens[0];
                string password = tokens[1];
                string userName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestPasswrd.ContainsKey(contest) && contestPasswrd[contest] == password)
                {
                    if (!participants.ContainsKey(userName))
                    {
                        participants.Add(userName, new Dictionary<string, int>());
                    }
                    if (participants.ContainsKey(userName) && !participants[userName].ContainsKey(contest))
                    {
                        participants[userName].Add(contest, points);
                    }
                    if (participants.ContainsKey(userName) && participants[userName].ContainsKey(contest) && participants[userName][contest] < points)
                    {
                        participants[userName][contest] = points;
                    }
                }
            }

            string bestCandidate = participants.OrderByDescending(p => p.Value.Values.Sum()).First().Key;
            int bestCandidateTotalPoints = participants[bestCandidate].Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidateTotalPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var candidate in participants)
            {
                Console.WriteLine($"{candidate.Key}");

                var orderedByDescending = candidate.Value.OrderByDescending(r => r.Value);

                foreach (var contest in orderedByDescending)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
