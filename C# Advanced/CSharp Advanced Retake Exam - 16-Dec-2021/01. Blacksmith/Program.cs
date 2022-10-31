using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int forgedSwordsCount = 0;
            Dictionary<int, string> swords = new Dictionary<int, string>
            {
                {70 , "Gladius"},
                {80 , "Shamshir"},
                {90 , "Katana"},
                {110 , "Sabre"},
                {150 , "Broadsword"},
            };

            SortedDictionary<string, int> forgedSwords = new SortedDictionary<string, int>();

            while (steel.Any() && carbon.Any())
            {
                int currSteel = steel.Dequeue();
                int currCarbon = carbon.Pop();

                int forge = currCarbon + currSteel;
                if (swords.ContainsKey(forge))
                {
                    if (!forgedSwords.ContainsKey(swords[forge]))
                    {
                        forgedSwords.Add(swords[forge], 0);
                    }

                    forgedSwords[swords[forge]]++;
                    forgedSwordsCount++;
                }
                else
                {
                    carbon.Push(currCarbon + 5);
                }
            }

            if (forgedSwordsCount > 0) Console.WriteLine($"You have forged {forgedSwordsCount} swords.");
            else Console.WriteLine("You did not have enough resources to forge a sword.");

            if (steel.Count > 0) Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            else Console.WriteLine("Steel left: none");

            if (carbon.Count > 0) Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            else Console.WriteLine("Carbon left: none");

            foreach (var sword in forgedSwords)
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }
        }
    }
}
