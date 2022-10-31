using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootBox = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> secondLootBox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int lootedItemsSum = 0;

            while (firstLootBox.Any() && secondLootBox.Any())
            {
                int sum = firstLootBox.Peek() + secondLootBox.Peek();
                if (sum % 2 == 0)
                {
                    lootedItemsSum += sum;
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    int lastItemFromSecondBox = secondLootBox.Pop();
                    firstLootBox.Enqueue(lastItemFromSecondBox);
                }
            }

            if (!firstLootBox.Any()) Console.WriteLine("First lootbox is empty");
            
            else Console.WriteLine("Second lootbox is empty");

            if (lootedItemsSum >= 100) Console.WriteLine($"Your loot was epic! Value: {lootedItemsSum}");
            else Console.WriteLine($"Your loot was poor... Value: {lootedItemsSum}");
        }
    }
}
