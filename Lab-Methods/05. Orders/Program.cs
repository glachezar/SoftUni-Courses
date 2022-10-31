using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            double result = 0.0;

            switch (product)
            {
                case "coffee":
                    result = Coffee(qty);
                    break;
                case "water":
                    result = Water(qty);
                    break;
                case "coke":
                    result = Coke(qty);
                    break;
                case "snacks":
                    result = Snacks(qty);
                    break;
            }
            Console.WriteLine($"{result:F2}");

        }

        static double Coffee (double qty)
        {
            return qty * 1.50;
        }

        static double Water(double qty)
        {
            return qty * 1.00;
        }

        static double Coke(double qty)
        {
            return qty * 1.40;
        }
        static double Snacks(double qty)
        {
            return qty * 2.00;
        }

    }
}
