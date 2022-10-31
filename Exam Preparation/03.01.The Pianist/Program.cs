using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._01.The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            Dictionary<string, KeyValuePair<string, string>> organizedMusic = new Dictionary<string, KeyValuePair<string, string>>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieces = Console.ReadLine().Split('|').ToArray();

                string piece = pieces[0];
                string composer = pieces[1];
                string key = pieces[2];

                organizedMusic.Add(piece, new KeyValuePair<string, string>(composer, key));
                

            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] tokens = input.Split('|').ToArray();
                if (tokens[0] == "Add")
                {
                    string piece = tokens[1];
                    string composer = tokens[2];
                    string key = tokens[3];
                    if (!organizedMusic.ContainsKey(piece))
                    {
                        organizedMusic.Add(piece, new KeyValuePair<string, string>(composer, key));
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    string piece = tokens[1];
                    if (organizedMusic.ContainsKey(piece))
                    {
                        organizedMusic.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (tokens[0] == "ChangeKey")
                {
                    string piece = tokens[1];
                    string newKey = tokens[2];
                    if (organizedMusic.ContainsKey(piece))
                    {
                        var pieceData = organizedMusic[piece];
                        string composer = pieceData.Key;
                        organizedMusic[piece] = new KeyValuePair<string, string>(composer, newKey);
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var piece in organizedMusic)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Key}, Key: {piece.Value.Value}");
            }
        }
    }
}
