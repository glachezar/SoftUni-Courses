using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int item = int.Parse(Console.ReadLine());
                box.InputValue.Add(item);
            }

            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            box.Swap(indices[0], indices[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
