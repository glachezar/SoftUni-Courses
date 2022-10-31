using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<double>>> dragons =
                new Dictionary<string, Dictionary<string, List<double>>>();

            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                var value = 0;
                //"{type} {name} {damage} {health} {armor}"
                string dragonType = tokens[0];
                string dragonName = tokens[1];
                int dragonDamage = int.TryParse(tokens[2], out value) ? value : 45;
                int dragonHealth = int.TryParse(tokens[3], out value) ? value : 250;
                int dragonArmor = int.TryParse(tokens[4], out value) ? value : 10;
                if (!dragons.ContainsKey(dragonType))
                {
                    dragons.Add(dragonType, new Dictionary<string, List<double>>());
                }

                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType].Add(dragonName, new List<double>());
                    dragons[dragonType][dragonName].Add(dragonDamage);
                    dragons[dragonType][dragonName].Add(dragonHealth);
                    dragons[dragonType][dragonName].Add(dragonArmor);
                }
                else
                {
                    dragons[dragonType][dragonName].Clear();
                    dragons[dragonType][dragonName].Add(dragonDamage);
                    dragons[dragonType][dragonName].Add(dragonHealth);
                    dragons[dragonType][dragonName].Add(dragonArmor);
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, List<double>>> dragonType in dragons)
            {
                double avgDamage = 0d;
                double avgHealth = 0d;
                double avgArmor = 0d;
                double count = 0d;
                foreach (KeyValuePair<string, List<double>> stats in dragonType.Value)
                {
                    List<double> dragonStats = stats.Value;
                    avgDamage += dragonStats[0];
                    avgHealth += dragonStats[1];
                    avgArmor += dragonStats[2];
                    count++;
                }

                Console.WriteLine($"{dragonType.Key}::({avgDamage / count:f2}/{avgHealth / count:f2}/{avgArmor / count:f2})");

                foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
                {
                    List<double> dragonInfo = dragon.Value;

                    Console.WriteLine($"-{dragon.Key} -> damage: {dragonInfo[0]}, health: {dragonInfo[1]}, armor: {dragonInfo[2]}");
                }
            }
        }
    }
}
