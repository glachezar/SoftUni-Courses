using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNewLine = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            printNewLine(Console.ReadLine().Split());
        }
    }
}
