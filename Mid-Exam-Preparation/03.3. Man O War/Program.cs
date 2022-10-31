using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._3._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealthCapacity = int.Parse(Console.ReadLine());
            string pirateShipStatus = "ok";
            string warShipStatus = "ok";

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Retire")
                {

                    break;
                }

                string[] tokens = command.Split().ToArray();

                if (tokens[0] == "Fire")
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);
                    if (index >= 0 && index < warShip.Count)
                    {
                        ShootAtWarShip(warShip, index, damage);
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            warShipStatus = "notOk";
                            break;
                        }
                    }
                }
                else if (tokens[0] == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);
                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            int indexNumber = i;
                            int result = pirateShip[indexNumber] - damage;
                            if (result <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                pirateShipStatus = "notOk";
                                break;
                            }
                            else
                            {
                                pirateShip.Remove(pirateShip[indexNumber]);
                                pirateShip.Insert(startIndex, result);
                                startIndex++;
                            }
                        }
                        
                    }
                }
                else if (tokens[0] == "Repair")
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);
                    if (index >= 0 && index < pirateShip.Count)
                    {
                        RepairPirateShip(pirateShip, index, health, maxHealthCapacity);
                    }
                }
                else if (tokens[0] == "Status")
                {
                    GetStatus(pirateShip, maxHealthCapacity);
                }
            }

            if (pirateShipStatus == "ok" && warShipStatus == "ok")
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }


            
        }

        private static void ShootAtWarShip(List<int> warShip, int index, int damage)
        {
            warShip[index] -= damage;
        }

        

        private static void RepairPirateShip(List<int> pirateShip, int index, int health, int  maxHealth)
        {
            if (pirateShip[index] + health > maxHealth)
            {
                pirateShip[index] = health;
            }
            else
            {
                pirateShip[index] += health;
            }
        }

        private static void GetStatus(List<int> pirateShip, int maxHealthCapacity)
        {
            int count = 0;

            foreach (var section in pirateShip)
            {
                if (section < maxHealthCapacity * 0.2)
                {
                    count ++;
                }
            }

            Console.WriteLine($"{count} sections need repair.");
        }
    }
}
