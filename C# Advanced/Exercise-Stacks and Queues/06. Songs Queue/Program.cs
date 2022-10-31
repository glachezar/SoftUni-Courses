using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songsInput = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queueOfSongs = new Queue<string>(songsInput);

            while (queueOfSongs.Count > 0)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens[0] == "Play")
                {
                    queueOfSongs.Dequeue();
                }
                else if (tokens[0] == "Add")
                {
                    string songToAdd = String.Join(" ", tokens.Skip(1));

                    if (queueOfSongs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }
                    queueOfSongs.Enqueue(songToAdd);
                }
                else if (tokens[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", queueOfSongs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
