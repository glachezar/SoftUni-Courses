using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceOfBullet = int.Parse(Console.ReadLine());
            var sizeOfGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int usedBulletsCount = 0;
            while (bullets.Count > 0 && locks.Count > 0 )
            {
                var currentBulletSize = bullets.Pop();
                usedBulletsCount++;

                if (currentBulletSize > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }

                if (usedBulletsCount % sizeOfGunBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }

            }

            if (locks.Count == 0)
            {
                var expenses = usedBulletsCount * priceOfBullet;
                var moneyEarned = valueOfIntelligence - expenses;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else if (locks.Count > 0 && bullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
