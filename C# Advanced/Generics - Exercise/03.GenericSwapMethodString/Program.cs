using System;
using System.Linq;

namespace _03.GenericSwapMethodString
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

            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            box.Swap(indices[0], indices[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
