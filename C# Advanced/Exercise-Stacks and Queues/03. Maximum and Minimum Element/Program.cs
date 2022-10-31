using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());

            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();

                if (tokens[0] == "1")
                {
                    int numberToPush = int.Parse(tokens[1]);
                    myStack.Push(numberToPush);
                }
                else if (tokens[0] == "2")
                {
                    myStack.Pop();
                }
                else if (tokens[0] == "3")
                {
                    if (myStack.Count > 0)
                    {
                        Console.WriteLine(myStack.Max());
                    }
                }
                else if (tokens[0] == "4")
                {
                    if (myStack.Count > 0)
                    {
                        Console.WriteLine(myStack.Min());
                    }
                }
            }
            if (myStack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", myStack));
            }
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.
        }
    }
}
