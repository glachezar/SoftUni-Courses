using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stackOfIntegers = new Stack<int>();

            foreach (var number in numbers)
            {
                stackOfIntegers.Push(number);
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split().ToArray();

                string operation = tokens[0].ToLower();

                if (operation == "add")
                {
                    int num1 = int.Parse(tokens[1]);
                    int num2 = int.Parse(tokens[2]);
                    stackOfIntegers.Push(num1);
                    stackOfIntegers.Push(num2);
                }
                else if (operation == "remove")
                {
                    int n = int.Parse(tokens[1]);

                    if (stackOfIntegers.Count >= n)
                    {

                        for (int i = 0; i < n; i++)
                        {
                            stackOfIntegers.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            int count = stackOfIntegers.Count;
            if (count == 0)
            {
                Console.WriteLine($"Sum: {sum}");
            }
            else if (count > 0 )
            {
                for (int i = 0; i < count; i++)
                {
                    sum += stackOfIntegers.Pop();
                }
                Console.WriteLine($"Sum: {sum}");
            }
            
        }
    }
}
