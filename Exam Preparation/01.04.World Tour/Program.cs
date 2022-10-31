using System;
using System.Linq;

namespace _01._04.World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Travel")
                {
                    break;
                }

                string[] tokens = input.Split(":",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    string stringToInsert = tokens[2];
                    if (index >= 0 && index <= stops.Length)
                    {
                        stops = stops.Insert(index, stringToInsert);
                    }

                    Console.WriteLine(stops);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex <= endIndex && endIndex < stops.Length)
                    {
                        int count = endIndex - startIndex;
                        stops = stops.Remove(startIndex, count+1);
                    }

                    Console.WriteLine(stops);
                }
                else if (command == "Switch")
                {
                    string oldString = tokens[1];
                    string replacementString = tokens[2];
                    if (stops.Contains(oldString))
                    {
                       stops = stops.Replace(oldString, replacementString);
                    }

                    Console.WriteLine(stops);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
