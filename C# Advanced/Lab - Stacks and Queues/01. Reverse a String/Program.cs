using System;
using System.Collections.Generic;

namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int n = inputString.Length;

            Stack<string> reversedString = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                reversedString.Push(inputString[i].ToString());
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(reversedString.Pop());
            }
        }
    }
}
