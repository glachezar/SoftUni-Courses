using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequenceOfParentheses = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            char[] validOpening = new[] { '(', '[', '{' };
            char[] validClosing = new[] { ')', ']', '}' };
            string[] validPairs = new[] { "()", "[]", "{}" };
            bool isBalanced = true;
            foreach (var ch in sequenceOfParentheses)
            {
                if (validOpening.Contains(ch))
                {
                    stack.Push(ch);
                }
                else if (validClosing.Contains(ch))
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    StringBuilder sb = new StringBuilder();
                    sb.Append(stack.Pop());
                    sb.Append(ch);
                    string checkForMatches = sb.ToString();
                    if (!validPairs.Contains(checkForMatches))
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            
            
        }
    }
}
