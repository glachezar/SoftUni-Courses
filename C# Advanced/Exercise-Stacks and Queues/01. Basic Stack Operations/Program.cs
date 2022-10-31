using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = input[0];
            int elementsToPop = input[1];
            int containingElement = input[2];

            int[] integerToPush = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>(integerToPush);

            for (int i = 0; i < elementsToPop; i++)
            {
                myStack.Pop();
            }

            if (myStack.Contains(containingElement))
            {
                Console.WriteLine("true");
            }
            else if (myStack.Count == 0)
            {
                Console.WriteLine(myStack.Count);
            }
            else
            {
                Console.WriteLine(myStack.Min());
            }
        }
    }
}
