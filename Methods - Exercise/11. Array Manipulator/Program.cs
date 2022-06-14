using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int givenIndex = int.Parse(command[1]);
                    arr = ExchangeArr(arr, givenIndex);
                }
                else if (command[0] == "max" || command[0] == "min")
                {
                    FindMinMax(arr, command[0], command[1]);
                }
                else if (command[0] == "first" || command[0] == "last")
                {
                    FindFirstLast(arr, command[0], int.Parse(command[1]), command[2]);
                }

                command = Console.ReadLine().Split();
            }

        }

        private static void FindFirstLast(int[] arr, string position, int numCount, string evenOrOdd)
        {
            if (numCount > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (numCount == 0 )
            {
                Console.WriteLine($"[]");
                return;
            }

            int resultEvenOrOdd = 1;
            if (evenOrOdd == "even") resultEvenOrOdd = 0;
            int count = 0;
            List<int> nums = new List<int>();

            if (position == "first")
            {
                foreach (int num in arr)
                {
                    if (num % 2 == resultEvenOrOdd)
                    {
                        count++;
                        nums.Add(num);
                    }

                    if (count == numCount) break;
                    
                }
                
            }
            else
            {
                for (int currIndex = arr.Length -1; currIndex >= 0; currIndex++)
                {
                    if (arr[currIndex] % 2 == resultEvenOrOdd)
                    {
                        count++;
                        nums.Add(arr[currIndex]);
                    }
                    if (count == numCount) break;
                }
                nums.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void FindMinMax(int[] arr, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;
            int resultEvenOdd = 1;
            if (evenOrOdd == "even") resultEvenOdd = 0;
            for (int currIndex = 0; currIndex < arr.Length; currIndex++)
            {
                if (arr[currIndex] % 2 == resultEvenOdd)
                {
                    if (minOrMax == "min" && min >= arr[currIndex])
                    {
                        min = arr[currIndex];
                        index = currIndex;
                    }
                    else if (minOrMax == "max" && max <= arr[currIndex])
                    {
                        max = arr[currIndex];
                        index = currIndex;
                    }
                }
            }
            Console.WriteLine(index > -1 ? index.ToString() : "No matches");
        }

        private static int[] ExchangeArr(int[] arr, int exchangeIndex)
        {
            if (exchangeIndex >= arr.Length || exchangeIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            int[] exchangedArr = new int[arr.Length];
            int index = 0;
            for (int i = exchangeIndex +1 ; i < arr.Length; i++)
            {
                exchangedArr[index] = arr[i];
                index++;
            }

            for (int i = 0; i <= exchangeIndex; i++)
            {
                exchangedArr[index] = arr[i];
                index++;
            }

            return exchangedArr;
        }
    }
}
