using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace _03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var reversedInput = Reverse(input);

            

            Stack<string> stack = new Stack<string>(reversedInput);

            int result = -1;
            while (stack.Count > 0)
            {
                

                if (result == -1)
                {
                    var num = int.Parse(stack.Pop());
                    result = num;
                }
                else if (result >= 0)
                {
                    var operation = stack.Pop();
                    var number = int.Parse(stack.Pop());
                    if (operation == "-" || operation == "-")
                    {
                        result -= number;
                    }
                    else if (operation == "+")
                    {
                        result += number;
                    }
                }
            }
            Console.WriteLine(result);  
        }
        public static List<string> Reverse(List<string> text)
        {
            List<string> reverse = new List<string>();

            for (int i = text.Count - 1; i > -1; i--)
            {
                reverse.Add(text[i]);
            }
            
            return reverse;
        }


    }
}
