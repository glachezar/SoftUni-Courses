using System;
using System.Linq;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                box.InputValue.Add(item);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(box.ComparisonByValue(itemToCompare));
        }
    }
}
