using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToEnque = input[0];
            int elementsToDeque = input[1];
            int containingElement = input[2];

            int[] integersToEnque = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> myQueue = new Queue<int>(integersToEnque);

            for (int i = 0; i < elementsToDeque; i++)
            {
                myQueue.Dequeue();
            }

            if (myQueue.Contains(containingElement))
            {
                Console.WriteLine("true");
            }
            else if (myQueue.Count == 0)
            {
                Console.WriteLine(myQueue.Count);
            }
            else
            {
                Console.WriteLine(myQueue.Min());
            }
        }
    }
}
