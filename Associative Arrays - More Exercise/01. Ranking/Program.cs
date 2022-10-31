using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> nameAndContestWithPoints = new SortedDictionary<string, Dictionary<string, int>>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = command.Split(':').ToArray();
                string nameOfContest = tokens[0];
                string passwordOfContest = tokens[1];
                contestAndPassword.Add(nameOfContest, passwordOfContest);
            }

            string submission = string.Empty;
            while ((submission = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = submission.Split("=>").ToArray();
                string contest = tokens[0];
                string password = tokens[1];
                string studentName = tokens[2];
                int score = int.Parse(tokens[3]);

                if (contestAndPassword.ContainsKey(contest) && contestAndPassword.ContainsValue(password))
                {
                    if (!nameAndContestWithPoints.ContainsKey(studentName))
                    {
                        nameAndContestWithPoints.Add(studentName, new Dictionary<string, int>());
                        nameAndContestWithPoints[studentName].Add(contest, score);
                    }
                    if (nameAndContestWithPoints[studentName].ContainsKey(contest))
                    {
                        if (nameAndContestWithPoints[studentName][contest] < score)
                        {
                            nameAndContestWithPoints[studentName][contest] = score;
                        }
                    }
                    else
                    {
                        nameAndContestWithPoints[studentName].Add(contest, score);
                    }
                }
            }
            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in nameAndContestWithPoints)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestName = usernameTotalPoints.Keys.Max();
            int bestPoints = usernameTotalPoints.Values.Max();
            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var name in nameAndContestWithPoints)
            {
                Dictionary<string, int> dict = name.Value;
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine($"{name.Key}");
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }

            }
        }
    }
    
}
