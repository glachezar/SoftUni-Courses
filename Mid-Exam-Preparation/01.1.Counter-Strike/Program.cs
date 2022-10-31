using System;

namespace _01._1.Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battlesWonCount = 0;

            while (command != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);
                if (energy >= distanceToEnemy)
                {
                    battlesWonCount++;
                    energy -= distanceToEnemy;
                }
                else if (distanceToEnemy > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWonCount} won battles and {energy} energy");
                    return;
                }

                if (battlesWonCount % 3 == 0)
                {
                    energy += battlesWonCount;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {battlesWonCount}. Energy left: {energy}");
        }
    }
}
