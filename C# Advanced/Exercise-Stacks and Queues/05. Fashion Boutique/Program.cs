using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> boxWithCloths = new Stack<int>(inputBox);

            int shelfSize = int.Parse(Console.ReadLine());

            int shelfUsed = 0;

            int currShelf = 0;

            while (boxWithCloths.Count > 0)
            {
                int currCloth = boxWithCloths.Peek();

                currShelf += currCloth;

                if (currShelf < shelfSize)
                {
                    boxWithCloths.Pop();
                    if (boxWithCloths.Count == 0)
                    {
                        shelfUsed++;
                    }
                }
                else if (currShelf == shelfSize)
                {
                    boxWithCloths.Pop();
                    shelfUsed++;
                    currShelf = 0;
                }
                else if (currShelf > shelfSize)
                {
                    shelfUsed++;
                    currShelf = 0;
                }
            }

            Console.WriteLine(shelfUsed);
        }
    }
}
