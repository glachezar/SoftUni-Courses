using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            SortedDictionary<string, Dictionary<string, int>> wardrobe = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < length; i++)
            {
                string[] clothes = Console.ReadLine().Split(new string[]{ " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

                string color = clothes[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int j = 1; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }
                    wardrobe[color][cloth]++;
                }
               
            }

            string[] lockingForItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var colorCloth in wardrobe)
            {
                Console.WriteLine($"{colorCloth.Key} clothes:");

                foreach (var cloth in colorCloth.Value)
                {
                    string printPattern = $"* {cloth.Key} - {cloth.Value} ";

                    if (colorCloth.Key == lockingForItem[0] && cloth.Key == lockingForItem[1])
                    {
                        printPattern += " (found!)";
                    }

                    Console.WriteLine(printPattern);
                }
            }
        }
    }
}
