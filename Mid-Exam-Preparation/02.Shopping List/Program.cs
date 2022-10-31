using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split().ToArray();

                if (tokens[0] == "Urgent")
                {
                    if (!groceries.Contains(tokens[1]))
                    {
                        groceries.Insert(0, tokens[1]);
                    }
                }

                else if (tokens[0] == "Unnecessary")
                {
                    if (groceries.Contains(tokens[1]))
                    {
                        groceries.Remove(tokens[1]);
                    }
                }
                else if (tokens[0] == "Correct")
                {
                    if (groceries.Contains(tokens[1]))
                    {
                        int index = groceries.IndexOf(tokens[1]);
                        groceries.RemoveAt(index);
                        groceries.Insert(index, tokens[2]);
                    }
                }
                else if (tokens[0] == "Rearrange")
                {
                    if (groceries.Contains(tokens[1]))
                    {
                        int index = groceries.IndexOf(tokens[1]);
                        groceries.RemoveAt(index);
                        groceries.Add(tokens[1]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
