using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._3.___Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lootChest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "Yohoho!")
                {
                    break;
                }

                string[] tokens = commands.Split();

                if (tokens[0] == "Loot")
                {
                    LootCommand(lootChest, tokens);
                }
                else if (tokens[0] == "Drop")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < lootChest.Count)
                    {
                        string dropItem = lootChest[index];
                        lootChest.RemoveAt(index);
                        lootChest.Add(dropItem);
                    }
                    //else
                    //{
                    //    continue;   
                    //}
                }
                else if (tokens[0] == "Steal")
                {
                    int count = int.Parse(tokens[1]);
                    List<string> stealItems = new List<string>();
                    if (count < lootChest.Count)
                    {
                        for (int i = count; i > 0; i--)
                        {
                            stealItems.Add(lootChest[lootChest.Count-1]);
                            lootChest.RemoveAt(lootChest.Count-1);
                        }

                        stealItems.Reverse();
                    }
                    else if (count >= lootChest.Count)
                    {
                        stealItems = lootChest.ToList();
                        lootChest.Clear();
                    }
                    Console.WriteLine(string.Join(", ", stealItems));
                    
                }
            }

            if (lootChest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double itemLength = 0;
                foreach (var item in lootChest)
                {
                    itemLength += item.Length;
                }

                double treasureGain = itemLength / lootChest.Count;
                Console.WriteLine($"Average treasure gain: {treasureGain:f2} pirate credits.");
            }
        }

        private static void LootCommand(List<string> lootChest, string[] tokens)
        {
            for (int i = 1; i < tokens.Length; i++)
            {
                if (!lootChest.Contains(tokens[i]))
                {
                    lootChest.Insert(0, tokens[i]);
                }
            }
        }
    }
}
