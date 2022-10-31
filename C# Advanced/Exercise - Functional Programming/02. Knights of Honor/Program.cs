using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = x =>
            {
                foreach (var name in x)
                {

                    Console.WriteLine("Sir " + name);
                }
            };

            print(Console.ReadLine().Split());


        }
    }
}
