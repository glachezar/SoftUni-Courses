using System;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double item = double.Parse(Console.ReadLine());
                box.InputValue.Add(item);
            }

            double itemToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.ComparisonByValue(itemToCompare));
        }
    }
}
