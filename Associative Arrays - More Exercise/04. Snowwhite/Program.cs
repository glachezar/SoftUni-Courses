using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            //string[] input  = Console.ReadLine().Split(new char[]{ ' ', '<', ':', '>' }).ToArray();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Once upon a time")
                {
                    break;
                }

                var tokens = command.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = tokens[0];
                string dwarfHatColor = tokens[1];
                int dwarfPhysics = int.Parse(tokens[2]);
                var dwarfID = $"{dwarfName}:{dwarfHatColor}";
                if (!dwarfs.ContainsKey(dwarfID))
                {
                    dwarfs.Add(dwarfID, dwarfPhysics);
                }
                else
                {
                    dwarfs[dwarfID] = Math.Max(dwarfs[dwarfID], dwarfPhysics);
                }
                
            }

            foreach (var KVP in dwarfs.OrderByDescending(x => x.Value)
                         .ThenByDescending(currDwarf => dwarfs
                             .Where(hatColor => hatColor.Key
                                 .Split(":")[1] == currDwarf.Key
                                 .Split(":")[1]).Count()))
            {
                string hatColor = KVP.Key.Split(":")[1];
                string name = KVP.Key.Split(":")[0];
                Console.WriteLine($"({hatColor}) {name} <-> {KVP.Value}");
            }

        }
    }

    
}
