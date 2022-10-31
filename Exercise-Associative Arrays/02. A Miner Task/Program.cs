using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesGathered = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int amountOfResources = int.Parse(Console.ReadLine());
                if (!resourcesGathered.ContainsKey(resource))
                {
                    resourcesGathered.Add(resource, amountOfResources);
                }
                else if (resourcesGathered.ContainsKey(resource))
                {
                    resourcesGathered[resource] += amountOfResources;
                }
            }

            foreach (var resource in resourcesGathered)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
