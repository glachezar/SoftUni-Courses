using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whiteTilesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] greyTilesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> whiteTiles = new Stack<int>(whiteTilesInput);
            Queue<int> greyTiles = new Queue<int>(greyTilesInput);

            //Sink => 40
            //Oven => 50
            //Countertop => 60
            //Wall => 70
            // Floor => anything else
            Dictionary<string, int> location = new Dictionary<string, int>()
            {
                {"Sink", 40 },
                {"Oven", 50 },
                {"Countertop", 60 },
                {"Wall", 70 },
            };
            Dictionary<string, int> tilesLocations = new Dictionary<string, int>()
            {
                {"Sink", 0 },
                {"Oven", 0 },
                {"Countertop", 0 },
                {"Wall", 0 },
                {"Floor", 0 }
            };


            while (whiteTiles.Count != 0 && greyTiles.Count != 0)
            {
                int currWhiteTile = whiteTiles.Pop();
                int currGreyTile = greyTiles.Dequeue();

                if (currWhiteTile == currGreyTile)
                {
                    int tileArea = currWhiteTile + currGreyTile;

                    var possibleLocations = location.FirstOrDefault(x => x.Value == tileArea);

                    if (possibleLocations.Key != null)
                    {
                        tilesLocations[possibleLocations.Key]++;
                    }
                    else
                    {
                        tilesLocations["Floor"]++;
                    }
                }
                else if (currWhiteTile != currGreyTile)
                {
                    greyTiles.Enqueue(currGreyTile);

                    whiteTiles.Push(currWhiteTile / 2);
                }
            }
            string whiteLeft = whiteTiles.Count == 0 ? "none" : string.Join(", ", whiteTiles);
            string greyLeft = greyTiles.Count == 0 ? "none" : string.Join(", ", greyTiles);

            Console.WriteLine($"White tiles left: {whiteLeft}");
            Console.WriteLine($"Grey tiles left: {greyLeft}");

            tilesLocations = tilesLocations.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var place in tilesLocations)
            {
                if (place.Value > 0)
                {
                    Console.WriteLine($"{place.Key}: {place.Value}");
                }
            }
        }
    }
}
