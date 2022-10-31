using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Stack<int> result = new Stack<int>();

            Action<Stack<int>> print = x => Console.WriteLine(String.Join(" ", x.Reverse()));

            for (int i = 1; i <= maxNumber; i++)
            {
                Predicate<int> isDivisible = x => i % x == 0;

                result.Push(i);

                for (int divIndex = 0; divIndex < dividers.Length; divIndex++)
                {
                    if (!isDivisible(dividers[divIndex]))
                    {
                        result.Pop();
                        break;
                    }
                }
            }
            print(result);
        }
    }
}
