using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> index = new Stack<int>();
            List<string> results = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    index.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = index.Pop();
                    int endIndex = i;
                    StringBuilder sb = new StringBuilder();
                    for (int j = startIndex; j <= endIndex; j++)
                    {
                        sb.Append(input[j]);
                    }

                    string subExpression = sb.ToString();
                    results.Add(subExpression);
                }
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
