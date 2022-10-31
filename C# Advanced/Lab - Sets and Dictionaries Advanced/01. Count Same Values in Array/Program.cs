using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            List<string> list = new List<string>(input);

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (var item in list)
            {
                if (!result.ContainsKey(item))
                {
                    result.Add(item, 1);
                }
                else
                {
                    result[item]++;
                }
            }

            foreach (var num in result)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
