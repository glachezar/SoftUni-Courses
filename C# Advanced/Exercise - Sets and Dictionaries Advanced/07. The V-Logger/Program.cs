using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<VloggerSystem> vloggers = new List<VloggerSystem>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }
                // EmilConrad joined The V-Logger
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vloggerName = tokens[0];
                string command = tokens[1];
                string followedVlogger = tokens[2];

                if (command == "joined")
                {
                    if (!vloggers.Any(v => v.Name == vloggerName))
                    {
                        vloggers.Add(new VloggerSystem(vloggerName));
                    }
                }
                else
                {
                    if (vloggerName == followedVlogger 
                        || !vloggers.Any(v => v.Name == vloggerName) 
                        || !vloggers.Any(v => v.Name == followedVlogger))
                    {
                        continue;
                    }
                    VloggerSystem vlogger = vloggers.Single(v => v.Name == vloggerName);
                    vlogger.Following.Add(followedVlogger);

                    VloggerSystem vloggerToFollow = vloggers.Single(v => v.Name == followedVlogger);
                    vloggerToFollow.Followers.Add(vloggerName);
                }

            }
            vloggers = vloggers.OrderByDescending(v => v.Followers.Count)
                .ThenBy(v => v.Following.Count)
                .ToList();

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                if (count == 1)
                {
                    foreach (var follower in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }

        public class VloggerSystem
        {
            public VloggerSystem(string name)
            {
                Name = name;

                Followers = new SortedSet<string>();

                Following = new HashSet<string>();
            }
            public string Name { get; set; }

            public SortedSet<string> Followers { get; set; }

            public HashSet<string> Following { get; set; }

        }
    }
}
