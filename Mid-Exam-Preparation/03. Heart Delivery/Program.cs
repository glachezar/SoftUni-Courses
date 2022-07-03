using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            
            int lastHouse = 0;


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Love!")
                {
                    break;
                }

                string[] tokens = command.Split();

                int jump = int.Parse(tokens[1]);

                if (lastHouse + jump > neighborhood.Length - 1)
                {
                    lastHouse = 0;

                    CheckPlace(lastHouse, neighborhood);
                }
                else
                {
                    lastHouse += jump;

                    CheckPlace(lastHouse, neighborhood);
                }
            }

            Console.WriteLine($"Cupid's last position was {lastHouse}.");
            int failedHouses = GetFailedHouses(neighborhood);
            if (failedHouses > 0)
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
            else if (failedHouses == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
        }

        private static int GetFailedHouses(int[] neighborhood)
        {
            int failedHouses = 0;
            foreach (var house in neighborhood)
            {
                if (house != 0)
                {
                    failedHouses++;
                }
            }
            return failedHouses;
        }

        private static void CheckPlace(int currentHouse, int[] neighborhood)
        {
            if (neighborhood[currentHouse] == 0)
            {
                Console.WriteLine($"Place {currentHouse} already had Valentine's day.");
            }
            else
            {
                neighborhood[currentHouse] -= 2;

                if (neighborhood[currentHouse] == 0)
                {
                    Console.WriteLine($"Place {currentHouse} has Valentine's day.");
                }
            }
        }
    }
}
