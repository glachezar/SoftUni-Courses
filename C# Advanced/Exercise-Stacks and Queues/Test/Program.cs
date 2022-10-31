using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputBox = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> boxWithCloths = new Stack<int>(inputBox);

            int shelfSize = int.Parse(Console.ReadLine());

            int cloth = 0;

            while (boxWithCloths.Count > 0)
            {
                
            }
            

            
        }
    }
}
