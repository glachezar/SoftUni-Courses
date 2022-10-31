using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> undoStack = new Stack<string>();
            undoStack.Push(String.Empty);

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];

                // 1. Append command.
                if (command == "1")
                {
                    sb.Append(commandArgs[1]);
                    undoStack.Push(sb.ToString());
                }
                // 2. Erase command.
                else if (command == "2")
                {
                    int charsToErase = int.Parse(commandArgs[1]);
                    sb = sb.Remove(sb.Length - charsToErase, charsToErase);
                    undoStack.Push(sb.ToString());
                }
                // 3. Return(print) command. (Returns element at given position.)
                else if (command == "3")
                {
                    int elementPosition = int.Parse(commandArgs[1]);
                    string currString = undoStack.Peek();
                    if (elementPosition >= 1 && elementPosition <= currString.Length)
                    {
                        Console.WriteLine(currString[elementPosition-1]);
                    }
                }
                // 4. Undo => undoes the last not undone command of type 1 or 2 and returns the text to the state before that operation.
                else if (command == "4")
                {
                    undoStack.Pop();
                    string oldText = undoStack.Peek();
                    sb = new StringBuilder(oldText);
                }
            }
        }
    }
}
