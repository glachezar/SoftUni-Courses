using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Finish")
                {
                    break;
                }

                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int value = int.Parse(tokens[1]);
                    sequence.Add(value);
                }
                else if (tokens[0] == "Remove")
                {
                    int value = int.Parse(tokens[1]);
                    sequence.Remove(value);
                }
                else if (tokens[0] == "Replace")
                {
                    int value = int.Parse(tokens[1]);
                    int replacement = int.Parse(tokens[2]);
                    if (sequence.Contains(value))
                    {
                        int index = sequence.IndexOf(value);
                        sequence.RemoveAt(index);
                        sequence.Insert(index, replacement);
                    }
                }
                else if (tokens[0] == "Collapse")
                {
                    int value = int.Parse(tokens[1]);
                    sequence.RemoveAll(num => num < value);
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
