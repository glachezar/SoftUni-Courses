using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestsAndDishes = new Dictionary<string, List<string>>();
            int countOfUnlikedMeals = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop") break;

                string[] tokens = input.Split("-").ToArray();
                string command = tokens[0];

                if (command == "Like")
                {
                    string guestt = tokens[1];
                    string meall = tokens[2];
                    if (!guestsAndDishes.ContainsKey(guestt))
                    {
                        guestsAndDishes.Add(guestt, new List<string>());
                        guestsAndDishes[guestt].Add(meall);
                    }
                    else if (guestsAndDishes.ContainsKey(guestt) && !guestsAndDishes[guestt].Contains(meall))
                    {
                        guestsAndDishes[guestt].Add(meall);
                    }
                }
                else if (command == "Dislike")
                {

                    string guest = tokens[1];
                    string meall = tokens[2];

                    if (!guestsAndDishes.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (guestsAndDishes.ContainsKey(guest) && guestsAndDishes[guest].Contains(meall))
                    {
                        Console.WriteLine($"{guest} doesn't like the {meall}.");
                        countOfUnlikedMeals++;
                        guestsAndDishes[guest].Remove(meall);
                    }
                    else if (guestsAndDishes.ContainsKey(guest) && !guestsAndDishes[guest].Contains(meall))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meall} in his/her collection.");
                    }

                }

            }
            foreach (var guest in guestsAndDishes)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {countOfUnlikedMeals}");
        }
    }
}
