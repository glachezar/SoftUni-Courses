﻿using System;
using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();

            foreach (var word in input)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
